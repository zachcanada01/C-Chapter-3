using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void milesPrompt_Click(object sender, EventArgs e)
        {

        }

        private void calculatePrice_Click(object sender, EventArgs e)
        {
            double daysChoice;
            double milesChoice;
            double pricePerDay = 20;
            double pricePerMile = .25;
            double totalCost;
            double milesCost;
            double daysCost;
            daysChoice = Convert.ToInt32(days.Text);
            milesChoice = Convert.ToInt32(miles.Text);
            milesCost = milesChoice * pricePerMile;
            daysCost = daysChoice * pricePerDay;
            totalCost = milesCost + daysCost,;

            price.Text = "$"  + totalCost; 

        }

        private void days_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }
    }
}
