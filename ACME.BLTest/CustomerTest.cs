using ACME.Biz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();

            customer.FirstName = "Fred";
            customer.LastName = "Smith";

            string expectedResult = "Fred, Smith";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(actual, expectedResult);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();

            customer.FirstName = null;
            customer.LastName = "Smith";

            string expectedResult = "Smith";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(actual, expectedResult);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();

            customer.FirstName = "Fred";
            customer.LastName = null;

            string expectedResult = "Fred";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(actual, expectedResult);
        }

        [TestMethod]
        public void StaticTest()
        {
        //Arrange
        var c1 = new Customer();
            c1.FirstName = "Fred";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Bob";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Joseph";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            Customer customer = new Customer();

            customer.LastName = "Smith";
            customer.EmailAddress = "Smith@googlemail.com";

            var expectedResult = true;

            //Act
            var actual = customer.Validate();


            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            Customer customer = new Customer();

            customer.LastName = null;

            var expectedResult = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ValidateMissingEmail()
        {
            //Arrange
            Customer customer = new Customer();

            customer.LastName = "Smith";

            var expectedResult = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ValidateMissingLastNameAndEmail()
        {
            //Arrange
            Customer customer = new Customer();

            var expectedResult = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }
    }
}