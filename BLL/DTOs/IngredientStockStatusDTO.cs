using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class IngredientStockStatusDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<IngredientDTO> Ingredients { get; set; } = new List<IngredientDTO>();
    }
}
