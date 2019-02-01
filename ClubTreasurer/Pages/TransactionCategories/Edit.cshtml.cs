using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.TransactionCategories
{
    public class EditModel : PageModel
    {
        private readonly ClubTreasurer.Models.ClubTreasurerContext _context;

        public EditModel(ClubTreasurer.Models.ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BankTransactionCategory BankTransactionCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BankTransactionCategory = await _context.BankTransactionCategorys
                .Include(b => b.LastModifiedBy).FirstOrDefaultAsync(m => m.ID == id);

            if (BankTransactionCategory == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BankTransactionCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankTransactionCategoryExists(BankTransactionCategory.ID))
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

        private bool BankTransactionCategoryExists(int id)
        {
            return _context.BankTransactionCategorys.Any(e => e.ID == id);
        }
    }
}
