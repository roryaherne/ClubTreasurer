using ClubTreasurer.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubTreasurer.Models
{
    public class BankTransaction : IAuditable
    {
        public string ID { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public string Reference { get; set; }

        public string ReferenceNumber { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BookingDate { get; set; }

        [ForeignKey("TransactionCategory")]
        [Display(Name = "Category")]
        public int TransactionCategoryId { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }

        [Display(Name = "Category")]
        public BankTransactionCategory TransactionCategory { get; set; }
        public BankAccount Account { get; set; }

        #region Audit Props
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

        [ForeignKey("LastModifiedBy")]
        public string LastModifiedById { get; set; }
        public AppUser LastModifiedBy { get; set; }

        #endregion
    }
}
