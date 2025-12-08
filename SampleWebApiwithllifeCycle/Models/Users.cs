using System;
using System.Collections.Generic;

namespace SampleWebApiwithllifeCycle.Models;

public partial class Users
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string? DisplayName { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Orders> Orders { get; set; } = new List<Orders>();

    public virtual ICollection<Roles> Role { get; set; } = new List<Roles>();
}
