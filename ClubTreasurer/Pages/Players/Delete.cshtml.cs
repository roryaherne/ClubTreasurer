﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.Players
{
    public class DeleteModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public DeleteModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

            if (Player.Image != null)
                ViewData["ImageUrl"] = "data:image;base64," + Convert.ToBase64String(Player.Image);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Players.FindAsync(id);

            if (Player != null)
            {
                _context.Players.Remove(Player);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
