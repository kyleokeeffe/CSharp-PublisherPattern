using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2Classes
{
    public static class Validator
    {
        public static bool ValidateEmail(string text)
        {
            //<summary>
            //Method for validating email address using MailAddress object
            try
            {
                MailAddress email = new MailAddress(text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool ValidatePhone(string text)
        {
            //<summary>
            //Method tot validate phone number using regular expression
            string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            return Regex.IsMatch(text, motif);
        }
    }
}

