using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class FoodDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public int AvailableQuantity { get; set; }

        public int CategoryId { get; set; }

        public virtual CategoryDTO Category { get; set; } = null!;

        public virtual ICollection<FoodsIngredientDTO> FoodsIngredients { get; set; } = new List<FoodsIngredientDTO>();

        public virtual ICollection<OrderDetailDTO> OrderDetails { get; set; } = new List<OrderDetailDTO>();

        public virtual ICollection<RecommendationDTO> RecommendationFoods { get; set; } = new List<RecommendationDTO>();

        public virtual ICollection<RecommendationDTO> RecommendationRecommends { get; set; } = new List<RecommendationDTO>();
    }
}
