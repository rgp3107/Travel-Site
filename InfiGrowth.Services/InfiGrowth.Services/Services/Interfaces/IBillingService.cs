using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services.Interfaces
{
    public interface IBillingService
    {
        Task<Billing> CreateBill(Billing billing);

        Task<Billing> DeleteBill(Guid billId);
    }
}
