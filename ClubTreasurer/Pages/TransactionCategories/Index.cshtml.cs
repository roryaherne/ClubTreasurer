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
    public class IndexModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public IndexModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        public IList<BankTransactionCategory> BankTransactionCategory { get;set; }

        public async Task OnGetAsync()
        {
            BankTransactionCategory = await _context.BankTransactionCategorys
                .Include(b => b.LastModifiedBy).ToListAsync();
        }
    }
}
