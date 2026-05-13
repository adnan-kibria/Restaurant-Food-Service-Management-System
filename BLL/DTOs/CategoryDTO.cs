using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<FoodDTO> Foods { get; set; } = new List<FoodDTO>();
    }
}
