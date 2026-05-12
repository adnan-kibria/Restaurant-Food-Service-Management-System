using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class WaiterDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public int AddressId { get; set; }

        public Guid UserId { get; set; }
    }
}
