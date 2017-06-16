using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eLoaner.Models
{
    public class Checkout
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Asset")]
        public int AssetID { get; set; }
        [Display(Name = "Customer")]
        public int CustomerID { get; set; }
        //if its a date - the type is DateTime
        [Display(Name = "Check-Out Date")]
        public DateTime CheckOutDate { get; set; }
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Check-In Date")]
        public DateTime? CheckInDate { get; set; }
        [Display(Name = "Checked-Out By")]
        //Checked out by a person - string
        public string CheckedOutBy { get; set; }
        [Display(Name = "Checked-In By")]
        public string CheckInBy { get; set; }
        [Display(Name = "Date Last Modified")]
        public DateTime LastModifiedOn { get; internal set; }
        [Display(Name = "Last Modified By")]
        public string LastModifiedBy { get; internal set; }
        [Display(Name = "Has Been Checked-In")]
        public bool IsDeleted { get; internal set; }
    }
}