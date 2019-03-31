using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//-------------------------------
//Majid Tooranisama
//#7725070
//Assignment# 5
//August 7, 2018
//-------------------------------

namespace MTAssignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool resultBool = false;                  // global variable "resultBool" for all  boolean methods
        string resultString = "";                 // global variable "resultString" for all  string methods

        private void onlyInputDigitstxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MTUtilityClasses.MTNumericUtilities.OnlyInputDigits(e);   // keypress event handler doesn't allow users enter except digits
            if (e == null)
            {
                onlyInputDigitsLabel.Text = "No entry";
            }
        }
        private void testButton_Click(object sender, EventArgs e) //by clicking test button all methods will be tested at once                                                                    
        { 
//--------------------------------------------------------------------------------------------------------            
            resultBool = MTUtilityClasses.MTNumericUtilities.IsNumeric(isNumerictxtBox.Text);  //calls IsNumeric(string) method
            if (resultBool)
            {
                isNumericLabel.Text = "Correct number";
            }
            else
            {
                isNumericLabel.Text = "Incorrect Format number";
            }
//--------------------------------------------------------------------------------------------------------
            string myEntry = objectIsNumerictxtBox.Text;   //calls IsNumeric(object) method
            Object numericObject = new Object();
            numericObject = myEntry;
            resultBool = MTUtilityClasses.MTNumericUtilities.IsNumeric(numericObject);
            if (resultBool)
            {
                objectIsNumericLabel.Text = "Correct number(object)";
            }
            else
            {
                objectIsNumericLabel.Text = "Incorrect Format number(object)";
            }
//--------------------------------------------------------------------------------------------------------
            resultBool = MTUtilityClasses.MTNumericUtilities.IsInteger(isIntegertxtBox.Text); //calls IsInteger(string) method
            if (resultBool)
            {
                isIntegerLabel.Text = "Correct integer";
            }
            else
            {
                isIntegerLabel.Text = "Incorrect format integer";
            }
//--------------------------------------------------------------------------------------------------------
            myEntry = objectIsIntegertxtBox.Text;            //calls IsInteger(object) method
            Object integerObject = new Object();
            integerObject = myEntry;
            resultBool = MTUtilityClasses.MTNumericUtilities.IsInteger(integerObject);
            if (resultBool)
            {
                objectIsIntegerLabel.Text = "Correct integer(object)";
            }
            else
            {
                objectIsIntegerLabel.Text = "Incorrect format integer(object)";
            }
//--------------------------------------------------------------------------------------------------------
            myEntry = doubleIsIntegertxtBox.Text;            //calls IsInteger(double) method
            if (myEntry != "")
            {
                try
                {
                    double integerDouble = Convert.ToDouble(myEntry);
                    resultBool = MTUtilityClasses.MTNumericUtilities.IsInteger(integerDouble);
                    if (resultBool)
                    {
                        doubleIsIntegerLabel.Text = "Correct integer(double)";
                    }
                    else
                    {
                        doubleIsIntegerLabel.Text = "Incorrect format integer(double)";
                    }
                }
                catch (Exception ex)
                {
                    doubleIsIntegerLabel.Text = ex.Message;
                }
            }
            else
            {
                doubleIsIntegerLabel.Text = "No entry";
            }
//--------------------------------------------------------------------------------------------------------
                                                            //calls ExtractNumeric method
            resultString = MTUtilityClasses.MTNumericUtilities.ExtractNumeric(extractNumerictxtBox.Text);
            if (resultString == null)
            {
                extractNumericLabel.Text = "No entry";
            }
            else
            {
                extractNumericLabel.Text = resultString;
            }
//--------------------------------------------------------------------------------------------------------
                                                                //calls Capitalize method
            resultString = MTUtilityClasses.MTStringUtilities.Capitalize(capitalizetxtBox.Text);
            if (resultString == null)
            {
                capitalizeLabel.Text = "No entry";
            }
            else
            {
                capitalizeLabel.Text = resultString;
            }
//--------------------------------------------------------------------------------------------------------
                                                                //calls ExtarctDigits method
            resultString = MTUtilityClasses.MTStringUtilities.ExtractDigits(extractDigitstxtBox.Text);
            if (resultString == null)
            {
                extractDigitsLabel.Text = "No entry";
            }
            else
            {
                extractDigitsLabel.Text = resultString;
            }
//--------------------------------------------------------------------------------------------------------
                                                                //calls FormatPostal method
            resultString = MTUtilityClasses.MTStringUtilities.FormatPostal(formatPostaltxtBox.Text);
            if (resultString == null)
            {
                formatPostalLabel.Text = "No entry";
            }
            else
            {
                formatPostalLabel.Text = resultString;
            }
//--------------------------------------------------------------------------------------------------------
                                                                 //calls FormatPostalCode method
            resultString = MTUtilityClasses.MTStringUtilities.FormatPostalCode(formatPostalCodetxtBox.Text);
            if (resultString == null)
            {
                formatPostalCodeLabel.Text = "No entry";
            }
            else
            {
                formatPostalCodeLabel.Text = resultString;
            }
//--------------------------------------------------------------------------------------------------------
                                                                //calls FormatZipCode method
            resultString = MTUtilityClasses.MTStringUtilities.FormatZipCode(formatZipCodetxtBox.Text);
            if (resultString == null)
            {
                formatZipCodeLabel.Text = "No entry";
            }
            else
            {
                formatZipCodeLabel.Text = resultString;
            }
//--------------------------------------------------------------------------------------------------------
                                                                    //calls FullName method
            resultString = MTUtilityClasses.MTStringUtilities.FullName(firstNametxtBox.Text, lastNametxtBox.Text);
            if (resultString == null)
            {
                fullNameLabel.Text = "No entry";
            }
            else
            {
                fullNameLabel.Text = resultString;
            }
//--------------------------------------------------------------------------------------------------------
                                                               //calls ValidatePostalCode method
            resultBool = MTUtilityClasses.MTValidations.ValidatePostalCode(validatePostalCodetxtBox.Text);
            if (!resultBool)
            {
                validatePostalCodeLabel.Text = "Invalid postal code";
            }
            else
            {
                if (validatePostalCodetxtBox.Text == "")
                {
                    validatePostalCodeLabel.Text = "No entry";
                }
                else
                {
                    validatePostalCodeLabel.Text = "Valid postal code";
                }
            }
//--------------------------------------------------------------------------------------------------------
                                                                 //calls ValidateZipCode method
            resultBool = MTUtilityClasses.MTValidations.ValidateZipCode(validateZipCodetxtBox.Text);
            if (resultBool)
            {
                validateZipCodeLabel.Text = "Valid zip code";
            }
            else
            {
                validateZipCodeLabel.Text = "Invalid zip code";
            }
//--------------------------------------------------------------------------------------------------------
                                                              //calls ValidatePhoneNumber method
            resultBool = MTUtilityClasses.MTValidations.ValidatePhoneNumber(validatePhonetxtBox.Text);
            if (resultBool)
            {
                validatePhoneLabel.Text = "Valid phone number";
            }
            else
            {
                validatePhoneLabel.Text = "Invalid phone number";
            }
        }
    }
}

   
