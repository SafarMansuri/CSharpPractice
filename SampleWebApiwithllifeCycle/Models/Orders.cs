using System;
using System.Collections.Generic;

namespace SampleWebApiwithllifeCycle.Models;

public partial class Orders
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime OrderedAt { get; set; }

    public virtual ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();

    public virtual Users User { get; set; } = null!;
}
