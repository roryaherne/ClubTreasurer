using ClubTreasurer.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubTreasurer.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser() : base() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        //[InverseProperty("CreatedBy")]
        //public List<IAuditable> CreatedEntities { get; set; }

        //[InverseProperty("LastModifiedBy")]
        //public List<IAuditable> ModifiedEntities { get; set; }
    }
}