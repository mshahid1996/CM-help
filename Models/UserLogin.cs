﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace C.M_HelpLine.Models
{
    public class UserLogin
    {
        [Key]
        public int id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}