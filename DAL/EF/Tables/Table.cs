using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Table
{
    public int Id { get; set; }

    public int Capacity { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual TableStatus Status { get; set; } = null!;
}
