using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Recommendation
{
    public int Id { get; set; }

    public int FoodId { get; set; }

    public int RecommendId { get; set; }

    public int CoOccurance { get; set; }

    public virtual Food Food { get; set; } = null!;

    public virtual Food Recommend { get; set; } = null!;
}
