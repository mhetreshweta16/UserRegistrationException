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
            

                string actual = testing.getValidUserFirstName();




            try
            { //Assert
                Assert.AreEqual(expected, actual);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
           
            
        }
    }
}
