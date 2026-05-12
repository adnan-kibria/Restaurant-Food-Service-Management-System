using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class RoleRepo
    {
        RestaurantFoodServiceContext db;
        public RoleRepo(RestaurantFoodServiceContext db)
        {
            this.db = db;
        }

        public List<Role> Get()
        {
            return db.Roles.ToList();
        }

        public Role GetById(int id)
        {
            return db.Roles.Find(id);
        }
    }
}
