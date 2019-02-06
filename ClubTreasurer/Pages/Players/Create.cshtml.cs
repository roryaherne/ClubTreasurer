using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClubTreasurer.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubTreasurer.Pages.Players
{
    public class CreateModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public CreateModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PositionId"] = new SelectList(_context.Set<PlayerPosition>(), "ID", "Name");
            ViewData["BankAccount"] = new SelectList(_context.Set<BankAccount>(), "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Player Player { get; set; }

        [BindProperty]
        public int NewBankAccount { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(NewBankAccount > 0)
            {
                var account = await _context.BankAccounts.FirstOrDefaultAsync(a => a.ID == NewBankAccount);
                Player.BankAccounts.Add(account);
            }
                
            _context.Players.Add(Player);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}