using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using System;
using ClubTreasurer.Utilities;
using ClubTreasurer.Interfaces;
using Microsoft.Extensions.Configuration;

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

            ViewData["Duration"] = "2019";

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                var request = PageContext.HttpContext.Request;
                var baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                var url = $"{baseUrl}{request.Path.Value}{request.QueryString.Value}";

                var subject = "Gym Card";
                var message = "Print in colour and have it signed by Jeremie before laminating";

                await _emailSender.SendEmailAsync("rory.aherne@sos-kd.org", subject, message, null);

                //await PdfUtils.EmailUrlAsPdfAttachement(_emailSender, url, "rory.aherne@sos-kd.org");
                //await PdfUtils.EmailUrlAsPdfAttachement(_emailSender, url, Player.Email);
            }
            catch (Exception ex)
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
