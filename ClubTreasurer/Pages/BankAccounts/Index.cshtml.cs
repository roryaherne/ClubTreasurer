using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public IndexModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; }

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccounts
                .Include(b => b.LastModifiedBy)
                .Include(b => b.Person).ToListAsync();
        }
    }
}
