using BlazorApp2.Models;
using MudBlazor;
using BlazorApp2.Services;
using Microsoft.EntityFrameworkCore;


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
        public async Task<Customer?> LogIn(Customer customer)
        {
            return await _context.Customers.FirstOrDefaultAsync(
                c => c.Username == customer.Username && c.Password == customer.Password);
        }
    }

}
