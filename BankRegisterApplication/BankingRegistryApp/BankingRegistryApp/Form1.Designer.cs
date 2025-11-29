namespace BankingRegistryApp
{
    partial class BankRegistryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblAccountNumber = new Label();
            lblInitialBalance = new Label();
            lblDeposit = new Label();
            lblWithdraw = new Label();
            txtBxName = new TextBox();
            txtBxAccountNumber = new TextBox();
            txtBxInitialBalance = new TextBox();
            txtBxDeposit = new TextBox();
            txtBxWithdraw = new TextBox();
            btnCreateAccount = new Button();
            btnUpdateAccount = new Button();
            txtbxAccountInfo = new TextBox();
            lblacctInfo = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(192, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Banking Registry";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(297, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAccountNumber.ForeColor = Color.White;
            lblAccountNumber.Location = new Point(218, 117);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(127, 19);
            lblAccountNumber.TabIndex = 2;
            lblAccountNumber.Text = "Account Number:";
            // 
            // lblInitialBalance
            // 
            lblInitialBalance.AutoSize = true;
            lblInitialBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblInitialBalance.ForeColor = Color.White;
            lblInitialBalance.Location = new Point(240, 149);
            lblInitialBalance.Name = "lblInitialBalance";
            lblInitialBalance.Size = new Size(106, 19);
            lblInitialBalance.TabIndex = 3;
            lblInitialBalance.Text = "Initial Balance:";
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDeposit.ForeColor = Color.White;
            lblDeposit.Location = new Point(242, 203);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(60, 19);
            lblDeposit.TabIndex = 4;
            lblDeposit.Text = "Deposit";
            lblDeposit.Visible = false;
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblWithdraw.ForeColor = Color.White;
            lblWithdraw.Location = new Point(386, 203);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(74, 19);
            lblWithdraw.TabIndex = 5;
            lblWithdraw.Text = "Withdraw";
            lblWithdraw.Visible = false;
            // 
            // txtBxName
            // 
            txtBxName.Font = new Font("Segoe UI", 10.2F);
            txtBxName.Location = new Point(373, 84);
            txtBxName.Margin = new Padding(3, 2, 3, 2);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(110, 26);
            txtBxName.TabIndex = 6;
            // 
            // txtBxAccountNumber
            // 
            txtBxAccountNumber.Font = new Font("Segoe UI", 10.2F);
            txtBxAccountNumber.Location = new Point(373, 114);
            txtBxAccountNumber.Margin = new Padding(3, 2, 3, 2);
            txtBxAccountNumber.Name = "txtBxAccountNumber";
            txtBxAccountNumber.Size = new Size(110, 26);
            txtBxAccountNumber.TabIndex = 7;
            // 
            // txtBxInitialBalance
            // 
            txtBxInitialBalance.Font = new Font("Segoe UI", 10.2F);
            txtBxInitialBalance.Location = new Point(373, 146);
            txtBxInitialBalance.Margin = new Padding(3, 2, 3, 2);
            txtBxInitialBalance.Name = "txtBxInitialBalance";
            txtBxInitialBalance.Size = new Size(110, 26);
            txtBxInitialBalance.TabIndex = 8;
            // 
            // txtBxDeposit
            // 
            txtBxDeposit.Font = new Font("Segoe UI", 10.2F);
            txtBxDeposit.Location = new Point(220, 223);
            txtBxDeposit.Margin = new Padding(3, 2, 3, 2);
            txtBxDeposit.Name = "txtBxDeposit";
            txtBxDeposit.Size = new Size(110, 26);
            txtBxDeposit.TabIndex = 9;
            txtBxDeposit.Visible = false;
            // 
            // txtBxWithdraw
            // 
            txtBxWithdraw.Font = new Font("Segoe UI", 10.2F);
            txtBxWithdraw.Location = new Point(371, 223);
            txtBxWithdraw.Margin = new Padding(3, 2, 3, 2);
            txtBxWithdraw.Name = "txtBxWithdraw";
            txtBxWithdraw.Size = new Size(110, 26);
            txtBxWithdraw.TabIndex = 10;
            txtBxWithdraw.Visible = false;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.OrangeRed;
            btnCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(10, 274);
            btnCreateAccount.Margin = new Padding(3, 2, 3, 2);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(122, 54);
            btnCreateAccount.TabIndex = 11;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = Color.OrangeRed;
            btnUpdateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.Location = new Point(568, 274);
            btnUpdateAccount.Margin = new Padding(3, 2, 3, 2);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(122, 54);
            btnUpdateAccount.TabIndex = 12;
            btnUpdateAccount.Text = "Update Account";
            btnUpdateAccount.UseVisualStyleBackColor = false;
            btnUpdateAccount.Visible = false;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // txtbxAccountInfo
            // 
            txtbxAccountInfo.Location = new Point(28, 83);
            txtbxAccountInfo.Multiline = true;
            txtbxAccountInfo.Name = "txtbxAccountInfo";
            txtbxAccountInfo.ReadOnly = true;
            txtbxAccountInfo.ScrollBars = ScrollBars.Vertical;
            txtbxAccountInfo.Size = new Size(162, 89);
            txtbxAccountInfo.TabIndex = 13;
            txtbxAccountInfo.Visible = false;
            txtbxAccountInfo.TextChanged += txtbxAccountInfo_TextChanged;
            // 
            // lblacctInfo
            // 
            lblacctInfo.AutoSize = true;
            lblacctInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblacctInfo.Location = new Point(28, 59);
            lblacctInfo.Name = "lblacctInfo";
            lblacctInfo.Size = new Size(169, 21);
            lblacctInfo.TabIndex = 14;
            lblacctInfo.Text = "Account Information";
            lblacctInfo.Visible = false;
            lblacctInfo.Click += label1_Click;
            // 
            // BankRegistryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(700, 338);
            Controls.Add(lblacctInfo);
            Controls.Add(txtbxAccountInfo);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtBxWithdraw);
            Controls.Add(txtBxDeposit);
            Controls.Add(txtBxInitialBalance);
            Controls.Add(txtBxAccountNumber);
            Controls.Add(txtBxName);
            Controls.Add(lblWithdraw);
            Controls.Add(lblDeposit);
            Controls.Add(lblInitialBalance);
            Controls.Add(lblAccountNumber);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BankRegistryForm";
            Text = "Bank Registry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblAccountNumber;
        private Label lblInitialBalance;
        private Label lblDeposit;
        private Label lblWithdraw;
        private TextBox txtBxName;
        private TextBox txtBxAccountNumber;
        private TextBox txtBxInitialBalance;
        private TextBox txtBxDeposit;
        private TextBox txtBxWithdraw;
        private Button btnCreateAccount;
        private Button btnUpdateAccount;
        private TextBox txtbxAccountInfo;
        private Label lblacctInfo;
    }
}
