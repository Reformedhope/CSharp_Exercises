using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Programmers: Cameron Rickel, Stephanie Salzburg, Jonquil Terry, Nathan Wenson, David Segura Aba
 * Date: 12/7/2025
 * Purpose:This app lets the user enter their contact info and place a pizza order. It checks for empty 
 *      or invalid fields, validates input like ZIP codes, email, and phone numbers, 
 *      and formats the information nicely. Users can select pizza size, toppings, and sauces, 
 *      and the app calculates extra costs when needed. It also shows a full order summary and allows the user to reset the form at anytime.
 * Class: CITP 180
 * Assignment: Chapter 10 - Programming Exercise 10
 */

namespace Week13_Chapter10Ex10GroupAssignmentPizzaApp
{
    public partial class Form1 : Form
    {
        string[] orderArray = new string[6];
        double[] PizzaSize = new double[1];
        string[] selectedToppings;
        string[] sauceArray = new string[1];

        public Form1()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbxBuildingNStreet_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtbxCity_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtbxState_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
        //passes all the information into the button click checking if anything was left empty.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateContactInfo()) return;
            StoreContactInfo();

            double pizzaPrice = GetPizzaSize();
            if (pizzaPrice == 0) return;

            string sauce = GetSauceSelection();
            if (sauce == null) return;

            double toppingsCost = CalculateToppingsCost();
            double totalPrice = pizzaPrice + toppingsCost;

            BuildFullOrder(totalPrice, pizzaPrice, toppingsCost, sauce);
        }
        //validates the information to make sure the user inputs something into each box. 
        private bool ValidateContactInfo()
        {
            if (string.IsNullOrWhiteSpace(txtbxBuildingNStreet.Text))
            {
                MessageBox.Show("Please enter your building number and street.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbxCity.Text))
            {
                MessageBox.Show("Please enter your city.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbxState.Text))
            {
                MessageBox.Show("Please enter your state.");
                return false;
            }

            if (!int.TryParse(txtbxZip.Text, out int zip) || txtbxZip.Text.Length != 5)
            {
                MessageBox.Show("Please enter a valid 5-digit ZIP code.");
                return false;
            }

            string email = txtbxEmail.Text;
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            string phone = txtbxPhoneNumber.Text.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "");
            if (!long.TryParse(phone, out _) || phone.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return false;
            }

            return true;
        }
        //stores each peice of the contact information into the array
        private void StoreContactInfo()
        {
            orderArray[0] = txtbxBuildingNStreet.Text;
            orderArray[1] = txtbxCity.Text;
            orderArray[2] = txtbxState.Text;
            orderArray[3] = txtbxZip.Text;
            orderArray[4] = txtbxEmail.Text;
            orderArray[5] = txtbxPhoneNumber.Text;
        }


        //loops through the contact information and then stores it all in contact information 
        public void Orderinformation()
        {
            string contactInformation = "";

            foreach (string item in orderArray)
            {
                contactInformation += item + "\n";
            }

            MessageBox.Show("Order Details", contactInformation);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            txtbxBuildingNStreet.Clear();
            txtbxCity.Clear();
            txtbxState.Clear();
            txtbxZip.Clear();
            txtbxEmail.Clear();
            txtbxPhoneNumber.Clear();

            // Clear radio buttons
            rdobtnPizzaSizeLg.Checked = false;
            rdobtnPizzaSizeMd.Checked = false;
            rdobtnPizzaSizeSm.Checked = false;

            //clear lists 
            listbxToppings.ClearSelected();
            listbxSauces.ClearSelected();

            //reset the arrays
            PizzaSize[0] = 0;
            selectedToppings = null;
            sauceArray[0] = null;
        }

        private double GetPizzaSize()
        {
            if (rdobtnPizzaSizeLg.Checked)
                return 14.99;
            if (rdobtnPizzaSizeMd.Checked)
                return 12.99;
            if (rdobtnPizzaSizeSm.Checked)
                return 9.99;

            MessageBox.Show("Please select a pizza size.");
            return 0;
        }
        private string GetSauceSelection()
        {
            if (sauceArray[0] != null) return sauceArray[0];

            MessageBox.Show("Please select a sauce.");
            return null;
        }
        //calculates the total cost of all the toppings since only 3 are free and everything else is 1.50
        private double CalculateToppingsCost()
        {
            if (selectedToppings == null || selectedToppings.Length == 0) return 0;

            int extraToppings = selectedToppings.Length - 3;
            if (extraToppings < 0)
            {
                extraToppings = 0;
            }
            else
            {
                MessageBox.Show("")
            }

                return extraToppings * 1.50;
        }
        //builds the full order taking the address information email, and phone the pizza price the sauce and toppings and displaying all the toppings. used \n to help break up the crazyness of styling. 
        private void BuildFullOrder(double totalPrice, double pizzaPrice, double toppingsCost, string sauce)
        {
            string summary = "---- Order Summary ----\n\n";
            Console.WriteLine("______________________");
            summary += $"Address: {orderArray[0]}, {orderArray[1]}, {orderArray[2]}, {orderArray[3]}\n";
            summary += $"Email: {orderArray[4]}\nPhone: {orderArray[5]}\n\n";
            summary += $"Pizza Size: ${pizzaPrice:0.00}\n";
            summary += $"Sauce: {sauce}\n";
            summary += "Toppings: ";
            if (selectedToppings != null && selectedToppings.Length > 0)
                summary += string.Join(", ", selectedToppings);
            else
                summary += "None";
            summary += $"\nToppings Extra Cost: ${toppingsCost:0.00}";
            summary += $"\n\nTotal Price: ${totalPrice:0.00}";

            MessageBox.Show(summary, "Order Details");
        }
        //checks the topings and storing it in another array coping it to the selected toping array at index 0 
        private void listbxToppings_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedToppings = new string[listbxToppings.SelectedItems.Count];
            listbxToppings.SelectedItems.CopyTo(selectedToppings, 0);
        }
        //checks to see if the sauce was selected and converts it using the Tostring method
        private void listbxSauces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxSauces.SelectedItem != null)
                sauceArray[0] = listbxSauces.SelectedItem.ToString();
        }
        //displays the pixture and stretches the image to fit the box
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Food5Pizzas; // added the image to the resources instead of a direct file path
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;// stretches the image to show the entire image. 

        }

    }
}
