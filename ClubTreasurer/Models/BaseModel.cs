using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubTreasurer.Models
{
    public abstract class BaseModelExy
    {
        public int ID { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

        [ForeignKey("LastModifiedBy")]
        public string LastModifiedById { get; set; }

        [ForeignKey("CreatedBy")]
        public string CreatedById { get; set; }

        public IdentityUser CreatedBy { get; set; }
        public IdentityUser LastModifiedBy { get; set; }
    }
}
