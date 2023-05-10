using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Repository.Interfaces;
using InfiGrowth.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services
{
    public class BillingService:IBillingService
    {
        private readonly IBillingRepository _billingRepository;

        public BillingService(IBillingRepository billingRepository) 
        { 
             _billingRepository=billingRepository;
        }

        public async Task<Billing> CreateBill(Billing billing)
        {
            return await _billingRepository.CreateBill(billing);
        }

        public async Task<Billing> DeleteBill(Guid billId)
        {
            return await _billingRepository.DeleteBill(billId);
        }
    }
}
