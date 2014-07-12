using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Sterling.IS.Utilities.ServiceAgent.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sterling.IS.Utilities.ServiceAgent.Manager
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public DbSet<MenuItem> Menu {get; set;}
        public DbSet<Utility> Utilities { get; set; }
       // public DbSet<ApplicationOwner> OwnerMapper { get; set; }
        public DbSet<Application> Apps { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Section> Sections { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove(new OneToManyCascadeDeleteConvention());
           // modelBuilder.Entity<ApplicationOwner>().HasKey(ti=> new { ti.ApplicationID, ti.OwnerId});
            modelBuilder.Entity<Application>().HasMany(t => t.Owners).WithMany(t => t.Applications);
          //  modelBuilder.Entity<Owner>().HasMany(t => t.Applications).WithMany();
        }
        
    }
}
