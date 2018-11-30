using ClubTreasurer.Models;
using System;

namespace ClubTreasurer.Interfaces
{
    public interface IAuditable
    {
        DateTime Created { get; set; }
        DateTime LastModified { get; set; }
        string LastModifiedById { get; set; }
        AppUser LastModifiedBy { get; set; }
    }
}