﻿using ClubTreasurer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubTreasurer.Models
{
    public class BankAccount : IAuditable
    {
        [Display(Name="IBAN")]
        public string ID { get; set; }

        public string Name { get; set; }

        [ForeignKey("Person")]
        public int? PersonId { get; set; }
        [Display(Name ="Account Holder")]
        public Person Person { get; set; }

        public ICollection<BankTransaction> Transactions { get; set; }

        #region Audit Props
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

        [ForeignKey("LastModifiedBy")]
        public string LastModifiedById { get; set; }

        public AppUser LastModifiedBy { get; set; }

        #endregion
    }
}
