using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LoginProject.Models;

namespace LoginProject.DAL
{
    public class UserDalInitializer<T> : DropCreateDatabaseIfModelChanges<UserDal>
    {
        protected override void Seed(UserDal context)
        {
            var users = new List<User>
            {
            new User{FirstName="shruthi",LastName="Reddy",UserName="Shruthi",Password="admin"},
            new User{FirstName="admin",LastName="Reddy",UserName="Admin",Password="admin"}
            
            };

            users.ForEach(c => context.users.Add(c));
            context.SaveChanges();

        }
    }
}