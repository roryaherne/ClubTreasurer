using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using ClubTreasurer.Utilities;

namespace ClubTreasurer.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public DetailsModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }
        public List<BankTransaction> BankTransactions { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Players
                .Include(p => p.Position)
                .Include(p => p.BankAccounts)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Player == null)
            {
                return NotFound();
            }
            if (Player.Image != null)
                ViewData["ImageUrl"] = "data:image;base64," + Convert.ToBase64String(Player.Image);

            BankTransactions = await _context.BankTransactions
                .Where(t => t.Account.PersonId == Player.ID)
                .Include(t => t.TransactionCategory).ToListAsync();

            return Page();
        }
    }
}
