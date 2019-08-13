using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.Transactions
{
    public class CreateModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public CreateModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AccountId"] = new SelectList(_context.BankAccounts, "ID", "ID");
        ViewData["LastModifiedById"] = new SelectList(_context.AppUsers, "Id", "Id");
        ViewData["TransactionCategoryId"] = new SelectList(_context.BankTransactionCategorys, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public BankTransaction BankTransaction { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BankTransactions.Add(BankTransaction);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}