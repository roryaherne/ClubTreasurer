using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using ClubTreasurer.ViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;

namespace ClubTreasurer.Pages.Players
{
    public class EditModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public EditModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IFormFile NewImage { set; get; }

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

            ViewData["PositionId"] = new SelectList(_context.Set<PlayerPosition>(), "ID", "Name");
            //ViewData["BankAccount"] = new SelectList(_context.Set<BankAccount>().Where(a => a.PersonId == null), "ID", "Name");

            if (Player.Image != null)
                ViewData["ImageUrl"] = "data:image;base64," + Convert.ToBase64String(Player.Image);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Player).State = EntityState.Modified;

            try
            {
                if(NewImage != null && NewImage.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        NewImage.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        Player.Image = fileBytes;
                    }
                }
                    
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(Player.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.ID == id);
        }
    }
}
