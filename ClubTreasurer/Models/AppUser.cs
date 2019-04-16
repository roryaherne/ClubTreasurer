using Microsoft.AspNetCore.Identity;

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
    }
}