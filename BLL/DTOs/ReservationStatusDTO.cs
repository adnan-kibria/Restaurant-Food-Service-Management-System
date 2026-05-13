using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class ReservationStatusDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<ReservationDTO> Reservations { get; set; } = new List<ReservationDTO>();
    }
}
