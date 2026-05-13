using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class ReservationDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public int Count { get; set; }

        public DateTime ReservedAt { get; set; }

        public int StatusId { get; set; }

        public int CustomerId { get; set; }

        public int TableId { get; set; }

        public virtual CustomerDTO Customer { get; set; } = null!;

        public virtual ReservationStatusDTO Status { get; set; } = null!;

        public virtual TableDTO Table { get; set; } = null!;
    }
}
