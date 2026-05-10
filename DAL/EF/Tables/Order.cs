using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Order
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

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Customer Customer { get; set; } = null!;

    public virtual DeliveryMan DeliveryMan { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual OrderStatus OrderStatus { get; set; } = null!;

    public virtual Table? Table { get; set; }

    public virtual Waiter? Waiter { get; set; }
}
