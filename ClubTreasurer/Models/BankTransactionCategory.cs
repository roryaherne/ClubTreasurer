﻿using ClubTreasurer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class BankTransactionCategory : IAuditable
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<BankTransaction> Transactions { get; set; }

        #region Audit Props
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

        [ForeignKey("LastModifiedBy")]
        public string LastModifiedById { get; set; }

        //[ForeignKey("CreatedBy")]
        //public string CreatedById { get; set; }

        //public AppUser CreatedBy { get; set; }
        public AppUser LastModifiedBy { get; set; }

        #endregion
    }
}
