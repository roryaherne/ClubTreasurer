﻿using ClubTreasurer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubTreasurer.Models
{
    public class BankAccount : IAuditable
    {
        public int ID { get; set; }

        [Required]
        public string IBAN { get; set; }

        public string Name { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

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
