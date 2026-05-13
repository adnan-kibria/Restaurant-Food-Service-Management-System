using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class AuditLogDTO
    {
        public int Id { get; set; }

        public string Action { get; set; } = null!;

        public string Entity { get; set; } = null!;

        public string EntityId { get; set; } = null!;

        public DateTime PerformedAt { get; set; }

        public Guid UserId { get; set; }

        public virtual UserDTO User { get; set; } = null!;
    }
}
