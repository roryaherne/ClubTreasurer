using ClubTreasurer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Interfaces
{
    public interface IAuditable
    {
        DateTime Created { get; set; }
        DateTime LastModified { get; set; }

        //string CreatedById { get; set; }
        string LastModifiedById { get; set; }

        //AppUser CreatedBy { get; set; }
        AppUser LastModifiedBy { get; set; }
    }
}