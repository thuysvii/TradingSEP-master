﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TradingVLU.Models
{
    public class USERMetadata
    {
        
        [Required(ErrorMessage = "Fullname must not be null")]
        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password must not be null")]
        [Display(Name = "Password")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{4,20}$", ErrorMessage = "Minimum four characters and maximun twenty characters, at least one uppercase letter, one lowercase letter and one number.")]
        [DataType(DataType.Password)]
        public string password { get; set; }


        [Required(ErrorMessage = "Password must not be null")]
        [Compare("password", ErrorMessage = "Password Mismatched. Re-enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [NotMapped]
        public string confirmpassword { get; set; }

        [Required(ErrorMessage = "Email must not be null")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Name must not be null")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please select a value")]
        [Range(1, 13)]
        [Display(Name = "Security Question")]
        public int id_security_question { get; set; }

        [Required(ErrorMessage = "Answer must not be null")]
        [Display(Name = "Answer")]
        public string answer_security_question { get; set; }

        
    }
}