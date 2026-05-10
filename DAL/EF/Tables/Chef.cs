using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Chef
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int AddressId { get; set; }

    public Guid UserId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
