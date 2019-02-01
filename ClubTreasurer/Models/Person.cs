using ClubTreasurer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubTreasurer.Models
{
    public class Person : IAuditable
    {
        public int ID { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName { get { return $"{Title} {FirstName} {LastName}"; } }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public ICollection<BankAccount> BankAccounts { get; set; }

        #region Audit Props
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

        [ForeignKey("LastModifiedBy")]
        public string LastModifiedById { get; set; }
        public AppUser LastModifiedBy { get; set; }

        #endregion
    }
}
