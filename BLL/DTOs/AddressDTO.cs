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
    }
}
