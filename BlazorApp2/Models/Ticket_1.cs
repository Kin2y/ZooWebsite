using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class Ticket
{
    public int AttractionId { get; set; }

    public string? Name { get; set; }

    public float? Price { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
