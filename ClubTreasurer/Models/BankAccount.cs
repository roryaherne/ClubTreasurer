using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class BankAccount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string IBAN { get; set; }

        public string Name { get; set; }

        public Person AccountHolder { get; set; }
        public ICollection<BankTransaction> Transactions { get; set; }
    }
}
