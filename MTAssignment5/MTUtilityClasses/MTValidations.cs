using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//-------------------------------
//Majid Tooranisama
//#7725070
//Assignment# 5
//August 7, 2018
//-------------------------------

namespace MTAssignment5.MTUtilityClasses
{
    public static class MTValidations
    {
        public static Boolean ValidatePostalCode(string entry) //Method for validating postal code comparing with Canadian Postalcode pattern
        {
            Regex postalCodePatt = new Regex(@"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$"
                            , RegexOptions.IgnoreCase);
            entry = (entry + "").Trim();
            if (postalCodePatt.IsMatch(entry) || entry == "" || entry == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean ValidateZipCode(string entry)  //Method for extracting & validating Zip code comparing with USA Zipcode pattern
        {
            int count = 0;
            entry = (entry + "").Trim();
            if (entry != "")
            {
                foreach (char Char in entry)
                {
                    if (char.IsPunctuation(Char) || char.IsLetter(Char) || char.IsWhiteSpace(Char))
                    {
                        entry = entry.Remove(entry.IndexOf(Char), 1);    //removes any character except digits
                    }
                }
                foreach (char Char in entry)
                {
                    if (char.IsDigit(Char))
                    {
                        count++;
                    }
                }
            }
            if (count == 5 || count == 9)                     //returns true if the number of digits is 5 or 9
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean ValidatePhoneNumber(string entry)  //Method for extracting & validating Phone number comparing with phone number pattern
        {
            int count = 0;
            entry = (entry + "").Trim();
            if (entry != "")
            {
                foreach (char Char in entry)
                {
                    if (char.IsPunctuation(Char) || char.IsLetter(Char) || char.IsWhiteSpace(Char))
                    {
                        entry = entry.Remove(entry.IndexOf(Char), 1);      //removes any character except digits
                    }
                }
                foreach (char Char in entry)
                {
                    if (char.IsDigit(Char))
                    {
                        count++;
                    }
                }
            }
            if (count == 10)                                         //returns true if the number of digits is 10
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
