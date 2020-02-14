using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using System;
using ClubTreasurer.ViewModels;
using Microsoft.Extensions.Options;

namespace ClubTreasurer.Pages.Players
{
    public class IdCardModel : PageModel
    {
        private readonly ClubTreasurerContext _context;
        private readonly IOptions<RCIConfig> _rciConfig;

        public IdCardModel(ClubTreasurerContext context, IOptions<RCIConfig> rciConfig)
        {
            _context = context;
            _rciConfig = rciConfig;
        }
        public IdCardViewModel IdCard { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, string monthFrom, string monthTo, string year)
        {
            var player = await _context.Players
                .Include(p => p.Position)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (player == null)
            {
                return NotFound();
            }

            IdCard = new IdCardViewModel
            {
                FeesPaidUntil = $"{monthFrom} - {monthTo} {year}",
                Player = player,
                BackgroundColor = _rciConfig.Value.IdCardColor
            };
            if (player.Image != null)
                IdCard.ImageUrl = "data:image;base64," + Convert.ToBase64String(player.Image);

            return Page();
        }
    }
}
