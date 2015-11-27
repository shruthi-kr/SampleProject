using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LoginProject.Models
{
    public class User
    {
        [Key]
       [Required(ErrorMessage="Please enter more than 5 characters")]
        [Display(Name="User First Name")]
       public string Username { get; set; }

        
        [Required(ErrorMessage = "Please enter more than 5 characters for password")]
        public string Password { get; set; }

      
    }
}