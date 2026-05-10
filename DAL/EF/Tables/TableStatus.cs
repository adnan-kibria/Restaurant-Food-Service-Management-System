using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class TableStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
