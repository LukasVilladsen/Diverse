using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagerApp_Mock.Models
{
    public class Customer
    {
        public Customer()
        {
           Phones = new List<Phone>();
        }
        public int CustomerId { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        
        public List<Phone> Phones { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName))
                {
                    return "Could not determine the customer name";
                }

                if (string.IsNullOrEmpty(FirstName))
                {
                    return $" {LastName}";
                }

                return $"{FirstName}{LastName}";
            }
        }
    }
}
