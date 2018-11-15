using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateEggs_Click(object sender, EventArgs e)
        {
            int c1;
            int c2;
            int c3;
            int c4;
            int c5;
            int totalEggs;
            int dozen;
            int eggs;
            c1 = Convert.ToInt32(eggAmount1.Text);
            c2 = Convert.ToInt32(eggAmount2.Text);
            c3 = Convert.ToInt32(eggAmount3.Text);
            c4 = Convert.ToInt32(eggAmount4.Text);
            c5 = Convert.ToInt32(eggAmount5.Text);
            totalEggs = c1 + c2 + c3 + c4 + c5;
            eggs = totalEggs % 12;
            dozen = totalEggs / 12;
            allEggs.Text = totalEggs + " eggs is " + dozen + " dozen with " + eggs + " left over " ;

        }

        private void eggAmount1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
