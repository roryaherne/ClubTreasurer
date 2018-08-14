using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class BankTransaction : BaseModel
    {
        [Required]
        public decimal Amount { get; set; }

        public string Reference { get; set; }

        [ForeignKey("TransactionCategory")]
        public int TransactionCategoryId { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }

        public BankTransactionCategory TransactionCategory { get; set; }
        public BankAccount Account { get; set; }

    }
}
