using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class BaseModel
    {
        public int ID { get; set; }
        public DateTime LastModified { get; set; }



        public IdentityUser LastModifiedBy { get; set; }
    }
}
