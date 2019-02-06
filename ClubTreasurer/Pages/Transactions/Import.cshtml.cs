using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClubTreasurer.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using BankTransactions;
using ClubTreasurer.Utilities;
using System.Linq;

namespace ClubTreasurer.Pages.Transactions
{
    public class ImportModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public ImportModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public IFormFile ImportFile { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var test = ImportFile;
            var json = "";
            if (ImportFile != null && ImportFile.Length > 0)
            {
                using (var sr = new StreamReader(ImportFile.OpenReadStream()))
                {
                    json = sr.ReadToEnd();
                }
            }

            var georgeTransactions = ImportExport.ImportFromJson(json).GroupBy(t => t.ReferenceNumber).Select(grp => grp.First()).ToList();

            var result = await BankingUtils.SaveGeorgeTransactionsToDB(_context, georgeTransactions);

            if(result)
                return RedirectToPage("./Index");
            else
            {
                ViewData["ErrorMessage"] = "Tried to import duplicate data. Please use the Last export function in George banking";
                return Page();
            }
        }
    }
}