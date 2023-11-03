using System;
using System.Collections.Generic;

namespace BackEnd_Ciberpunk2099.Models;

public partial class Usuario
{
    public string Id { get; set; } = null!;

    public string? Password { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
