using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Ingredient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Quantity { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<FoodsIngredient> FoodsIngredients { get; set; } = new List<FoodsIngredient>();

    public virtual IngredientStockStatus Status { get; set; } = null!;
}
