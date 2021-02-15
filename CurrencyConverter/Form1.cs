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
using System.Text.RegularExpressions;

namespace CurrencyConverter
{



    public partial class Form1 : Form
    {
        double rounded;
        double finalResult;
        string finalOutput;
        
        class rates
        {

            public double findRates(string convertFrom, string convertTo)
            {
                const string get = "https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=d588da9f65ddb54e67c3";
                Console.WriteLine($"DEBUG: Converting {convertFrom} into {convertTo}");
                string url = String.Format(get, convertTo, convertFrom);
                Console.WriteLine($"DEBUG: Using URL {url}");
                string response = new WebClient().DownloadString(url);
                Console.WriteLine($"DEBUG: Response: { response}");
                //var remove = new string[] { "USD_EUR", "EUR_USD", "GBP_USD", "USD_GBP", "GBP_EUR", "EUR_GBP", ":", "{", "}", "\"\"" };

                //  foreach (var c in remove)
                // {
                //     response = response.Replace(c.ToString(), String.Empty);
                //  }

                response = Regex.Match(response, @"[0-9]+(\.[0-9]+)?").Value;

                Console.WriteLine($"DEBUG: Extracted Conversion Rate {response}");
                double final_response = double.Parse(response, System.Globalization.CultureInfo.InvariantCulture);
                return final_response;

            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var currencies = new string[] {"AED", "AFN", "ALL", "AMD", "ANG", "AOA", "ARS", "AUD", "AWG", "AZN", "BAM", "BBD", "BDT", "BGN", "BHD", "BIF", "BMD", "BND", "BOB", "BOV", "BRL", "BSD", "BTN", "BWP", "BYN", "BZD", "CAD", "CDF", "CHE", "CHF", "CHW", "CLF", "CLP", "CNY", "COP", "COU", "CRC", "CUC", "CUP", "CVE", "CZK", "DJF", "DKK", "DOP", "DZD", "EGP", "ERN", "ETB", "EUR", "FJD", "FKP", "GBP", "GEL", "GHS", "GIP", "GMD", "GNF", "GTQ", "GYD", "HKD", "HNL", "HRK", "HTG", "HUF", "IDR", "ILS", "INR", "IQD", "IRR", "ISK", "JMD", "JOD", "JPY", "KES", "KGS", "KHR", "KMF", "KPW", "KRW", "KWD", "KYD", "KZT", "LAK", "LBP", "LKR", "LRD", "LSL", "LYD", "MAD", "MDL", "MGA", "MKD", "MMK", "MNT", "MOP", "MRU", "MUR", "MVR", "MWK", "MXN", "MXV", "MYR", "MZN", "NAD", "NGN", "NIO", "NOK", "NPR", "NZD", "OMR", "PAB", "PEN", "PGK", "PHP", "PKR", "PLN", "PYG", "QAR", "RON", "RSD", "RUB", "RWF", "SAR", "SBD", "SCR", "SDG", "SEK", "SGD", "SHP", "SLL", "SOS", "SRD", "SSP", "STN", "SVC", "SYP", "SZL", "THB", "TJS", "TMT", "TND", "TOP", "TRY", "TTD", "TWD", "TZS", "UAH", "UGX", "USD", "USN", "UYI", "UYU", "UYW", "UZS", "VES", "VND", "VUV", "WST", "XAF", "XCD", "XDR", "XOF", "XPF", "XSU", "XUA", "YER", "ZAR", "ZMW", "ZWL" };
            foreach (var x in currencies) {
                currencyFromBox.Items.Add(x);
                currencyToBox.Items.Add(x);
            
            }


        }

        private void currencyBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void overlay_Click(object sender, EventArgs e)
        {
            overlay.Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
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

        public void convertCurrencies (string currencyFrom, string currencyTo)
        {
            rates getRates = new rates();
            double conversionRate = getRates.findRates(currencyFrom, currencyTo);
            Console.WriteLine($"DEBUG: Received conversion rate from class: {conversionRate}");
            finalResult = Double.Parse(convertText.Text) * conversionRate;
            finalOutput = $"{convertText.Text} {currencyTo} converted into {currencyFrom} equals {finalResult}";
            output.Text = finalOutput;
            roundUp.Visible = true;
            



        }

        public static double performRounding(double input, int decimalPlaces)
        {
            double roundingCalculation = Math.Pow(10, Convert.ToDouble(decimalPlaces));
            return Math.Ceiling(input * roundingCalculation) / roundingCalculation;
        }

        private void roundUp_Click(object sender, EventArgs e)
        {
            rounded = performRounding(finalResult, 2);
            output.Text = $"The converted amount rounded up equals {rounded}";
            roundUp.Visible = false;
            goBack.Visible = true;

        }

        private void convertButton_Click(object sender, EventArgs e)
        {

            if (currencyToBox.Text == currencyFromBox.Text)
            {

                output.Text = "Please select two different currencies.";

            }
            else
            {
                double checkInt;
                bool isNumerical = Double.TryParse(convertText.Text, out checkInt);
                if (isNumerical)
                {
                    goBack.Visible = false;
                    roundUp.Visible = true;
                    Console.WriteLine("DEBUG: Input is Numerical");
                    convertCurrencies(currencyToBox.Text, currencyFromBox.Text);

                }
                else {
                    output.Text = "Your input is not numerical.";
                    Console.WriteLine("DEBUG: Input is Not numberical");
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
            output.Text = finalOutput;
            goBack.Visible = false;
            roundUp.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
