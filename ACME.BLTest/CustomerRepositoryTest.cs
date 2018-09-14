using System;
using System.Collections.Generic;
using ACME.Biz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "dsmith@gmail.com",
                FirstName = "David",
                LastName = "Smith"
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
