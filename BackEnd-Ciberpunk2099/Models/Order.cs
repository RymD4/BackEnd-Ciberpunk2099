using System;
using System.Collections.Generic;

namespace BackEnd_Ciberpunk2099.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? Price { get; set; }

    public string? UserId { get; set; }

    public int? SupplierId { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Supplier? Supplier { get; set; }

    public virtual Usuario? User { get; set; }
}
