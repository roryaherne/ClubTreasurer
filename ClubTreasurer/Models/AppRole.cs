using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class AppRole : IdentityRole
    {

        public AppRole() : base() { }

        public AppRole(string roleName) : base(roleName) { }

        public AppRole(string roleName, string description,
            DateTime lastModified)
            : base(roleName)
        {
            base.Name = roleName;

            Description = description;
            LastModified = lastModified;
        }

        public string Description { get; set; }

        public DateTime LastModified { get; set; }

        [ForeignKey("LastModifiedBy")]
        public string LastModifiedById { get; set; }

        //[ForeignKey("CreatedBy")]
        //public string CreatedById { get; set; }

        //public AppUser CreatedBy { get; set; }
        public AppUser LastModifiedBy { get; set; }

    }
}
