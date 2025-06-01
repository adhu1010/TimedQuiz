using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TimedQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int add1;
        int add2;
        int minus1;
        int minus2;
        int multiplier1;
        int multiplier2;
        int divisor;
        int divident;
        int timeleft;

        public void StartTheQuiz()
        {
            add1 = randomizer.Next(51);
            add2 = randomizer.Next(51);
            plusLeftLabel.Text = add1.ToString();
            plusRightLabel.Text = add2.ToString();
            sum.Value = 0;

            minus1 = randomizer.Next(1, 101);
            minus2 = randomizer.Next(1, minus1);
            minusLeftLabel.Text = minus1.ToString();
            minusRightLabel.Text = minus2.ToString();
            difference.Value = 0;

            multiplier1 = randomizer.Next(2, 11);
            multiplier2 = randomizer.Next(2, 11);
            productLeftLabel.Text = multiplier1.ToString();
            productRightLabel.Text = multiplier2.ToString();
            product.Value = 0;

            divisor = randomizer.Next(2, 11);
            int tempQuiotent = randomizer.Next(2, 11);
            divident = divisor * tempQuiotent;
            divisionLeftLabel.Text = divident.ToString();
            divisonRightLabel.Text = divisor.ToString();
            division.Value = 0;

            timeleft = 30;
            timelabel.Text = "30 seconds";



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
            timer1.Start();

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }
        private bool CheckTheAnswer()
        {   
            if ((add1 + add2 == sum.Value)
                && (minus1 - minus2 == difference.Value)
                && (multiplier1 * multiplier2 == product.Value)
                && (divident / divisor == division.Value))
                return true;
            else
                return false;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            if (CheckTheAnswer())
            {

                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeleft > 0)
            {

                timeleft = timeleft - 1;
                timelabel.Text = timeleft + " seconds";
            }
            else
            {

                timer1.Stop();
                timelabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = add1 + add2;
                difference.Value = minus1 - minus2;
                product.Value = multiplier1 * multiplier2;
                division.Value = divident / divisor;
                startButton.Enabled = true;
            }

        }


        private void sum_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
