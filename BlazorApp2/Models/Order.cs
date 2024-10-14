using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class Order
{
    public int Orderid { get; set; }

    public int Customerid { get; set; }

    public int Productid { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? Date { get; set; }
}
