using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int? UserId { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public DateOnly? VisitDate { get; set; }

    public int? Quantity { get; set; }

    public int AttractionId { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;

    public virtual ICollection<TicketBooking> TicketBookings { get; set; } = new List<TicketBooking>();
}
