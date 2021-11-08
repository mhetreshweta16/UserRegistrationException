using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationException;

namespace TestingUserException
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);

            try
            {
                string actual = testing.getValidUserFirstName();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }          
            
        }

        [TestMethod]
        public void TestUserLastName()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);

            try
            {
                string actual = testing.getvalidUserLastName();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void TestUserEmail()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);
            
            try
            {
                string actual = testing.getValidUserEmail();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
