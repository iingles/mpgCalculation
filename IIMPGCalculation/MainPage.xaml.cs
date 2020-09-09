//Name: Isaac Ingles
//Class: INFO 1200
//Section: X01
//Professor: Jensen
//Date: 9/8/2020
//Project #: Participation 4
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IIMPGCalculation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        ///    Take the user's input and calculate MPG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            // Double holds a decimal place that is more precise than an integer.
            // Double.parse converts the string value into a double
            double miles = double.Parse(EntryMiles.Text);
            double gallons = double.Parse(EntryGallons.Text);

            // Calculate miles per gallon
            double mpg = miles / gallons;

            // Convert mpg back into a string and display it in the "Results" label
            // "n2" displays it with 2 decimal places
            LblResults.Text = mpg.ToString("n2");
        }
    }
}
