using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Address
{
    public int Id { get; set; }

    public string AddressLine { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string City { get; set; } = null!;

    public virtual ICollection<Chef> Chefs { get; set; } = new List<Chef>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<DeliveryMan> DeliveryMen { get; set; } = new List<DeliveryMan>();

    public virtual ICollection<Manager> Managers { get; set; } = new List<Manager>();

    public virtual ICollection<Waiter> Waiters { get; set; } = new List<Waiter>();
}
