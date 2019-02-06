using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.BankAccounts
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
        ViewData["LastModifiedById"] = new SelectList(_context.AppUsers, "Id", "Id");
        ViewData["PersonId"] = new SelectList(_context.Persons, "ID", "Discriminator");
            return Page();
        }

        [BindProperty]
        public BankAccount BankAccount { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BankAccounts.Add(BankAccount);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}