using System;
using System.Text;
using System.Collections.Generic;
using ACME.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.Biz;

namespace ACME.CommonTest
{
    /// <summary>
    /// Summary description for LoggingServiceTest
    /// </summary>
    [TestClass]
    public class LoggingServiceTest
    {
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "BobSmith@googlemail.com",
                FirstName = "Bob",
                LastName = "Smith",
                WorkAddress = null
            };
            changedItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product as ILoggable);

            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert
            //Nothing here to assert
        }
    }
}