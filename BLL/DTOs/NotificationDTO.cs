using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class NotificationDTO
    {
        public int Id { get; set; }

        public string Message { get; set; } = null!;

        public int StatusId { get; set; }

        public DateTime SentAt { get; set; }

        public Guid UserId { get; set; }

        public virtual NotificationStatusDTO Status { get; set; } = null!;

        public virtual UserDTO User { get; set; } = null!;
    }
}
