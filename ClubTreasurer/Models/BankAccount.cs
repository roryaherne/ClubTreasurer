using Microsoft.AspNetCore.Identity;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string IBAN { get; set; }

        public string Name { get; set; }

        [ForeignKey("AccountHolder")]
        public int AccountHolderId { get; set; }

        public Person AccountHolder { get; set; }
        public ICollection<BankTransaction> Transactions { get; set; }

        public DateTime LastModified { get; set; }
        public IdentityUser LastModifiedBy { get; set; }
    }
}
