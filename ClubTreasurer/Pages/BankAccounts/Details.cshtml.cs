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
    public class DetailsModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public DetailsModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
