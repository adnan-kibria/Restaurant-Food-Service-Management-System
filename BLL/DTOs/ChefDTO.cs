using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class ChefDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public int AddressId { get; set; }

        public Guid UserId { get; set; }

        public virtual AddressDTO Address { get; set; } = null!;

        public virtual UserDTO User { get; set; } = null!;
    }
}
