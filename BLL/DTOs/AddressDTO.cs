using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class AddressDTO
    {
        public int Id { get; set; }

        public string AddressLine { get; set; } = null!;

        public string Area { get; set; } = null!;

        public string City { get; set; } = null!;

        public virtual ICollection<ChefDTO> Chefs { get; set; } = new List<ChefDTO>();

        public virtual ICollection<CustomerDTO> Customers { get; set; } = new List<CustomerDTO>();

        public virtual ICollection<DeliveryManDTO> DeliveryMen { get; set; } = new List<DeliveryManDTO>();

        public virtual ICollection<ManagerDTO> Managers { get; set; } = new List<ManagerDTO>();

        public virtual ICollection<WaiterDTO> Waiters { get; set; } = new List<WaiterDTO>();
    }
}
