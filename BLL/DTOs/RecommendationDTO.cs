using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class RecommendationDTO
    {
        public int Id { get; set; }

        public int FoodId { get; set; }

        public int RecommendId { get; set; }

        public int CoOccurance { get; set; }

        public virtual FoodDTO Food { get; set; } = null!;

        public virtual FoodDTO Recommend { get; set; } = null!;
    }
}
