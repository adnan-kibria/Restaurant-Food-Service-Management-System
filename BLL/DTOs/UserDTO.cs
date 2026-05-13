using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int RoleId { get; set; }

        public int StatusId { get; set; }

        public virtual ICollection<AuditLogDTO> AuditLogs { get; set; } = new List<AuditLogDTO>();

        public virtual ICollection<BillDTO> Bills { get; set; } = new List<BillDTO>();

        public virtual ICollection<ChefDTO> Chefs { get; set; } = new List<ChefDTO>();

        public virtual ICollection<CustomerDTO> Customers { get; set; } = new List<CustomerDTO>();

        public virtual ICollection<DeliveryManDTO> DeliveryMen { get; set; } = new List<DeliveryManDTO>();

        public virtual ICollection<ManagerDTO> Managers { get; set; } = new List<ManagerDTO>();

        public virtual ICollection<NotificationDTO> Notifications { get; set; } = new List<NotificationDTO>();

        public virtual RoleDTO Role { get; set; } = null!;

        public virtual UserStatusDTO Status { get; set; } = null!;

        public virtual ICollection<WaiterDTO> Waiters { get; set; } = new List<WaiterDTO>(); 
    }
}
