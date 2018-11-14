using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectedRaises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double salary;
            double nextYearsSalary;
            salary = Convert.ToInt32(txtSalary.Text);
            nextYearsSalary = (salary * .04) + salary;
            salaryResult.Text = "" + nextYearsSalary;
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaryResult_Click(object sender, EventArgs e)
        {

        }
    }
}
