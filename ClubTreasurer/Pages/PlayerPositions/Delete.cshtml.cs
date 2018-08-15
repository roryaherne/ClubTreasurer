using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.PlayerPositions
{
    public class DeleteModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public DeleteModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PlayerPosition PlayerPosition { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PlayerPosition = await _context.PlayerPositions.FirstOrDefaultAsync(m => m.ID == id);

            if (PlayerPosition == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PlayerPosition = await _context.PlayerPositions.FindAsync(id);

            if (PlayerPosition != null)
            {
                _context.PlayerPositions.Remove(PlayerPosition);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
