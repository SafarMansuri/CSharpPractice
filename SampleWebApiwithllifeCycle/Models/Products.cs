using System;
using System.Collections.Generic;

namespace SampleWebApiwithllifeCycle.Models;

public partial class Products
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();
}
