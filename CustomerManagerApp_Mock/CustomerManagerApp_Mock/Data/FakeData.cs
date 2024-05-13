using CustomerManagerApp_Mock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagerApp_Mock.Data
{
    public  class FakeData
    {
       private  List<Customer> customers { get; set; }

        public FakeData() 
        {
            var customer = new Customer()
            {
                CustomerId = 1,
                Email = "hans@gmail.dk",
                FirstName = "Hans",
                LastName = "Petersen",
                Phones = new List<Phone>() { },
                Birthday = new DateTime(2000, 12, 10)
            } ;
            customers.Add(customer);        
        }

       public Customer GetCustomerById(int id)
        {
            return null;
        }

        public async  Task<Customer> GetCustomerByIdAsync(int id)
        {
            return null;
        }
    }
}
