using InfiGrowth.Entity.Manage;
using InfiGrowth.Services.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Travel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private readonly IBillingService _billingService;

        public BillingController(IBillingService billingService)
        {
            _billingService = billingService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateBill(Billing bill) {
           return Ok(await _billingService.CreateBill(bill));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBill(Guid bill)
        {
            return Ok(await _billingService.DeleteBill(bill));
        }
    }
}
