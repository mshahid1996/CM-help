using C.M_HelpLine.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace C.M_HelpLine.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("user")
        {

        }
        public DbSet<User> RegistTable { get; set; }
        public DbSet<UserComplain> ComplainTable { get; set; }

        public DbSet<Officer> Officers { get; set; }
    }
}