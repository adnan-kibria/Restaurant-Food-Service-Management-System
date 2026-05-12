using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class DeliveryManRepo
    {
        RestaurantFoodServiceContext db;
        public DeliveryManRepo(RestaurantFoodServiceContext db)
        {
            this.db = db;
        }

        public bool Add(string name, string phone, int addressId, Guid userId)
        {
            var data = new DeliveryMan()
            {
                Name = name,
                Phone = phone,
                AddressId = addressId,
                UserId = userId
            };

            db.DeliveryMen.Add(data);
            return db.SaveChanges() > 0;
        }
    }
}
