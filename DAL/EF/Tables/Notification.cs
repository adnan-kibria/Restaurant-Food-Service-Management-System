using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Notification
{
    public int Id { get; set; }

    public string Message { get; set; } = null!;

    public int StatusId { get; set; }

    public DateTime SentAt { get; set; }

    public Guid UserId { get; set; }

    public virtual NotificationStatus Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
