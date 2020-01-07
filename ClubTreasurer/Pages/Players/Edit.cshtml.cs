using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.ComponentModel.DataAnnotations;
using ClubTreasurer.Utilities;
using ClubTreasurer.ViewModels;

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
        [Display(Name = "New Image")]
        public IFormFile NewImage { get; set; }

        [BindProperty]
        public PlayerViewModel PlayerModel { get; set; }

        private Player player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            player = await _context.Players
                .Include(p => p.Position).FirstOrDefaultAsync(m => m.ID == id);

            if (player == null)
            {
                return NotFound();
            }

            PlayerModel = new PlayerViewModel();

            PlayerModel.FirstName = player.FirstName;
            PlayerModel.LastName = player.LastName;
            PlayerModel.DOB = player.DOB;
            PlayerModel.Email = player.Email;
            PlayerModel.ID = player.ID;
            PlayerModel.PositionId = player.PositionId;

            ViewData["PositionId"] = new SelectList(_context.Set<PlayerPosition>(), "ID", "Name");
            //ViewData["BankAccount"] = new SelectList(_context.Set<BankAccount>().Where(a => a.PersonId == null), "ID", "Name");

            if (player.Image != null)
                ViewData["ImageUrl"] = "data:image;base64," + Convert.ToBase64String(player.Image);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            player = await _context.Players
                .Include(p => p.Position).FirstOrDefaultAsync(m => m.ID == PlayerModel.ID);

            _context.Attach(player).State = EntityState.Modified;

            try
            {
                if (NewImage != null && NewImage.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        NewImage.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        var resizedImage = ImageUtils.ResizeImage(fileBytes, 140, 190);
                        player.Image = resizedImage;
                    }
                }

                player.FirstName = PlayerModel.FirstName;
                player.LastName = PlayerModel.LastName;
                player.DOB = PlayerModel.DOB;
                player.Email = PlayerModel.Email;
                player.PositionId = PlayerModel.PositionId;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(PlayerModel.ID))
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
