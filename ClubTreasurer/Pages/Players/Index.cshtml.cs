using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;

namespace ClubTreasurer.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public IndexModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        public IList<Player> Players { get;set; }

        public async Task OnGetAsync()
        {
            Players = await _context.Players
                .Include(p => p.Position)
                .OrderBy(p => p.LastName)
                .ToListAsync();
        }
    }
}
