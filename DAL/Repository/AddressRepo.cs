using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class AddressRepo
    {
        RestaurantFoodServiceContext db;
        public AddressRepo(RestaurantFoodServiceContext db)
        {
            this.db = db;
        }

        public bool Add(string address_line, string area, string city)
        {
            var data = new Address()
            {
                AddressLine = address_line,
                Area = area,
                City = city
            };

            db.Addresses.Add(data);
            return db.SaveChanges() > 0;
        }

        public int GetByAddressLine(string address_line) {
            return db.Addresses.Where(a => a.AddressLine == address_line).Select(a => a.Id).SingleOrDefault();
        }
    }
}
