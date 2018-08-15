using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.PlayerPositions
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
            return Page();
        }

        [BindProperty]
        public PlayerPosition PlayerPosition { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PlayerPositions.Add(PlayerPosition);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}