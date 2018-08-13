using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class BankTransaction
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public string Reference { get; set; }

        public BankTransactionCategory Category { get; set; }
        public BankAccount Account { get; set; }

    }
}
