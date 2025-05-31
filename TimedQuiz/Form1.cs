using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int add1 ;
        int add2 ;
        int minus1;
        int minus2;
        int multiplier1;
        int multiplier2 ;
        int divisor;
        int divident;
        int timeleft;

        public void StartTheQuiz()
        {
            add1=randomizer.Next(51);
            add2 = randomizer.Next(51);
            plusLeftLabel.Text = add1.ToString();
            plusRightLabel.Text = add2.ToString();
            sum.Value = 0;

            minus1 = randomizer.Next(1,101);
            minus2 = randomizer.Next(1,minus1);
            minusLeftLabel.Text =minus1.ToString();
            minusRightLabel.Text = minus2.ToString();
            difference.Value = 0;

            multiplier1 = randomizer.Next(2,11);
            multiplier1 = randomizer.Next(2,11);
            productLeftLabel.Text =multiplier1.ToString();
            productRightLabel.Text =multiplier2.ToString();
            product.Value = 0;

            divisor = randomizer.Next(2,11);
            int tempQuiotent=randomizer.Next(2,11);
            divident = divisor * tempQuiotent;
            divisionLeftLabel.Text = divisor.ToString();
            divisonRightLabel.Text = divident.ToString();
            division.Value = 0;


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

        }
    }
}
