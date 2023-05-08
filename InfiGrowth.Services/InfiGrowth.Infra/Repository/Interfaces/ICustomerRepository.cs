using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomers();

        Task<Customer> CreateCustomer(Customer customer);

        Task<Customer> GetByCustomerId(Guid customerId);

        Task<Customer> UpdateCustomer(Customer customer);
        Task<Customer> DeleteCustomer(Guid customerId);
    }
}
