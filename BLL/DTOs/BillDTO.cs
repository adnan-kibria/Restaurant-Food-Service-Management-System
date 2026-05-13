using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class BillDTO
    {
        public int Id { get; set; }

        public double SubTotal { get; set; }

        public double Tax { get; set; }

        public double GrandTotal { get; set; }

        public int PaymentMethodId { get; set; }

        public int PaymentStatusId { get; set; }

        public DateTime IssuedAt { get; set; }

        public int OrderId { get; set; }

        public Guid GeneratedBy { get; set; }

        public virtual UserDTO GeneratedByNavigation { get; set; } = null!;

        public virtual OrderDTO Order { get; set; } = null!;
    }
}
