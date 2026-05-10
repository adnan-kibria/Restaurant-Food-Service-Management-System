using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class AuditLog
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;

    public string Entity { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public DateTime PerformedAt { get; set; }

    public Guid UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
