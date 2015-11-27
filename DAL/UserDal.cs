﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LoginProject.Models;

namespace LoginProject.DAL
{
    public class UserDal: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("tblUser");
        }
        public DbSet<User> users { get; set; }
    }
}