using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.Models
{
    public class Customer
    {
        //ID
        //FirstName
        //LastName
        //Contact Info
        //IsPleasant
        [Key]
        public int CustomerID { get; set; }


        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }


        [Required]
        [Display(Name = "Contact")]
        public string ContactInfo { get; set; }


        [Required]
        [Display(Name = "Cool")]
        public bool IsPlesant { get; set; }
        
        

    }
}

    


