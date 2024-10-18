using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class Zooticket
{
    public int TicketId { get; set; }

    public int? UserId { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public DateOnly? VisitDate { get; set; }

    public int? Quantity { get; set; }
}
