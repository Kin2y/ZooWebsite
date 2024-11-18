using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class TicketBooking
{
    public int CustomerId { get; set; }

    public int TicketId { get; set; }

    public string DateBooked { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
