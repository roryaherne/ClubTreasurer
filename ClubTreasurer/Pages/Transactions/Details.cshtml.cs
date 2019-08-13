using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.Transactions
{
    public class DetailsModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public DetailsModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        public BankTransaction BankTransaction { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
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
            return Page();
        }
    }
}
