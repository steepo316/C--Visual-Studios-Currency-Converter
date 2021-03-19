using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //Regex

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        // Declaring global variables
        decimal finalResult; // The final sum.
        string finalOutput; // The final output which will be displayed to the user. Includes the finalResult variable.

        class getRates
        {

            public decimal findRates(string convertFrom, string convertTo)
            {
                const string get = "https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=d588da9f65ddb54e67c3"; // Pass the currencies into the URL
                Console.WriteLine($"DEBUG: Converting {convertFrom} into {convertTo}");
                string url = String.Format(get, convertTo, convertFrom); // Inserting values into get variable.
                Console.WriteLine($"DEBUG: Using URL {url}");
                string response = new WebClient().DownloadString(url); // Extracting the data.
                Console.WriteLine($"DEBUG: Response: { response}");

                response = Regex.Match(response, @"[0-9]+(\.[0-9]+)?").Value; // Only select decimals within the extracted value.
                Console.WriteLine($"DEBUG: Extracted Conversion Rate: {response}");
                //double final_response = double.Parse(response, System.Globalization.CultureInfo.InvariantCulture);
                decimal final_response = decimal.Parse(response); // Parse from string into decimal.
                return final_response; // Return to calling method.

            }
        }
        class calculations
        {
            public static decimal performRounding(decimal input, int decimalPlaces) // Expect 2 values to be passed into method.
            {
                decimal roundingCalculation = Math.Round(input, decimalPlaces); // Round a value to a given number of decimal places.
                return roundingCalculation; // Return to calling method.
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void currencyBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void overlay_Click(object sender, EventArgs e)
        {
            overlay.Visible = false; // Hide the overlay / menu.
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Resetting all values to their default state.
            overlay.Visible = true;
            output.Text = "";
            convertText.Text = "";
            currencyFromBox.Text = "";
            currencyToBox.Text = "";
            roundUp.Visible = false;
            goBack.Visible = false;

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void convertCurrencies(string currencyFrom, string currencyTo)
        {
            getRates getRates = new getRates(); // Create a constructor.
            decimal conversionRate = getRates.findRates(currencyFrom, currencyTo); // Call the method using the getRated consutuctor, passing 2 variales.
            Console.WriteLine($"DEBUG: Received conversion rate from findRates class: {conversionRate}");
            finalResult = decimal.Parse(convertText.Text) * conversionRate; // Convert user input into decimal.
            finalOutput = ($"{convertText.Text} {currencyTo} converted into {currencyFrom} equals {finalResult}"); // Final output.
            Console.WriteLine($"DEBUG: Performing calculation: {convertText.Text} * {conversionRate}. Final sum = {finalOutput}");
            output.Text = finalOutput; // Display the final result.
            roundUp.Visible = true; // Display the round up button.
        }

        private void roundUp_Click(object sender, EventArgs e)
        {
            calculations doCalculations = new calculations(); // Create a constructor.
            decimal rounded = calculations.performRounding(finalResult, 2); // Defining a variable. Setting its value by calling method and expecting a returned value.
            Console.WriteLine($"DEBUG: Rounding Up to {rounded}");
            output.Text = ($"The converted amount rounded up equals {rounded}"); // Displaying the final rounded result.
            roundUp.Visible = false; // Hide round up button.
            goBack.Visible = true; // Display go back button to revert rounding changes.
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (currencyToBox.Text == currencyFromBox.Text) // If the user tries to convert 2 currencies that are the same do:
            {
                output.Text = "Please select two different currencies."; // Inform the user their input is invalid.
            }
            else // Otherwise, do:
            {
                decimal checkInput; // Validate the users input.
                bool isNumerical = decimal.TryParse(convertText.Text, out checkInput); // Is the users input a valid decimal?
                if (isNumerical) // If yes do:
                {
                    goBack.Visible = false; // Allow the user to round their sum bu hiding the go back button and displaying the round button.
                                            // The go back button allows the user to revert to their original sum after it has been rounded.
                    roundUp.Visible = true;
                    Console.WriteLine("DEBUG: Input is Numerical and Valid");
                    convertCurrencies(currencyToBox.Text, currencyFromBox.Text); // Call method, passing the users currency selections into it.
                }
                else // If not, do:
                {
                    output.Text = "Your input is not numerical."; // Inform the user their input is invalid.
                    Console.WriteLine("DEBUG: Input is Not numberical and Invalid");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            output.Text = finalOutput; // Display the previous unrounded sum.
            goBack.Visible = false; // Hide this buttton.
            roundUp.Visible = true; // Show round up button.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}