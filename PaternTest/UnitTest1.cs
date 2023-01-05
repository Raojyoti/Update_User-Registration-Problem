using NUnit.Framework;
using User_Registration;

namespace PaternTest
{
    public class Tests
    {
        [Test]
        public void ValidateFirstName()
        {
            //Arrange
            string excepted = "Sam";
            string firstname = "Mom";
            //Act
            UserEntryValidationTest analyser = new UserEntryValidationTest();
            string actual = analyser.ValidateFirstName(firstname);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [Test]
        public void ValidateLastName()
        {
            //Arrange
            string excepted = "Roy";
            string lastname = "Joy";
            //Act
            UserEntryValidationTest analyser = new UserEntryValidationTest();
            string actual = analyser.ValidateLastName(lastname);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [Test]
        public void ValidatePhoneNumber()
        {
            //Arrange
            string excepted = "91 9919819801";
            string phonenumber = "91 9919819501";
            //Act
            UserEntryValidationTest analyser = new UserEntryValidationTest();
            string actual = analyser.ValidatePhoneNumber(phonenumber);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [Test]
        public void ValidateEmail()
        {
            //Arrange
            string excepted = "abc.xyz@bl.co.in";
            string email = "abc.ram@bl.co.im";
            //Act
            UserEntryValidationTest analyser = new UserEntryValidationTest();
            string actual = analyser.ValidateEmail(email);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
        [Test]
        public void ValidatePassword()
        {
            //Arrange
            string excepted = "jyotirao";
            string password = "raojyoti";
            //Act
            UserEntryValidationTest analyser = new UserEntryValidationTest();
            string actual = analyser.ValidatePassword1(password);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
    }
}