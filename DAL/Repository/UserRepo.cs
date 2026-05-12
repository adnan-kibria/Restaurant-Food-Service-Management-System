using DAL.EF;
using DAL.EF.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class UserRepo
    {
        RestaurantFoodServiceContext db;
        public UserRepo(RestaurantFoodServiceContext db)
        {
            this.db = db;
        }

        public User GetByEmail(string email)
        {
            return db.Users.SingleOrDefault(u => u.Email == email);
        }

        //public List<User> Get()
        //{
        //    return db.Users.Include("RoleId").SingleOrDefault(u => );
        //}

        public bool Add(string email, string password, int roleId, int statusId)
        {
            if(roleId == 0)
            {
                var data = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = email,
                    Password = password,
                    RoleId = 2,
                    StatusId = statusId
                };
                db.Users.Add(data);
                db.SaveChanges();
            }
            else
            {
                var data = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = email,
                    Password = password,
                    RoleId = roleId,
                    StatusId = statusId
                };
                db.Users.Add(data);
                db.SaveChanges();
            }
            return true;
        }

    }
}
