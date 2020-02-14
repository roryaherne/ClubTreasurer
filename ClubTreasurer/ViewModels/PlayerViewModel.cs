using ClubTreasurer.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ClubTreasurer.ViewModels
{
    public class PlayerViewModel
    {
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                return string.IsNullOrWhiteSpace(Title) ? $"{FirstName} {LastName}" : $"{Title} {FirstName} {LastName}";
            }
        }

        [Display(Name = "Name")]
        public string FullNameReverse
        {
            get
            {
                return string.IsNullOrWhiteSpace(Title) ? $"{LastName} {FirstName}" : $"{Title} {LastName} {FirstName}";
            }
        }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Display(Name = "Position")]
        public int PositionId { get; set; }

        public string Base64Image { get; set; }
    }
}
