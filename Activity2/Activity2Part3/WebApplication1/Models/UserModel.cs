﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Activity2Part3.Models
{
    public class UserModel
    {
        [Required]
        [Display(Name = "Username")]
        [StringLength(20, MinimumLength = 4)]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(20, MinimumLength = 4)]
        public string Password { get; set; }
    }
}