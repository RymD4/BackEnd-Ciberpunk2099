using System;
using System.Collections.Generic;

namespace BackEnd_Ciberpunk2099.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public float? Price { get; set; }

    public int? Category { get; set; }

    public virtual Category? CategoryNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
