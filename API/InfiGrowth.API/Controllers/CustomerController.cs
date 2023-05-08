using InfiGrowth.Entity.Manage;
using InfiGrowth.Services.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Travel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers() { 
            return Ok(await _customerService.GetAllCustomers());
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            return Ok(await _customerService.CreateCustomer(customer));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(Guid customerId)
        {
            return Ok(await _customerService.DeleteCustomer(customerId));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            return Ok(await _customerService.UpdateCustomer(customer));
        }
        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetCustomerById(Guid customerId)
        {
            return Ok(await _customerService.GetByCustomerId(customerId));
        }
    }
}
