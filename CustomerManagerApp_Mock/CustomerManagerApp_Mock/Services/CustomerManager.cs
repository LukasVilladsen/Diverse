using CustomerManagerApp_Mock.Interfaces;
using CustomerManagerApp_Mock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagerApp_Mock.Services
{
    public class CustomerManager 
    {
        private readonly ICustomerRepository _customerRepository;
       
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomer(int cId)
        {
            return _customerRepository.GetCustomer(cId);
        }

        public async Task<Customer> GetCustomerAsync(int cId)
        {
            return await _customerRepository.GetCustomerAsync(cId);
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _customerRepository.GetCustomersAsync();
        }

        public List<Customer> GetCustomers(string firstName, string lastName)
        {
            ValidationForGetCustomers(firstName, lastName);

            return _customerRepository.GetCustomers(firstName, lastName);
        }

        public async Task<List<Customer>> GetCustomersAsync(string firstName, string lastName)
        {
            ValidationForGetCustomers(firstName, lastName);

            return await _customerRepository.GetCustomersAsync(firstName, lastName);
        }

        private static void ValidationForGetCustomers(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException(nameof(firstName), "FirstName is a required field");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException(nameof(lastName), "LastName is a required field");
            }
        }

        public Customer SaveCustomer(Customer customer)
        {
            // Data Validation
            ValidationForSaveCustomer(customer);

            return _customerRepository.SaveCustomer(customer);
        }

        public async Task<Customer> SaveCustomerAsync(Customer customer)
        {
            // Data Validation
            ValidationForSaveCustomer(customer);

            return await _customerRepository.SaveCustomerAsync(customer);
        }

        private static void ValidationForSaveCustomer(Customer customer)
        {
            // Null Checks
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "Customer is a required field");
            }

            if (string.IsNullOrEmpty(customer.FirstName))
            {
                throw new ArgumentNullException(nameof(customer.FirstName), "FirstName is a required field");
            }

            if (string.IsNullOrEmpty(customer.LastName))
            {
                throw new ArgumentNullException(nameof(customer.LastName), "LastName is a required field");
            }

            if (string.IsNullOrEmpty(customer.Email))
            {
                throw new ArgumentNullException(nameof(customer.Email), "EmailAddress is a required field");
            }

            // Business Rule Validation
            if (customer.Birthday > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException(nameof(customer.Birthday), customer.Birthday,
                    "The birthday can not be in the future");
            }
            
        }

        public bool DeleteCustomer(int cid)
        {
            return _customerRepository.DeleteCustomer(cid);
        }

        public async Task<bool> DeleteCustomerAsync(int cid)
        {
            return await _customerRepository.DeleteCustomerAsync(cid);
        }

        public bool DeleteCustomer(Customer customer)
        {
            return customer != null && _customerRepository.DeleteCustomer(customer);
        }

        public async Task<bool> DeleteCustomerAsync(Customer  customer)
        {
            return customer != null && await _customerRepository.DeleteCustomerAsync(customer);
        }

        public List<Phone> GetCustomerPhones(int cId)
        {
            return _customerRepository.GetCustomerPhones(cId);
        }

        public async Task<List<Phone>> GetCustomerPhonesAsync(int cId)
        {
            return await _customerRepository.GetCustomerPhonesAsync(cId);
        }

        public Phone GetCustomerPhone(int cId, int phoneId)
        {
            return _customerRepository.GetCustomerPhone(cId, phoneId);
        }

        public async Task<Phone> GetCustomerPhoneAsync(int cId, int phoneId)
        {
            return await _customerRepository.GetCustomerPhoneAsync(cId, phoneId);
        }

    }
}
