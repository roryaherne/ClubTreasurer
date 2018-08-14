using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class BankTransactionCategory : BaseModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<BankTransaction> Transactions { get; set; }
    }
}
