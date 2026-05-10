using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Reservation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int Count { get; set; }

    public DateTime ReservedAt { get; set; }

    public int StatusId { get; set; }

    public int CustomerId { get; set; }

    public int TableId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ReservationStatus Status { get; set; } = null!;

    public virtual Table Table { get; set; } = null!;
}
