using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace PincodeValidation
{
    class Validation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Pincode number");
            String pinCode = Console.ReadLine();
            while (!(validatePinCode(pinCode)))
            {
                Console.WriteLine("please enter a valid pincode");
                pinCode = Console.ReadLine();
            }
            Console.WriteLine("valid one");
        }

           public static bool validatePinCode(string pinCode)
        {
            String pattern = @"(^[1-9]{1}[0-9]{5}$)";
            Regex re = new Regex(pattern);
            if(re.IsMatch(pinCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        }
    }

