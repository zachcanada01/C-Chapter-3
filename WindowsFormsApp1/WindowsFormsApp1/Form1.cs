using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LastYearsComp : Form
    {
        public LastYearsComp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kilometersResult_Click(object sender, EventArgs e)
        {
            
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double userChoice;
            double milesInKilometer = 1.6;
            double kilometers;
            userChoice = Convert.ToInt32(txtMiles.Text);
            kilometers = milesInKilometer * userChoice;
            kilometersResult.Text = "" + kilometers;
        }
    }
}
