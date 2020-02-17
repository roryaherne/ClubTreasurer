using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using ClubTreasurer.ViewModels;

namespace ClubTreasurer.Pages.BankAccounts
{
    public class EditModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public EditModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BankAccountViewModel BankAccountModel { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            BankAccountModel = new BankAccountViewModel();

            BankAccountModel.BankAccount = await _context.BankAccounts
                .Include(b => b.LastModifiedBy)
                .Include(b => b.Person)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (BankAccountModel.BankAccount == null)
            {
                return NotFound();
            }
            BankAccountModel.AccountOwnerSelectList = new SelectList(_context.Persons.OrderBy(p => p.FullNameReverse), "ID", "FullNameReverse");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BankAccountModel.BankAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankAccountExists(BankAccountModel.BankAccount.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BankAccountExists(string id)
        {
            return _context.BankAccounts.Any(e => e.ID == id);
        }
    }
}
