using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class OrderDetailDTO
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public int OrderId { get; set; }

        public int FoodId { get; set; }

        public virtual FoodDTO Food { get; set; } = null!;

        public virtual OrderDTO Order { get; set; } = null!;
    }
}
