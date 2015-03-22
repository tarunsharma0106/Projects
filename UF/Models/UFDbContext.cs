using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UF.Models
{
    public class UFDbContext : DbContext
    {   

   public UFDbContext():base("UFDbContext"){}
        public DbSet<Gator> Gators { get; set; }

        public DbSet<Test> Tests { get; set; }
    }
}