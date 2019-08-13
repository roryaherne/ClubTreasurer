using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

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
        public BankAccount BankAccount { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            BankAccount = await _context.BankAccounts
                .Include(b => b.LastModifiedBy)
                .Include(b => b.Person).FirstOrDefaultAsync(m => m.ID == id);

            if (BankAccount == null)
            {
                return NotFound();
            }
           ViewData["LastModifiedById"] = new SelectList(_context.AppUsers, "Id", "Id");
           ViewData["PersonId"] = new SelectList(_context.Persons, "ID", "FullName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BankAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankAccountExists(BankAccount.ID))
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
