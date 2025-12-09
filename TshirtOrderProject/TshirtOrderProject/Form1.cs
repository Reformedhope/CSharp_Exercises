using System;
using System.Collections.Generic;
using System.Windows.Forms;

///* 
// * Programmer: Stephanie Salzburg
// * Date: 12/8/2025
// * Purpose: A Program that allows you to make a tshirt order. This application has multiple pages to visit for the summary as well as for help. The Application
// has proper error handling and messages to direct the user to where they need to go next.  It displays the order summary in a organized column list. 
// * Class: CITP 180
// * Assignment: Chapter 10 - Programming Excercise 2 & 8
// * /

namespace TshirtOrderProject
{
    public partial class Form1 : Form
    {
        private List<string> TshirtOrder = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AddToCart()
        {
            if (listbxShirts.SelectedItem == null)
            {
                MessageBox.Show("Please select a T-shirt size.");
                return;
            }

            if (!int.TryParse(textbxQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string size = listbxShirts.SelectedItem.ToString();
            double pricePerShirt = TshirtPrice(size);
            double lineTotal = pricePerShirt * quantity;

            string order = $"{size} x {quantity} = ${lineTotal:0.00}";
            TshirtOrder.Add(order);

            // Clear input for next quantity entered so the user doesnt have too.
            textbxQuantity.Clear();
            listbxShirts.ClearSelected();

            MessageBox.Show("Item added to cart!");
        }

        private double TshirtPrice(string size)
        {
            if (size.Contains("XSmall") || size.Contains("XXL"))
                return 20.00;
            else
                return 16.00;
        }


        private void ClearCart()
        {
            TshirtOrder.Clear();
            textbxQuantity.Clear();
            listbxShirts.ClearSelected();
            MessageBox.Show("All orders have been cleared.");
        }

        private void DisplayOrder()
        {
            if (TshirtOrder.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            OrderSummary summaryForm = new OrderSummary(TshirtOrder); //passes the newly created list
            summaryForm.ShowDialog(); // Opens the summary form
        }


        private void toolStripMenuIOrder_Click(object sender, EventArgs e)
        {
            //show the contents of the ordering form
            listbxShirts.Visible = true;
            textbxQuantity.Visible = true;
            btnAddToCart.Visible = true;
            btnClearCart.Visible = true;
            lblSelectTshirtSize.Visible = true;
            lblQuantity.Visible = true;
        }

        private void toolStripMenuDisplayOrder_Click(object sender, EventArgs e)
        {
            // Hide order controls when user clicks to go to the summary if there is no order.
            listbxShirts.Visible = false;
            textbxQuantity.Visible = false;
            btnAddToCart.Visible = false;
            btnClearCart.Visible = false;
            lblQuantity.Visible = false;
            lblSelectTshirtSize.Visible = false;

            DisplayOrder(); // calls the display order which passes the information to display on the summary screen. 

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart();
        }


        private void btnClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void toolStripMenuHelp_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help();
            helpForm.ShowDialog(); //Opens the help form
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // closes the entire app
        }
    }
}
