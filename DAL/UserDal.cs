using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LoginProject.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

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
        }
        public DbSet<User> users { get; set; }
        public DbSet<Content> contents { get; set; }

        
    }
}