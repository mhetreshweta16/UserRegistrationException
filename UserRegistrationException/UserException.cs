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
            catch (NullReferenceException ex)
            {
                 //throw new CustomException(CustomException.ExceptionType.NUll_Type_Exception, "invalid");
                Console.WriteLine(ex);
            }

            return default;
                  
        }

    }
}