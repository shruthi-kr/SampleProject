using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LoginProject.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginProject.DAL
{
    public class UserDal: DbContext
    {
        public UserDal()
            : base("UserDal")
        {
            Database.SetInitializer<UserDal>(new UserDalInitializer<UserDal>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().ToTable("Users");
            //modelBuilder.Entity<Content>().ToTable("Contents");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
                modelBuilder.Entity<Content>().HasKey(u => u.Id);
 modelBuilder.Entity<Content>().Property(u => u.Id)
   .HasDatabaseGeneratedOption(
     DatabaseGeneratedOption.Identity);
        }

        public DbSet<User> users { get; set; }
        public DbSet<LoginProject.Models.Content> Contents { get; set; }

        
    }
}