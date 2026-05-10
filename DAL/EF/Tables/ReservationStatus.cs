using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class ReservationStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
