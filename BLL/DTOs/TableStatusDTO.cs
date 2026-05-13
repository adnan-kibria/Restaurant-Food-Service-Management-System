using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class TableStatusDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<TableDTO> Tables { get; set; } = new List<TableDTO>();
    }
}
