using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.TransactionCategories
{
    public class DetailsModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public DetailsModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        public BankTransactionCategory BankTransactionCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BankTransactionCategory = await _context.BankTransactionCategorys
                .Include(b => b.LastModifiedBy).FirstOrDefaultAsync(m => m.ID == id);

            if (BankTransactionCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
