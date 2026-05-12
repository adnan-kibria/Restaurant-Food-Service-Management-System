using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class CustomerRepo
    {
        RestaurantFoodServiceContext db;
        public CustomerRepo(RestaurantFoodServiceContext db)
        {
            this.db = db;
        }

        public bool Add(string name, string phone, int addressId, Guid userId)
        {
            var data = new Customer()
            {
                Name = name,
                Phone = phone,
                AddressId = addressId,
                UserId = userId
            };

            db.Customers.Add(data);
            return db.SaveChanges() > 0;
        }
    }
}
