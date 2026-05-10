using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class FoodsIngredient
{
    public int Id { get; set; }

    public int FoodId { get; set; }

    public int IngredientId { get; set; }

    public virtual Food Food { get; set; } = null!;

    public virtual Ingredient Ingredient { get; set; } = null!;
}
