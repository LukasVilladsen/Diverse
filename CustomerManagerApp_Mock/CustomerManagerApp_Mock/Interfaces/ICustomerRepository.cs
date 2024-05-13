using CustomerManagerApp_Mock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagerApp_Mock.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int cId);
        Task<Customer> GetCustomerAsync(int cId);

        List<Customer> GetCustomers();
        Task<List<Customer>> GetCustomersAsync();

        List<Customer> GetCustomers(string firstName, string lastName);
        Task<List<Customer>> GetCustomersAsync(string firstName, string lastName);

        Customer SaveCustomer(Customer customer);
        Task<Customer> SaveCustomerAsync(Customer customer);

        bool DeleteCustomer(int cId);
        Task<bool> DeleteCustomerAsync(int cId);

        bool DeleteCustomer(Customer customer);
        Task<bool> DeleteCustomerAsync(Customer customer);

        List<Phone> GetCustomerPhones(int cId);
        Task<List<Phone>> GetCustomerPhonesAsync(int cId);

        Phone GetCustomerPhone(int contactId, int phoneId);
        Task<Phone> GetCustomerPhoneAsync(int contactId, int phoneId);
    }
}
