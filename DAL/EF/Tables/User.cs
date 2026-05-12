using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class User
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<Chef> Chefs { get; set; } = new List<Chef>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<DeliveryMan> DeliveryMen { get; set; } = new List<DeliveryMan>();

    public virtual ICollection<Manager> Managers { get; set; } = new List<Manager>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual Role Role { get; set; } = null!;

    public virtual UserStatus Status { get; set; } = null!;

    public virtual ICollection<Waiter> Waiters { get; set; } = new List<Waiter>();
}
