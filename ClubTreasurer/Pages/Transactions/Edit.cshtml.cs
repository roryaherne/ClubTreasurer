using ClubTreasurer.Models;
using ClubTreasurer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Pages.Transactions
{
    public class EditModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public EditModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public int TransactionCategoryId { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankTransaction = await _context.BankTransactions.AsNoTracking()
                .Include(b => b.TransactionCategory).FirstOrDefaultAsync(m => m.ID == id);

            if (bankTransaction == null)
            {
                return NotFound();
            }

            ViewData["TransactionCategoryId"] = new SelectList(_context.BankTransactionCategorys, "ID", "Name");
            TransactionCategoryId = bankTransaction.TransactionCategoryId;

            return Page();
        }

        
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var transactionToModify = await _context.BankTransactions
                .Include(b => b.TransactionCategory).FirstOrDefaultAsync(m => m.ID == id);

            if (await TryUpdateModelAsync<BankTransaction>(transactionToModify, "", t => t.TransactionCategoryId))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }


            return RedirectToPage("./Index");
        }

        private bool BankTransactionExists(int id)
        {
            return _context.BankTransactions.Any(e => e.ID == id);
        }
    }
}
