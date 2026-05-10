using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Bill
{
    public int Id { get; set; }

    public double SubTotal { get; set; }

    public double Tax { get; set; }

    public double GrandTotal { get; set; }

    public int PaymentMethodId { get; set; }

    public int PaymentStatusId { get; set; }

    public DateTime IssuedAt { get; set; }

    public int OrderId { get; set; }

    public Guid GeneratedBy { get; set; }

    public virtual User GeneratedByNavigation { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
