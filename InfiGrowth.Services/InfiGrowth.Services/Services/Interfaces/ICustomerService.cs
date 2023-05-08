using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Services.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();

        Task<Customer> CreateCustomer(Customer customer);

        Task<Customer> GetByCustomerId(Guid customerId);

        Task<Customer> UpdateCustomer(Customer customer);
        Task<Customer> DeleteCustomer(Guid customerId);
    }
}
