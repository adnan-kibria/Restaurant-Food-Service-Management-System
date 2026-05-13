using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class FoodsIngredientDTO
    {
        public int Id { get; set; }

        public int FoodId { get; set; }

        public int IngredientId { get; set; }

        public virtual FoodDTO Food { get; set; } = null!;

        public virtual IngredientDTO Ingredient { get; set; } = null!;
    }
}
