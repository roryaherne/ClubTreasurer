using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClubTreasurer.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using BankTransactions;
using ClubTreasurer.Utilities;

namespace ClubTreasurer.Pages.Transactions
{
    public class ImportModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public ImportModel(ClubTreasurer.Models.ClubTreasurerContext context)
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

            var georgeTransactions = ImportExport.ImportFromJson(json);

            await BankingUtils.SaveGeorgeTransactionsToDB(_context, georgeTransactions);

            return RedirectToPage("./Index");
        }
    }
}