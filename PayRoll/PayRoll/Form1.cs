using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string userName;
            int socialSecurity;
            double hourlyPayRate;
            double totalHoursWorked;
            double grossPay;
            double federalWithholdingTax;
            double stateWithholdingTax;
            double netPay;
            double totalTaxes;

            userName = (enterName.Text);
            socialSecurity = Convert.ToInt32(enterSocialSecurity.Text);
            hourlyPayRate = Convert.ToDouble(enterHourlyPay.Text);
            totalHoursWorked = Convert.ToInt32(enterHoursWorked.Text);

            grossPay = hourlyPayRate * totalHoursWorked;
            federalWithholdingTax = grossPay * .15;
            stateWithholdingTax = grossPay * .05;
            totalTaxes = federalWithholdingTax + stateWithholdingTax;
            netPay = grossPay - totalTaxes;

            result.Text = "Name: " + userName + "  SSN: " + socialSecurity + "  Hourly Pay Rate: " + hourlyPayRate +
                "  Number of Housr Worked: " + totalHoursWorked + "  Gross Pay: " + grossPay +
                "  Federal Withholding Tax: " + federalWithholdingTax + "  State Withholding Tax: " +
                stateWithholdingTax + "  Net Pay: " + netPay;
        }
    }
}
