﻿using System;
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

    }
}
