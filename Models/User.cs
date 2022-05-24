using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C.M_HelpLine.Models
{
    public class User
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Adhar { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Comfirm { get; set; }
        public string Gender { get; set; }
    }
}