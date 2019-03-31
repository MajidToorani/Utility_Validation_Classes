using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//-------------------------------
//Majid Tooranisama
//#7725070
//Assignment# 5
//August 7, 2018
//-------------------------------

namespace MTAssignment5.MTUtilityClasses
{
    public static class MTNumericUtilities
    {
        public static Boolean IsNumeric(string parameter)     //boolean method for checking a string if is a numeric or not
        {
            Regex numericPatt = new Regex(@"^\-?[0-9]+\.?[0-9]*$");
            if (numericPatt.IsMatch(parameter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean IsNumeric(object parameter)   //boolean method for checking an object if is a numeric or not 
        {
            string strObject = parameter.ToString();
            return IsNumeric(strObject);
        }
        public static Boolean IsInteger(string parameter)  //boolean method for checking a string if is an integer or not
        {
            Regex integerPatt = new Regex(@"^\-?[0-9]+$");
            if (integerPatt.IsMatch(parameter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean IsInteger(double parameter)  //boolean method for checking a double if is an integer or not
        {
            string strDouble = parameter.ToString();
            return IsInteger(strDouble);
        }
        public static Boolean IsInteger(object parameter)  //boolean method for checking an object if is an integer or not
        {
            string strObject = parameter.ToString();
            return IsInteger(strObject);
        }
        public static string ExtractNumeric(string entry)  //string method for checking a string if is a numeric or not and fixes the errors in numeric string
        {
            bool result = IsNumeric(entry);
            int errorNo = 0;
            if (result == false)
            {
                foreach (char Char in entry)
                {
                    if (char.IsLetter(Char))
                    {
                        entry = entry.Remove(entry.IndexOf(Char), 1);
                    }
                    int dashIndex = entry.IndexOf("-");
                    if (dashIndex != -1)
                    {
                        if (dashIndex > 0)            // if there is a single dash, and it isn't at the first, it checks: if it is at the end, it will
                        {                              //be removed, and inserts it as the first index 
                            errorNo++;
                        }
                        if (errorNo == 1)                                                                                                        
                        {                                              
                            if (dashIndex != 0)
                            {
                                if (dashIndex == entry.Length - 1)
                                {
                                    entry = entry.Remove(dashIndex, 1);
                                    entry = entry.Insert(0, "-");
                                }
                                else
                                {
                                    entry = entry.Remove(dashIndex, 1);  //if a single dash is in the middle, it will be removed
                                }
                            }
                        }
                        else                                           
                        {                                                                                                                                       
                            entry = entry.Remove(dashIndex, 1);        // if there are more than one dash, all will be removed
                        }
                    }
                    int firstDecimal = entry.IndexOf(".");
                    int lastDecimal = entry.LastIndexOf(".");
                    if (firstDecimal != -1)
                    {
                        if (firstDecimal != lastDecimal)
                        {
                            entry = entry.Remove(lastDecimal, 1);          //maximum one decimal allowed 
                        }                                          // removes extra decimal from string                         
                    }
                    int dsignIndex = entry.IndexOf("$");
                    if (dsignIndex != -1)
                    {
                        entry = entry.Remove(dsignIndex, 1);
                    }
                    int spaceIndex = entry.IndexOf(" ");
                    if (spaceIndex != -1)
                    {
                        entry = entry.Remove(spaceIndex, 1);
                    }                   
                    int commaIndex = entry.IndexOf(",");
                    if (commaIndex != -1)
                    {
                        entry = entry.Remove(commaIndex, 1);   // only Number should remain at this point
                    }
                }
            }
            bool newResult = IsNumeric(entry);
            if (newResult == true)
            {
                return entry;
            }
            else
            {
                return null;
            }
        }
        public static void OnlyInputDigits(KeyPressEventArgs e)      //Method for avoiding to enter except digits
        {                                                            
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
                                         
