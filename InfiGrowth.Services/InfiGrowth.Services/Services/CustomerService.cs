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
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) {
            _customerRepository = customerRepository;
        }

        public Task<Customer> CreateCustomer(Customer customer)
        {
            return _customerRepository.CreateCustomer(customer);
        }

        public Task<Customer> DeleteCustomer(Guid customerId)
        {
            return _customerRepository.DeleteCustomer(customerId);
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public Task<Customer> GetByCustomerId(Guid customerId)
        {
            return _customerRepository.GetByCustomerId(customerId);
        }

        public Task<Customer> UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}
