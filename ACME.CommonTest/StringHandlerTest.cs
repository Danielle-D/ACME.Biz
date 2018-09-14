using ACME.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaces_StringWithNoSpace_AddSpace()
        {
            //Arrange
            string source = "JackSkellington";
            string expected = "Jack Skellington";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_StringWithExistingSpace_NoSpaceAdded()
        {
            //Arrange
            string source = "Jack Skellington";
            string expected = "Jack Skellington";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_StringWithSpaces_NoSpaceAddedd()
        {
            //Arrange
            string source = "Jack Skellington Zero";
            string expected = "Jack Skellington Zero";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_StringWithNoSpaces_SpacesAdded()
        {
            //Arrange
            string source = "JackSkellingtonZero";
            string expected = "Jack Skellington Zero";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_StringIsNull_EmptyStringIsReturned()
        {
            //Arrange
            string source = null;
            string expected = string.Empty;

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_StringIsEmpty_EmptyStringIsReturned()
        {
            //Arrange
            string source = string.Empty;
            string expected = string.Empty;

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_String_NoSpacesAdded()
        {
            //Arrange
            string source = "Jack";
            string expected = "Jack";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_StringWithLowercase_NoSpacesAdded()
        {
            //Arrange
            string source = "Jack skellington";
            string expected = "Jack skellington";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_ShortString_NoSpacesAdded()
        {
            //Arrange
            string source = "A";
            string expected = "A";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaces_AllUpperCase_NoSpacesAdded()
        {
            //Arrange
            string source = "HELLO";
            string expected = "H E L L O";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}