using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class WaiterRepo
    {
        RestaurantFoodServiceContext db;
        public WaiterRepo(RestaurantFoodServiceContext db)
        {
            this.db = db;
        }

        public bool Add(string name, string phone, int addressId, Guid userId)
        {
            var data = new Waiter()
            {
                Name = name,
                Phone = phone,
                AddressId = addressId,
                UserId = userId
            };

            db.Waiters.Add(data);
            return db.SaveChanges() > 0;
        }
    }
}
