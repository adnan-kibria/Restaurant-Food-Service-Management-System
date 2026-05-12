using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class UserStatusRepo
    {
        RestaurantFoodServiceContext db;
        public UserStatusRepo(RestaurantFoodServiceContext db)
        {
            this.db = db;
        }

        public UserStatus Get(int id)
        {
            return db.UserStatuses.Find(id);
        }
    }
}
