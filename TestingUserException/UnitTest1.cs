using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationException;

namespace TestingUserException
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the method1.
        /// </summary>
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

        /// <summary>
        /// Tests the last name of the user.
        /// </summary>
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

        /// <summary>
        /// Tests the user email.
        /// </summary>
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

        /// <summary>
        /// Tests the user mobile number.
        /// </summary>
        [TestMethod]
        public void TestUserMobileNumber()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);

            try
            {
                string actual = testing.getValidUserMobileNumber();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        /// <summary>
        /// Tests the user password.
        /// </summary>
        [TestMethod]
        public void TestUserPassword()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);

            try
            {
                string actual = testing.getValidUserPassword();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
        
    }
}
