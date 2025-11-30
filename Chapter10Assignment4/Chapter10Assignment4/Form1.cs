using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///* 
// * Programmer: Stephanie Salzburg
// * Date: 11/30/2025
// * Purpose:This application allows you to load a window select a community group. Pops up a message and displays an image depending on the selected. 
// * Class: CITP 180
// * Assignment: Chapter 10 - Programming Excercise 4
// * /

namespace Chapter10Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdobtnFootball.Checked = false;
            rdobtnTennis.Checked = false;
            rdobtnGolf.Checked = false;
            rdobtnTrack.Checked = false;
            rdobtnVolleyBall.Checked = false;

            picbx.Image = null;
        }

        private void rdobtnFootball_CheckedChanged(object sender, EventArgs e)
        {
            SelectingGroup();
        }

        private void rdobtnTennis_CheckedChanged(object sender, EventArgs e)
        {
            SelectingGroup();
        }

        private void rdobtnGolf_CheckedChanged(object sender, EventArgs e)
        {
            SelectingGroup();
        }

        private void rdobtnTrack_CheckedChanged(object sender, EventArgs e)
        {
            SelectingGroup();

        }

        private void rdobtnVolleyBall_CheckedChanged(object sender, EventArgs e)
        {
            SelectingGroup();
        }

        public void SelectingGroup()
        {
            if (rdobtnFootball.Checked)
            {
                picbx.Image = Image.FromFile(@"C:\Users\Steph\OneDrive\Desktop\School Projects\CSharpProjects\Chapter10Assignment4\Chapter10Assignment4\Images\football.jpg");
                MessageBox.Show("You might want to invest in some good padding!");

            }
            else if (rdobtnTennis.Checked)
            {
                picbx.Image = Image.FromFile(@"C:\Users\Steph\OneDrive\Desktop\School Projects\CSharpProjects\Chapter10Assignment4\Chapter10Assignment4\Images\tennis.jpg");
                MessageBox.Show("The court is a battle field and a play ground!");

            }
            else if (rdobtnVolleyBall.Checked)
            {
                picbx.Image = Image.FromFile(@"C:\Users\Steph\OneDrive\Desktop\School Projects\CSharpProjects\Chapter10Assignment4\Chapter10Assignment4\Images\volleyball.jpg");
                MessageBox.Show("When in doubt SPIKE!");

            }
            else if (rdobtnTrack.Checked)
            {
                picbx.Image = Image.FromFile(@"C:\Users\Steph\OneDrive\Desktop\School Projects\CSharpProjects\Chapter10Assignment4\Chapter10Assignment4\Images\track.jpg");
                MessageBox.Show("Run Run Run as fast as you can!");

            }
            else if (rdobtnGolf.Checked)
            {
                picbx.Image = Image.FromFile(@"C:\Users\Steph\OneDrive\Desktop\School Projects\CSharpProjects\Chapter10Assignment4\Chapter10Assignment4\Images\golf.jpg");
                MessageBox.Show("FOUR!");

            }
            else
            {
                MessageBox.Show("You didnt click a correct option! Try again");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
