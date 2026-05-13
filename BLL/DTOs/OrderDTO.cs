using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public int TotalFoodItems { get; set; }

        public double TotalPrice { get; set; }

        public DateTime DateOfOrder { get; set; }

        public double ShippingCharge { get; set; }

        public string CancelledBy { get; set; } = null!;

        public DateTime CancelledAt { get; set; }

        public DateTime DeliveredAt { get; set; }

        public int CustomerId { get; set; }

        public int OrderStatusId { get; set; }

        public int DeliveryManId { get; set; }

        public int? TableId { get; set; }

        public int? WaiterId { get; set; }

        public virtual ICollection<BillDTO> Bills { get; set; } = new List<BillDTO>();

        public virtual CustomerDTO Customer { get; set; } = null!;

        public virtual DeliveryManDTO DeliveryMan { get; set; } = null!;

        public virtual ICollection<OrderDetailDTO> OrderDetails { get; set; } = new List<OrderDetailDTO>();

        public virtual OrderStatusDTO OrderStatus { get; set; } = null!;

        public virtual TableDTO? Table { get; set; }

        public virtual WaiterDTO? Waiter { get; set; }
    }
}
