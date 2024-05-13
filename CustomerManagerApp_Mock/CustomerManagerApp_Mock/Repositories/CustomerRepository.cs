using CustomerManagerApp_Mock.Data;
using CustomerManagerApp_Mock.Interfaces;
using CustomerManagerApp_Mock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static CustomerManagerApp_Mock.Repositories.CustomerRepository;

namespace CustomerManagerApp_Mock.Repositories
{
   public class CustomerRepository:ICustomerRepository
    {
           private readonly FakeData _fakeData;

            public CustomerRepository()
            {
                _fakeData =  new FakeData();
            }

       public Customer GetCustomer(int Id)
       {
         throw new NotImplementedException();
       }

            
        public Task<Customer> GetCustomerAsync(int cId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetCustomersAsync(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Customer SaveCustomer(Customer contact)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> SaveCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int cId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomerAsync(int cId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Phone> GetCustomerPhones(int cId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Phone>> GetCustomerPhonesAsync(int cId)
        {
            throw new NotImplementedException();
        }

        public Phone GetCustomerPhone(int cId, int phoneId)
        {
            throw new NotImplementedException();
        }

        public Task<Phone> GetCustomerPhoneAsync(int cId, int phoneId)
        {
            throw new NotImplementedException();
        }
    }
    
}
