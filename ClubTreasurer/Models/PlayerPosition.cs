﻿using ClubTreasurer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubTreasurer.Models
{
    public class PlayerPosition : IAuditable
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }

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
