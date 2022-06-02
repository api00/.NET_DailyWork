using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Details
    {

       [Required(ErrorMessage ="Please enter your Email")]
        public String email { get; set; }
        [Required(ErrorMessage ="Please enter your password")]
        public int password { get; set; }

    }
}