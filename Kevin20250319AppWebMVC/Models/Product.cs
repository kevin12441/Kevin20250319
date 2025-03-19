using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kevin20250319AppWebMVC.Models;

public partial class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }
    [Required(ErrorMessage = "El precio es obligatorio.")]
    public decimal Price { get; set; }

    public int? CategoryId { get; set; }

    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Category? Category { get; set; }
}
