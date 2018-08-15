using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Areas.Identity.Pages.Roles
{
    public class DetailsModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public DetailsModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        public AppRole AppRole { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppRole = await _context.AppRole
                .Include(a => a.LastModifiedBy).FirstOrDefaultAsync(m => m.Id == id);

            if (AppRole == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
