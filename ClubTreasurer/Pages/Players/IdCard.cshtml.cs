using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using System;
using ClubTreasurer.Interfaces;
using Microsoft.Extensions.Configuration;
using ClubTreasurer.ViewModels;
using System.Linq;
using ClubTreasurer.Utilities;

namespace ClubTreasurer.Pages.Players
{
    public class IdCardModel : PageModel
    {
        private readonly ClubTreasurerContext _context;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _configuration;

        public IdCardModel(ClubTreasurerContext context, IEmailSender emailSender, IConfiguration config)
        {
            _context = context;
            _emailSender = emailSender;
            _configuration = config;
        }
        public IdCardViewModel IdCard { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, string monthFrom, string monthTo)
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
                FeesPaidUntil = $"{monthFrom} - {monthTo} {DateTime.Now.Year}",
                Player = player
            };
            if (player.Image != null)
                IdCard.ImageUrl = "data:image;base64," + Convert.ToBase64String(player.Image);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            try
            {
                var request = PageContext.HttpContext.Request;
                var baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
                var url = $"{baseUrl}{request.Path.Value}{request.QueryString.Value}";

                var player = await _context.Players.FirstOrDefaultAsync(m => m.ID == id);

                await PdfUtils.CreatePdfFrumUrl(url, player.FullNameReverse);
                //await PdfUtils.EmailUrlAsPdfAttachement(_emailSender, url, player.Email);
            }
            catch (Exception)
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
