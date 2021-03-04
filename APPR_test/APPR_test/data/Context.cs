using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPR_test.models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;    

namespace APPR_test.data
{
    public class Context : DbContext
    {
        public Context() : base("Context")
        {
        }

        public DbSet<Class> classes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
