using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityBegi.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please provie Id")]
        public int id { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage = "Name must be Less than ( Char")]
        public string Name { get; set; }
        [Required]
        public string Dob { get; set; }
    }
}