using ClubTreasurer.Models;
using ClubTreasurer.Utilities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Pages.Transactions
{
    public class IndexModel : PageModel
    {
        private readonly ClubTreasurerContext _context;

        public IndexModel(ClubTreasurerContext context)
        {
            _context = context;
        }

        public string CurrentFilter { get; set; }
        public string ReferenceSort { get; set; }
        public string DateSort { get; set; }
        public string CategorySort { get; set; }
        public string NameSort { get; set; }
        public string CurrentSort { get; set; }


        public PaginatedList<BankTransaction> BankTransactions { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            ReferenceSort = string.IsNullOrEmpty(sortOrder) ? "ref_desc" : "";
            DateSort = sortOrder == "date" ? "date_desc" : "date";
            CategorySort = sortOrder == "category" ? "category_desc" : "category";
            NameSort = sortOrder == "name" ? "name_desc" : "name";

            if (searchString != null)
                pageIndex = 1;
            else
                searchString = currentFilter;

            CurrentFilter = searchString;

            IQueryable<BankTransaction> transactions = _context.BankTransactions
                .Include(b => b.Account)
                .Include(b => b.LastModifiedBy)
                .Include(b => b.TransactionCategory);

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                transactions = transactions.Where(t => t.Reference.Contains(searchString, StringComparison.OrdinalIgnoreCase) 
                || t.Account.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase) 
                || t.TransactionCategory.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase));
            }

            switch (sortOrder)
            {
                case "date":
                    transactions = transactions.OrderBy(c => c.BookingDate);
                    break;
                case "date_desc":
                    transactions = transactions.OrderByDescending(c => c.BookingDate);
                    break;
                case "ref":
                    transactions = transactions.OrderBy(c => c.Reference);
                    break;
                case "ref_desc":
                    transactions = transactions.OrderByDescending(c => c.Reference);
                    break;
                case "category":
                    transactions = transactions.OrderBy(c => c.TransactionCategory.Name);
                    break;
                case "category_desc":
                    transactions = transactions.OrderByDescending(c => c.TransactionCategory.Name);
                    break;
                case "name":
                    transactions = transactions.OrderBy(c => c.Account.Name);
                    break;
                case "name_desc":
                    transactions = transactions.OrderByDescending(c => c.Account.Name);
                    break;
                default:
                    transactions = transactions.OrderByDescending(c => c.BookingDate);
                    break;
            }

            int pageSize = 15;
            BankTransactions = await PaginatedList<BankTransaction>.CreateAsync(transactions.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
