using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class IngredientStockStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}
