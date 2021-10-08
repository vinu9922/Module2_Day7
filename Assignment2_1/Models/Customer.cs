using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Assignment2_1.Models
{
    public class Customer
    {
        //[Required(ErrorMessage = "Cannot be Blank")]
        public int CustomerId { get; set; }
        
        [Required(ErrorMessage ="Enter Name")]
        [StringLength(15, ErrorMessage ="Name should be less than 15")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter Email")]
        public string Email { get; set; }

        [Required (ErrorMessage ="Enter City")]
        public string City { get; set; }

        //[Required (ErrorMessage ="Enter Phone no")]
        //[MaxLength(10,ErrorMessage ="Enter 10 digit")]
        public int Phone_No { get; set; }
    }
}
