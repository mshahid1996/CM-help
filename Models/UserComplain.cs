using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C.M_HelpLine.Models
{
    public class UserComplain
    {
        public int id { get; set; }
        public string number { get; set; }
        public string area { get; set; }
        public string category { get; set; }
        public string details { get; set; }
    }
}