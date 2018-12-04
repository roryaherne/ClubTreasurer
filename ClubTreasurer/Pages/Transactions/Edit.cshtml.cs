using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.Transactions
{
    public class EditModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public EditModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BankTransaction BankTransaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BankTransaction = await _context.BankTransactions
                .Include(b => b.Account)
                .Include(b => b.LastModifiedBy)
                .Include(b => b.TransactionCategory).FirstOrDefaultAsync(m => m.ID == id);

            if (BankTransaction == null)
            {
                return NotFound();
            }
           ViewData["AccountId"] = new SelectList(_context.BankAccounts, "ID", "IBAN");
           ViewData["LastModifiedById"] = new SelectList(_context.AppUsers, "Id", "Id");
           ViewData["TransactionCategoryId"] = new SelectList(_context.BankTransactionCategorys, "ID", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BankTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankTransactionExists(BankTransaction.ID))
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

        private bool BankTransactionExists(int id)
        {
            return _context.BankTransactions.Any(e => e.ID == id);
        }
    }
}
