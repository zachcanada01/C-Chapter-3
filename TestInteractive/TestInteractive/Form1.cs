using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInteractive
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

        private void averageTestScore_Click(object sender, EventArgs e)
        {
            
        }

        private void calculateAverage_Click(object sender, EventArgs e)
        {
            double score1;
            double score2;
            double score3;
            double score4;
            double score5;
            double totalScore;
            double averageScore;

            score1 = Convert.ToInt32(answer1.Text);
            score2 = Convert.ToInt32(answer2.Text);
            score3 = Convert.ToInt32(answer3.Text);
            score4 = Convert.ToInt32(answer4.Text);
            score5 = Convert.ToInt32(answer5.Text);
            totalScore = score1 + score2 + score3 + score4 + score5;
            averageScore = totalScore / 5;
            

            averageTestScore.Text = "" + averageScore ;
        }
    }
}
