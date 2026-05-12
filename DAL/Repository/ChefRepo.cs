using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class ChefRepo
    {
        RestaurantFoodServiceContext db;
        public ChefRepo(RestaurantFoodServiceContext db)
        {
            this.db = db;
        }

        public bool Add(string name, string phone, int addressId, Guid userId)
        {
            var data = new Chef()
            {
                Name = name,
                Phone = phone,
                AddressId = addressId,
                UserId = userId
            };

            db.Chefs.Add(data);
            return db.SaveChanges() > 0;
        }
    }
}
