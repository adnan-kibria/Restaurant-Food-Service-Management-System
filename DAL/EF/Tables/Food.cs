using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Food
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public int AvailableQuantity { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<FoodsIngredient> FoodsIngredients { get; set; } = new List<FoodsIngredient>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Recommendation> RecommendationFoods { get; set; } = new List<Recommendation>();

    public virtual ICollection<Recommendation> RecommendationRecommends { get; set; } = new List<Recommendation>();
}
