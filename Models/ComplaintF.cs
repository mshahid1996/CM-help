using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace C.M_HelpLine.Models
{
    public class ComplaintF
    {
        [Key]
        public string status { get; set; }
        public string Comment { get; set; }
    }
}