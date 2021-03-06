﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClubTreasurer.Models;
using ClubTreasurer.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClubTreasurer.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public DetailsModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Player Player { get; set; }
        public List<BankTransaction> BankTransactions { get; set; }
        public List<SelectListItem> MonthFromList { get; set; }
        public List<SelectListItem> MonthToList { get; set; }
        public List<SelectListItem> YearList { get; set; }

        [BindProperty]
        public string MonthTo { get; set; }
        [BindProperty]
        public string MonthFrom { get; set; }
        [BindProperty]
        public string Year { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Players
                .Include(p => p.Position)
                .Include(p => p.BankAccounts).ThenInclude(a => a.Transactions).ThenInclude(t => t.TransactionCategory)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Player == null)
            {
                return NotFound();
            }
            if (Player.Image != null)
                ViewData["ImageUrl"] = "data:image;base64," + Convert.ToBase64String(Player.Image);

            BankTransactions = Player.BankAccounts.SelectMany(a => a.Transactions).OrderByDescending(t => t.BookingDate).ToList();
            

            MonthFromList = MonthToList = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Jan", Value = "Jan"},
                new SelectListItem {Text = "Feb", Value = "Feb"},
                new SelectListItem {Text = "Mär", Value = "Mär"},
                new SelectListItem {Text = "Apr", Value = "Apr"},
                new SelectListItem {Text = "Mai", Value = "Mai"},
                new SelectListItem {Text = "Jun", Value = "Jun"},
                new SelectListItem {Text = "Jul", Value = "Jul"},
                new SelectListItem {Text = "Aug", Value = "Aug"},
                new SelectListItem {Text = "Sep", Value = "Sep"},
                new SelectListItem {Text = "Okt", Value = "Okt"},
                new SelectListItem {Text = "Nov", Value = "Nov"},
                new SelectListItem {Text = "Dez", Value = "Dez"}
            };

            var currentYear = DateTime.Now.Year.ToString();
            var nextYear = DateTime.Now.AddYears(1).Year.ToString();

            YearList = new List<SelectListItem>()
            {
                new SelectListItem {Text = currentYear, Value = currentYear},
                new SelectListItem {Text = nextYear, Value = nextYear},
            };

            return Page();
        }
    }
}
