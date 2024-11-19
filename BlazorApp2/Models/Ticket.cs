﻿using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int AttractionId { get; set; }

    public int TicketbookingId { get; set; }

    public virtual Ticket Attraction { get; set; } = null!;

    public virtual Ticketbooking Ticketbooking { get; set; } = null!;
}
