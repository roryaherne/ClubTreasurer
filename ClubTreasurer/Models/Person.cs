using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class Person
    {
        public int ID { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [DataType(DataType.Custom)]
        public BankAccount BankAccount { get; set; }
    }
}
