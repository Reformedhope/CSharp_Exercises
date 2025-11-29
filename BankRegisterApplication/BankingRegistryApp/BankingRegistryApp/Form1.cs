/*
 * Programmers: Cameron Rickel, Stephanie Salzburg, Jonquil Terry, Nathan Wenson, David Segura Aba
 * Date: 11/26/25
 * Purpose: The program displays message boxes when the user enters invalid values into any
 *          of the three text boxes displayed. When the user has access to the deposit and
 *          withdraw text boxes, they display the new balance of the bank account. The program 
 *          allows the user to enter their full name, account balance, and initial balance,
 *          then press the create account button. If the values were valid, the user would 
 *          be allowed to enter values for depositing and withdrawing from their
 *          bank account.
 * Class: CITP 180
 * Assignment: Chapter 9 - Programming Exercise 9
 */

using System.Runtime.CompilerServices;

namespace BankingRegistryApp
{
    public partial class BankRegistryForm : Form
    {
        Customer c;

        public BankRegistryForm()
        {
            InitializeComponent();
        }

        //event handler for when create account button is pressed
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string[] nameArr = new string[2];
            int accNo;
            decimal bal;

            //ensures the user enters a valid full name
            if (String.IsNullOrEmpty(txtBxName.Text))
            {
                MessageBox.Show("Please enter your full name");
            }
            else
            {
                nameArr = txtBxName.Text.Split(' ');
                if (nameArr.Length < 2)
                {
                    nameArr[0] = " ";
                    MessageBox.Show("Please enter your full name");
                }
            }

            //ensures the user enters a valid acccount number
            if (String.IsNullOrEmpty(txtBxAccountNumber.Text) || !int.TryParse(txtBxAccountNumber.Text, out accNo))
            {
                accNo = 0;
                MessageBox.Show("Plase enter a valid account number");
            }
            else
            {
                int.TryParse(txtBxAccountNumber.Text, out accNo);
            }

            //ensures the user enter a valid balance
            if (String.IsNullOrEmpty(txtBxInitialBalance.Text) || !decimal.TryParse(txtBxInitialBalance.Text, out bal))
            {
                bal = 0;
                MessageBox.Show("Please enter a valid number for the balance");
            }
            else
            {
                decimal.TryParse(txtBxInitialBalance.Text, out bal);
            }

            //creates the c customer object and makes visible new options for the user
            if (nameArr[0] != " " && accNo != 0 && bal != 0)
            {
                c = new Customer($"{nameArr[0]} {nameArr[1]}", accNo, bal);

                lblDeposit.Visible = true;
                lblWithdraw.Visible = true;
                txtBxDeposit.Visible = true;
                txtBxWithdraw.Visible = true;
                btnUpdateAccount.Visible = true;

                txtbxAccountInfo.Visible = true; // Only show after account creation

                UpdateAccountInfo();
            }
            MessageBox.Show($"Account Created");

        }

        //event handler for when update account button is pressed
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            decimal amount;

            // Deposit
            if (!string.IsNullOrEmpty(txtBxDeposit.Text))
            {
                if (decimal.TryParse(txtBxDeposit.Text, out amount))
                {
                    c.Deposit(amount);
                    txtBxDeposit.Clear();
                    MessageBox.Show($"You deposited ${amount}\nNew balance: ${c.Balance}");
                    UpdateAccountInfo();
                }
                else
                {
                    MessageBox.Show("Invalid deposit amount");
                }
            }

            // Withdraw
            if (!string.IsNullOrEmpty(txtBxWithdraw.Text))
            {
                if (decimal.TryParse(txtBxWithdraw.Text, out amount))
                {
                    if (amount <= c.Balance)
                    {
                        c.Withdraw(amount);
                        txtBxWithdraw.Clear();
                        MessageBox.Show($"You withdrew ${amount}\nNew balance: ${c.Balance}");
                        UpdateAccountInfo();
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient funds to withdraw ${amount}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid withdrawal amount");
                }
            }
        }
        private void UpdateAccountInfo()
        {
            if (c != null)
            {
                txtbxAccountInfo.Text =
                    $"Name: {c.Name}\r\n" +
                    $"Account #: {c.AccountNumber}\r\n" +
                    $"Balance: {c.Balance:C}";


                txtbxAccountInfo.Visible = true;
            }
        }

        private void txtbxAccountInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
