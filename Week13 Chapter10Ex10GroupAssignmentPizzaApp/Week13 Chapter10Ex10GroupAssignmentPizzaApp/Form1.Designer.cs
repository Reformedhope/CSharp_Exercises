namespace Week13_Chapter10Ex10GroupAssignmentPizzaApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxZip = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtbxCity = new System.Windows.Forms.TextBox();
            this.txtbxBuildingNStreet = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress4 = new System.Windows.Forms.Label();
            this.rdobtnPizzaSizeSm = new System.Windows.Forms.RadioButton();
            this.rdobtnPizzaSizeMd = new System.Windows.Forms.RadioButton();
            this.rdobtnPizzaSizeLg = new System.Windows.Forms.RadioButton();
            this.listbxToppings = new System.Windows.Forms.ListBox();
            this.listbxSauces = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtbxState = new System.Windows.Forms.TextBox();
            this.lblAddress5 = new System.Windows.Forms.Label();
            this.txtbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxZip
            // 
            this.txtbxZip.Location = new System.Drawing.Point(48, 158);
            this.txtbxZip.Name = "txtbxZip";
            this.txtbxZip.Size = new System.Drawing.Size(100, 20);
            this.txtbxZip.TabIndex = 0;
            this.txtbxZip.TextChanged += new System.EventHandler(this.txtbxZip_TextChanged);
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(48, 225);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtbxEmail.TabIndex = 1;
            this.txtbxEmail.TextChanged += new System.EventHandler(this.txtbxEmail_TextChanged);
            // 
            // txtbxCity
            // 
            this.txtbxCity.Location = new System.Drawing.Point(48, 84);
            this.txtbxCity.Name = "txtbxCity";
            this.txtbxCity.Size = new System.Drawing.Size(100, 20);
            this.txtbxCity.TabIndex = 2;
            this.txtbxCity.TextChanged += new System.EventHandler(this.txtbxCity_TextChanged);
            // 
            // txtbxBuildingNStreet
            // 
            this.txtbxBuildingNStreet.Location = new System.Drawing.Point(48, 44);
            this.txtbxBuildingNStreet.Name = "txtbxBuildingNStreet";
            this.txtbxBuildingNStreet.Size = new System.Drawing.Size(100, 20);
            this.txtbxBuildingNStreet.TabIndex = 3;
            this.txtbxBuildingNStreet.TextChanged += new System.EventHandler(this.txtbxBuildingNStreet_TextChanged);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(45, 28);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(109, 13);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Building # and Street ";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(45, 67);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(27, 13);
            this.lblAddress2.TabIndex = 5;
            this.lblAddress2.Text = "City ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(45, 209);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress4
            // 
            this.lblAddress4.AutoSize = true;
            this.lblAddress4.Location = new System.Drawing.Point(45, 142);
            this.lblAddress4.Name = "lblAddress4";
            this.lblAddress4.Size = new System.Drawing.Size(22, 13);
            this.lblAddress4.TabIndex = 7;
            this.lblAddress4.Text = "Zip";
            // 
            // rdobtnPizzaSizeSm
            // 
            this.rdobtnPizzaSizeSm.AutoSize = true;
            this.rdobtnPizzaSizeSm.Location = new System.Drawing.Point(281, 93);
            this.rdobtnPizzaSizeSm.Name = "rdobtnPizzaSizeSm";
            this.rdobtnPizzaSizeSm.Size = new System.Drawing.Size(86, 17);
            this.rdobtnPizzaSizeSm.TabIndex = 8;
            this.rdobtnPizzaSizeSm.TabStop = true;
            this.rdobtnPizzaSizeSm.Text = "Small - $7.99";
            this.rdobtnPizzaSizeSm.UseVisualStyleBackColor = true;
            // 
            // rdobtnPizzaSizeMd
            // 
            this.rdobtnPizzaSizeMd.AutoSize = true;
            this.rdobtnPizzaSizeMd.Location = new System.Drawing.Point(281, 70);
            this.rdobtnPizzaSizeMd.Name = "rdobtnPizzaSizeMd";
            this.rdobtnPizzaSizeMd.Size = new System.Drawing.Size(104, 17);
            this.rdobtnPizzaSizeMd.TabIndex = 9;
            this.rdobtnPizzaSizeMd.TabStop = true;
            this.rdobtnPizzaSizeMd.Text = "Medium - $10.99";
            this.rdobtnPizzaSizeMd.UseVisualStyleBackColor = true;
            // 
            // rdobtnPizzaSizeLg
            // 
            this.rdobtnPizzaSizeLg.AutoSize = true;
            this.rdobtnPizzaSizeLg.Location = new System.Drawing.Point(281, 47);
            this.rdobtnPizzaSizeLg.Name = "rdobtnPizzaSizeLg";
            this.rdobtnPizzaSizeLg.Size = new System.Drawing.Size(94, 17);
            this.rdobtnPizzaSizeLg.TabIndex = 10;
            this.rdobtnPizzaSizeLg.TabStop = true;
            this.rdobtnPizzaSizeLg.Text = "Large - $14.99";
            this.rdobtnPizzaSizeLg.UseVisualStyleBackColor = true;
            // 
            // listbxToppings
            // 
            this.listbxToppings.FormattingEnabled = true;
            this.listbxToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Sausage",
            "Ham",
            "Onion",
            "Mushroom",
            "Olives",
            "Pineapple",
            "Pickles",
            "Green Peppers",
            "Banana Peppers"});
            this.listbxToppings.Location = new System.Drawing.Point(417, 47);
            this.listbxToppings.Name = "listbxToppings";
            this.listbxToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbxToppings.Size = new System.Drawing.Size(120, 95);
            this.listbxToppings.TabIndex = 11;
            this.listbxToppings.SelectedIndexChanged += new System.EventHandler(this.listbxToppings_SelectedIndexChanged);
            // 
            // listbxSauces
            // 
            this.listbxSauces.FormattingEnabled = true;
            this.listbxSauces.Items.AddRange(new object[] {
            "Red sauce",
            "White Sauce",
            "Olive Oil",
            "BBQ Sauce"});
            this.listbxSauces.Location = new System.Drawing.Point(620, 44);
            this.listbxSauces.Name = "listbxSauces";
            this.listbxSauces.Size = new System.Drawing.Size(120, 95);
            this.listbxSauces.TabIndex = 12;
            this.listbxSauces.SelectedIndexChanged += new System.EventHandler(this.listbxSauces_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 110);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pizza Size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(412, 321);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(209, 26);
            this.lblCompanyName.TabIndex = 15;
            this.lblCompanyName.Text = "Spectacular Pizza Co";
            // 
            // txtbxState
            // 
            this.txtbxState.Location = new System.Drawing.Point(48, 119);
            this.txtbxState.Name = "txtbxState";
            this.txtbxState.Size = new System.Drawing.Size(100, 20);
            this.txtbxState.TabIndex = 16;
            this.txtbxState.TextChanged += new System.EventHandler(this.txtbxState_TextChanged);
            // 
            // lblAddress5
            // 
            this.lblAddress5.AutoSize = true;
            this.lblAddress5.Location = new System.Drawing.Point(45, 107);
            this.lblAddress5.Name = "lblAddress5";
            this.lblAddress5.Size = new System.Drawing.Size(32, 13);
            this.lblAddress5.TabIndex = 17;
            this.lblAddress5.Text = "State";
            // 
            // txtbxPhoneNumber
            // 
            this.txtbxPhoneNumber.Location = new System.Drawing.Point(48, 260);
            this.txtbxPhoneNumber.Name = "txtbxPhoneNumber";
            this.txtbxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbxPhoneNumber.TabIndex = 18;
            this.txtbxPhoneNumber.TextChanged += new System.EventHandler(this.txtbxPhoneNumber_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(45, 248);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 19;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Contact Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sauce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Toppings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select Sauce (1 Per Pizza)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Select toppings.\r\nEach pizza comes with 3 toppings any extra is $1.50 each \r\n";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmit.Location = new System.Drawing.Point(375, 248);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 35);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.Location = new System.Drawing.Point(548, 248);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 35);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtbxPhoneNumber);
            this.Controls.Add(this.lblAddress5);
            this.Controls.Add(this.txtbxState);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listbxSauces);
            this.Controls.Add(this.listbxToppings);
            this.Controls.Add(this.rdobtnPizzaSizeLg);
            this.Controls.Add(this.rdobtnPizzaSizeMd);
            this.Controls.Add(this.rdobtnPizzaSizeSm);
            this.Controls.Add(this.lblAddress4);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtbxBuildingNStreet);
            this.Controls.Add(this.txtbxCity);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.txtbxZip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.pictureBox1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxZip;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxCity;
        private System.Windows.Forms.TextBox txtbxBuildingNStreet;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress4;
        private System.Windows.Forms.RadioButton rdobtnPizzaSizeSm;
        private System.Windows.Forms.RadioButton rdobtnPizzaSizeMd;
        private System.Windows.Forms.RadioButton rdobtnPizzaSizeLg;
        private System.Windows.Forms.ListBox listbxToppings;
        private System.Windows.Forms.ListBox listbxSauces;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtbxState;
        private System.Windows.Forms.Label lblAddress5;
        private System.Windows.Forms.TextBox txtbxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}

