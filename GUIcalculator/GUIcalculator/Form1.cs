using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            sum = num1 + num2;
            lblResult.Text = "The sum is " + sum;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sub;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            sub = num1 - num2;
            lblSubtract.Text = "" + sub;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double div;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            div = num1 / num2;
            lblDivide.Text = "" + div;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int multiply;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            multiply = num1 * num2;
            lblMultiply.Text = "" + multiply;

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            double mod;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            mod = num1 % num2;
            lblMod.Text = "" + mod;
        }
    }
}
