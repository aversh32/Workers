using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Work.Models.Repository
{
  
        public class EFDbContext : DbContext
        {
            public DbSet<Worker> Workers { get; set; }
             public DbSet<Language> Language { get; set; }
    }
}