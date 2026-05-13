using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class NotificationStatusDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<NotificationDTO> Notifications { get; set; } = new List<NotificationDTO>();
    }
}
