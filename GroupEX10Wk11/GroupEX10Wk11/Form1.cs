using System;

using System.Drawing;

using System.Windows.Forms;

/*
 * Programmers: Cameron Rickel, Stephanie Salzburg, Jonquil Terry, Nathan Wenson, David Segura Aba
 * Date: 11/19/25
 * Purpose: The purpose of this application is to be anumber guessing game. 
 * The user enters a number and the background changes color based on if the number is too high or too low. 
 * Class : CITP 180
 * Assignment: Chapter 9 - Programming Exercise 10
 */

namespace GroupEX10Wk11
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int target;
        int numberEntered;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            target = random.Next(0, 101);
            this.AcceptButton = btnSubmitNumber;
            this.CancelButton = btnReset;
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnSubmitNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumberBox.Text) ||
                !int.TryParse(txtNumberBox.Text, out numberEntered))
            {
                MessageBox.Show("Invalid value");
                this.BackColor = Color.Orange;
                return;
            }
            if (numberEntered == target)
            {

                this.BackColor = Color.Green;
                MessageBox.Show("You got it!");
            }
            else if (numberEntered > target)
            {
                //MessageBox.Show("Too High! Try again!");
                this.BackColor = Color.Red;
            }
            else
            {
                //MessageBox.Show("Too Low! Try again!");
                this.BackColor = Color.Blue;
            }
            if (numberEntered != target)
            {
                counter++;
                lblAttempts.Text = $"Number Attempts:{counter}";

            }
            txtNumberBox.Clear();

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumberBox.Clear();
            this.BackColor = Color.White;
            counter = 0;
            lblAttempts.Text = $"Number Attempts:{counter}";
            target = random.Next(0, 101);
        }
    }
}
