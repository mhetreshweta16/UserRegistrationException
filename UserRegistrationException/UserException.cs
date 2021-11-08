using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationException
{
   public class UserException
    {
        public string message;
        public UserException(string message)
        {
            this.message = message;

        }

        //User Registration Pattern
        string firstNamePattern = "^[A-Z]{1}[a-z]{2}$";
        string lastNamePattern = "^[A-Z]{1}[a-z]{2}$";
        string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
        string mobileNoPattern = "^[1-9]{2}[ ]{1}[0-9]{10}$";
        string passwordPattern = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8}$";

        /// <summary>
        /// to valide the user first name
        /// </summary>
        /// <returns></returns>
        public string getValidUserFirstName()
        {
            Regex regex = new Regex(firstNamePattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }               
        }

        /// <summary>
        /// to valide the user Last Name
        /// </summary>
        /// <returns></returns>
        public string getvalidUserLastName()
        {

            Regex regex = new Regex(lastNamePattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// to valide the user email
        /// </summary>
        /// <returns></returns>
        public string getValidUserEmail()
        {
            Regex regex = new Regex(emailPattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (Exception ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// to valide the user mobile number
        /// </summary>
        /// <returns></returns>
        public string getValidUserMobileNumber()
        {
            Regex regex = new Regex(mobileNoPattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (Exception ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// to valide the user password
        /// </summary>
        /// <returns></returns>
        public string getValidUserPassword()
        {

            Regex regex = new Regex(passwordPattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (Exception ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }

        }

    }
}
