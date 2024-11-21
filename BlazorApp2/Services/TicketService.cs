using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorApp2.Services
{
    public class TicketService
    {
        private readonly TlS2302172RzaContext _context;
        public TicketService(TlS2302172RzaContext context)
        {
            _context = context;
        }
        public async Task<List<Ticket>> GetTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }
        public async Task AddTicketAsync(Ticket newTicket)
        {
            await _context.Tickets.AddAsync(newTicket);
            await _context.SaveChangesAsync();
        }

    }
}


