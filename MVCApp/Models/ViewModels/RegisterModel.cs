using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string Login { get; set; }


        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords are not the same!!!")]
        public string PasswordConfirm { get; set; }


        //[Required]       
        //public DateTime LastVisit { get; set; }


        //[Required]
        //public string SkinColor { get; set; }
    }
}