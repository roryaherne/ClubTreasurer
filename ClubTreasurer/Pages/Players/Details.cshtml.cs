using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public DetailsModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Players
                .Include(p => p.Position).FirstOrDefaultAsync(m => m.ID == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
