using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.Transactions
{
    public class DeleteModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public DeleteModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BankTransaction BankTransaction { get; set; }

        public async Task<IActionResult> OnGetAsync(string referenceNumber)
        {
            if (referenceNumber == null)
            {
                return NotFound();
            }

            BankTransaction = await _context.BankTransactions
                .Include(b => b.Account)
                .Include(b => b.LastModifiedBy)
                .Include(b => b.TransactionCategory).FirstOrDefaultAsync(m => m.ReferenceNumber == referenceNumber);

            if (BankTransaction == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BankTransaction = await _context.BankTransactions.FindAsync(id);

            if (BankTransaction != null)
            {
                _context.BankTransactions.Remove(BankTransaction);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
