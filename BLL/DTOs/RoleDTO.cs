using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class RoleDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<UserDTO> Users { get; set; } = new List<UserDTO>();
    }
}
