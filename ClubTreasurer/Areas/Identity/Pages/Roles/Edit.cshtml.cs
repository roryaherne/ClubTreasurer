using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using Microsoft.AspNetCore.Authorization;

namespace ClubTreasurer.Areas.Identity.Pages.Roles
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public EditModel(ClubTreasurer.Models.ClubTreasurerContext context)
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
           ViewData["LastModifiedById"] = new SelectList(_context.AppUsers, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AppRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppRoleExists(AppRole.Id))
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

        private bool AppRoleExists(string id)
        {
            return _context.AppRole.Any(e => e.Id == id);
        }
    }
}
