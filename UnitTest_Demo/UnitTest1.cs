using BlazorApp2.Components;
using BlazorApp2.Services;
//using BlazorApp2.Utilities;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;
using BlazorApp2.Models;
using BlazorApp2.Services;

// Tests login and register,

namespace UnitTest
{
    public class Tests
    {
        private TlS2302172RzaContext _context;
        private CustomerService _customerService;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<TlS2302172RzaContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            _context = new TlS2302172RzaContext(options);
            _customerService = new CustomerService(_context);
        }
        [Test]
        public async Task GoodLogin()
        {
            Customer tempCustomer = new Customer()
            {
                Username = "admin",
                Password = "admin"
            };
            await _customerService.AddCustomerAsync(tempCustomer);
            var result = await _context.Customers.FirstOrDefaultAsync(c => c.Username == tempCustomer.Username);
            Assert.NotNull(result);
        }
        [Test]
        public async Task BadLogin()
        {
            Customer tempCustomer = new Customer()
            {
                Username = "admin",
                Password = "admin"
            };
            await _customerService.AddCustomerAsync(tempCustomer);
            var result = await _context.Customers.FirstOrDefaultAsync(c => c.Username == "not admin");
            Assert.Null(result);
        }
        [Test]
        public async Task GoodRegister()
        {
            Customer tempCustomer = new Customer()
            {
                Username = "admin",
                Password = "admin"
            };
            await _customerService.AddCustomerAsync(tempCustomer);
            var result = await _customerService.LogIn(tempCustomer);
            Assert.NotNull(result);
        }
        [Test]
        public async Task BadRegister()
        {
            Customer tempCustomer = new Customer()
            {
                Username = "admin",
                Password = "admin"
            };
            await _customerService.AddCustomerAsync(tempCustomer);
            tempCustomer.Username = "not admin";
            var result = await _customerService.LogIn(tempCustomer);
            Assert.Null(result);
        }
        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }
    }
}