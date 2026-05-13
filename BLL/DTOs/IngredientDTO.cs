using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class IngredientDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Quantity { get; set; }

        public int StatusId { get; set; }

        public virtual ICollection<FoodsIngredientDTO> FoodsIngredients { get; set; } = new List<FoodsIngredientDTO>();

        public virtual IngredientStockStatusDTO Status { get; set; } = null!;
    }
}
