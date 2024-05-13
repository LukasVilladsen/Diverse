using CustomerManagerApp_Mock.Interfaces;
using CustomerManagerApp_Mock.Models;
using CustomerManagerApp_Mock.Services;
using Moq;
using System.Net;
using System.Numerics;

namespace CustomerTestProject
{
    [TestClass]
    public class CustomerManagerUnitTest
    {

        [TestMethod]
        public void GetCustomers_ShouldReturnLists()
        {
            // Arrange
            var mockCustomerRepository= new Mock<ICustomerRepository>();
              
            var customers= new List<Customer>() { new Customer() { CustomerId = 1, Email = "moalgmail.dk"} };
            
            
            mockCustomerRepository.Setup(x => x.GetCustomers()).Returns(customers);
            // Jeg har brug for en CustomerManager object for at lave kald til getCustomers() metode
            var customerManager = new CustomerManager(mockCustomerRepository.Object);
            // Act
            
            var allCustomers = customerManager.GetCustomers();
            
            // Assert
            Assert.AreEqual(1, allCustomers.Count());
            Assert.IsNotNull(allCustomers[0]);
            Assert.AreEqual(1, allCustomers[0].CustomerId);
        }




        [TestMethod]
        public void GetCustomer_WithAnInvalidId_ShouldReturnNull()
        {

            // Arrange
            var mockCustomerRepository = new Mock<ICustomerRepository>();

            mockCustomerRepository.Setup(x => x.GetCustomer(It.IsInRange(int.MinValue, 0, Moq.Range.Inclusive))).Returns<Customer>(null);

            var customerManager = new CustomerManager(mockCustomerRepository.Object);


            // Act

           var cutsomer = customerManager.GetCustomer(-2);

            // Assert

            Assert.IsNull(cutsomer);
            

        }



        [TestMethod]
        public void GetCustomer_WithAValidId_ShouldReturnCustomer()
        {

            // Arrange



            // Act


            // Assert
        }


        [TestMethod]
        public void GetCustomers_WithNullFirstName_ShouldThrowException()
        {

            // Arrange
            var mockCustomerRepository = new Mock<ICustomerRepository>();
            mockCustomerRepository.Setup(x=> x.GetCustomers(null , It.IsAny<string>()));

            var customerManager = new CustomerManager (mockCustomerRepository.Object);
            // Act
            ArgumentNullException ex = Assert.ThrowsException<ArgumentNullException>( 
                ()=> customerManager.GetCustomers(null, "moal"));

            // Assert
            Assert.AreEqual(ex.ParamName, "firstName");
            Assert.AreEqual(ex.Message, "FirstName is a required field (Parameter 'firstName')");
        }

        [TestMethod]
        public void GetCustomers_WithNullLastName_ShouldThrowException()
        {

            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void GetCustomers_WithValidParameters_ShouldReturnLists()
        {

            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void SaveCustomer_WithANullCustomer_ShouldThrowException()
        {

            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void SaveCustomer_WithNullFirstName_ShouldThrowException()
        {

            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void SaveCustomer_WithNullLastName_ShouldThrowException()
        {

            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void SaveCustomer_WithNullEmailAddress_ShouldThrowException()
        {

            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void SaveCustomer_WithBirthdayInFuture_ShouldThrowException()
        {

            // Arrange



            // Act


            // Assert

        }



        [TestMethod]
        public void SaveCustomer_WithValidCustomer_ShouldReturnTrue()
        {

            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void DeleteCustomer_WithInvalidCustomertId_ShouldReturnFalse()
        {

            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void DeleteCustomer_WithNullCustomer_ShouldReturnFalse()
        {


            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void DeleteCustomer_WithExistingCustomer_ShouldReturnTrue()
        {


            // Arrange



            // Act


            // Assert
        }

        [TestMethod]
        public void GetCustomerPhones_WithValidCustomerId_ShouldReturnAListOfPhones()
        {

            // Arrange



            // Act


            // Assert
        }


        [TestMethod]
        public void GetCustomerPhone_WithValidCustomerIdAndPhoneId_ShouldReturnPhone()
        {

            // Arrange



            // Act


            // Assert
        }
    }
}
