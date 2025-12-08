using System;
using System.Collections.Generic;

namespace SampleWebApiwithllifeCycle.Models;

public partial class OrderItems
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Orders Order { get; set; } = null!;

    public virtual Products Product { get; set; } = null!;
}
