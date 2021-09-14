using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ImageDemo.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        
        [Required]
        public string StudentName { get; set; }
        [StringLength(maximumLength:10,ErrorMessage ="Phone number should be of 10 digits",MinimumLength =10)]
        public string PhNo { get; set; }

        [Required(ErrorMessage ="Please Enter Email Address")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email ID")]
        public string EmailAddress { get; set; }

        [Range(21,100,ErrorMessage ="Age should be between 21 and 100")]
        public int Age { get; set; }

        [Display(Name ="Date of Joining")]
        [DataType(DataType.Date)]
        public DateTime Doj { get; set; }
    }
}
