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
    public static class MTStringUtilities
    {
        public static string Capitalize(string entry)     //Method for capitalizing the string entries by users
        {                                                    
            string capitalizedEntry = "";
            if (entry != "")
            {
                entry = (entry+"").Trim();
                entry = entry.ToLower();
                char[] arrEntry = entry.ToArray();
                arrEntry[0] = char.ToUpper(arrEntry[0]);

                for (int i = 0; i < arrEntry.Length; i++)
                {
                    if (arrEntry[i] == ' ')
                    {
                        arrEntry[i + 1] = char.ToUpper(arrEntry[i + 1]);
                    }
                    capitalizedEntry += arrEntry[i].ToString();
                }
                return capitalizedEntry;
            }
            else
            {
                return null;
            }
        }
        public static string ExtractDigits(string entry)    //Method for extracting a string and returns only its digits
        {
            if (entry != "")
            {
                entry = (entry+"").Trim();
                foreach (char Char in entry)
                {
                    if (char.IsPunctuation(Char) || char.IsLetter(Char))
                    {
                        entry = entry.Remove(entry.IndexOf(Char), 1);
                    }
                }
                return entry;
            }
            else
            {
                return null;
            }
        }
        public static string FormatPostal(string entry)        //Method for reformatting the data entries to pattern(123-1234 or 123-123-1234)
        {                                                          
            Regex postalPatt = new Regex(@"^\d{7}(\d{3})?$"); 
            if (entry != "")
            {
                entry = (entry + "").Trim();
                if (postalPatt.IsMatch(entry))
                {
                    if (entry.Length == 7)
                    {
                        entry = entry.Insert(3, "-");
                    }
                    else
                    {
                        entry = entry.Insert(3, "-");
                        entry = entry.Insert(7, "-");
                    }
                }
                else
                {
                    entry = "The valid entry should be 7 or 10 digits";
                }
                return entry;
            }
            else
            {
                return null;
            }
        }
        public static string FormatPostalCode(string entry)        //Method for reformatting the Canadian postal code entries to pattern(A1A 1A1)
        {                                                              
            Regex postCodePatt = new Regex(@"^[A-Za-z]\d[A-Za-z]\s?\d[A-Za-z]\d$");
            if (entry != "")
            {
                entry = (entry + "").Trim();
                if (postCodePatt.IsMatch(entry))
                {                    
                    entry = entry.ToUpper();
                    if (!(entry.Contains(" ")))
                    {
                        entry = entry.Insert(3, " ");
                    }
                }
                else
                {
                    entry = "The format is A1A 1A1";
                }
                return entry;
            }
            else
            {
                return null;
            }
        }
        public static string FormatZipCode(string entry)     //Method for reformatting the Zip code entries to pattern(12345 or 12345-1234)
        {                                                        
            Regex zipCodePatt = new Regex(@"^\d{5}(-?\d{4})?$");
            if (entry != "")
            {
                entry = (entry + "").Trim();
                if (zipCodePatt.IsMatch(entry))
                {
                    if (!entry.Contains("-") && entry.Length == 9)
                    {
                        entry = entry.Insert(5, "-");
                    }
                }
                else
                {
                    entry = "Format is only 5 or 9 digits";
                }
                return entry;
            }
            else
            {
                return null;
            }
        }
        public static string FullName(string firstName, string lastName)  //Method for reformatting names to capitalized and pattern(Lastname, Firstname)
        {                                                                   
            string fullName = "";                                           
            if (firstName != "" || lastName != "")
            {
                firstName = (firstName + "").Trim();
                lastName = (lastName + "").Trim();
                if (firstName != "" && lastName != "")
                {
                    firstName = Capitalize(firstName);
                    lastName = Capitalize(lastName);
                    fullName = lastName + ", " + firstName;
                }
                else if (lastName == "")
                {
                    firstName = Capitalize(firstName);
                    fullName = firstName;
                }
                else
                {
                    lastName = Capitalize(lastName);
                    fullName = lastName;
                }
            }
            else
            {
                fullName = "No entry";
            }
            return fullName;
        }
    }
}
