using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<List<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
