using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using Microsoft.AspNetCore.Authorization;

namespace ClubTreasurer.Areas.Identity.Pages.Roles
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public DeleteModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppRole = await _context.AppRole.FindAsync(id);

            if (AppRole != null)
            {
                _context.AppRole.Remove(AppRole);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
