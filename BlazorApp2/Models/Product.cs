using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string Productname { get; set; } = null!;

    public float Price { get; set; }

    public int Stock { get; set; }
}
