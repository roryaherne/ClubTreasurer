using ClubTreasurer.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ClubTreasurer.ViewModels
{
    public class BankAccountViewModel
    {
        public BankAccount BankAccount { get; set; }
        
        [Display(Name ="Account Owner")]
        public SelectList AccountOwnerSelectList { get; set; }
    }
}
