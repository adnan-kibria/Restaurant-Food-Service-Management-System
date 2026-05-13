using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class TableDTO
    {
        public int Id { get; set; }

        public int Capacity { get; set; }

        public int StatusId { get; set; }

        public virtual ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();

        public virtual ICollection<ReservationDTO> Reservations { get; set; } = new List<ReservationDTO>();

        public virtual TableStatusDTO Status { get; set; } = null!;
    }
}
