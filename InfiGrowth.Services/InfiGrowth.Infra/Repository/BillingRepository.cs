using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Context;
using InfiGrowth.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository
{
    public class BillingRepository : IBillingRepository
    {
        private readonly TravelContext _context;

        public BillingRepository(TravelContext context)
        {
            _context = context;
        }
        public async Task<Billing> CreateBill(Billing billing)
        {
            _context.Billings.Add(billing);
            await _context.SaveChangesAsync();
            return billing;
        }

        public async Task<Billing> DeleteBill(Guid billId)
        {
            var result = await _context.Billings.FirstOrDefaultAsync(x => x.Id == billId);

            _context.Billings.Remove(result);
            await _context.SaveChangesAsync();
            return result;

        }
    }
}
