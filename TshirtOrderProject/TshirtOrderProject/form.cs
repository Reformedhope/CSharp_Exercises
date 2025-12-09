using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TshirtOrderProject
{
    public partial class OrderSummary : Form
    {
        public List<string> _orders;

        public OrderSummary(List<string> orders)
        {
            InitializeComponent();
            _orders = orders;
            LoadList();
        }
        // Allows for checkout button and give direction based on button click and error handling.
        private void btnSummaryCheckout_Click(object sender, EventArgs e)
        {
            if (_orders.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please put something in your cart first");
                return;
            }

            MessageBox.Show("Thank you for your purchase! Come visit us Again!");
            _orders.Clear();
            listvwOrdersummary.Items.Clear();
            this.Close();
        }
        //loops through the list to get the order and displays it nicely.
        private void LoadList()
        {
            listvwOrdersummary.Items.Clear();

            foreach (string order in _orders)
            {
                string[] parts = order.Split(new string[] { " x ", " = $" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    string size = parts[0];
                    string quantityStr = parts[1];
                    string priceStr = parts[2];

                    if (!int.TryParse(quantityStr, out int quantity))
                        quantity = 0;

                    if (!double.TryParse(priceStr, out double pricePerShirt))
                        pricePerShirt = 0;

                    double lineTotal = quantity * pricePerShirt;

                    ListViewItem item = new ListViewItem(size);
                    item.SubItems.Add(quantity.ToString());
                    item.SubItems.Add($"${pricePerShirt:0.00}");
                    item.SubItems.Add($"${lineTotal:0.00}");
                    listvwOrdersummary.Items.Add(item);
                }
            }
        }
        // Clears the order on the summary page
        private void btnSummaryClearCart_Click(object sender, EventArgs e)
        {
            if (_orders.Count == 0)
            {
                MessageBox.Show("Cart is already empty. Return to order to make a new order.");
                return;
            }

            _orders.Clear();
            listvwOrdersummary.Items.Clear();
        }
    }
}
