using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Services
{
    public class AttractionService
    {
        private readonly TlS2302172RzaContext _context;
        public AttractionService(TlS2302172RzaContext context)
        {
            _context = context;
        }
        public async Task<List<Ticket>> GetAttractionAsync()
        {
            return await _context.Attractions.ToListAsync();    
        }
    }
}