using System;
using System.Collections.Generic;

namespace BackEnd_Ciberpunk2099.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Address { get; set; }

    public string? Lastname { get; set; }

    public string? Bussinessname { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
