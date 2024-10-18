using BlazorApp2.Models;
using MudBlazor;
using BlazorApp2.Services;


namespace BlazorApp2.Services
{

    public class CustomerService
    {
        private readonly TlS2302172RzaContext _context;
        public CustomerService(TlS2302172RzaContext context)
        {
            _context = context;

        }
        public async Task AddCustomerAync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }
    }

}
