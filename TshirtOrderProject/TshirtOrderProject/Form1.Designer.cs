namespace TshirtOrderProject
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
            this.listbxShirts = new System.Windows.Forms.ListBox();
            this.textbxQuantity = new System.Windows.Forms.TextBox();
            this.lblSelectTshirtSize = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDisplayOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbxShirts
            // 
            this.listbxShirts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listbxShirts.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbxShirts.FormattingEnabled = true;
            this.listbxShirts.ItemHeight = 19;
            this.listbxShirts.Items.AddRange(new object[] {
            "XSmall - $20.00",
            "Small  - $16.00",
            "Medium  - $16.00",
            "Large  - $16.00",
            "XL - $16.00",
            "XXL - $20.00"});
            this.listbxShirts.Location = new System.Drawing.Point(217, 89);
            this.listbxShirts.Name = "listbxShirts";
            this.listbxShirts.Size = new System.Drawing.Size(280, 213);
            this.listbxShirts.TabIndex = 0;
            // 
            // textbxQuantity
            // 
            this.textbxQuantity.Location = new System.Drawing.Point(549, 177);
            this.textbxQuantity.Name = "textbxQuantity";
            this.textbxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textbxQuantity.TabIndex = 1;
            // 
            // lblSelectTshirtSize
            // 
            this.lblSelectTshirtSize.AutoSize = true;
            this.lblSelectTshirtSize.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTshirtSize.Location = new System.Drawing.Point(294, 64);
            this.lblSelectTshirtSize.Name = "lblSelectTshirtSize";
            this.lblSelectTshirtSize.Size = new System.Drawing.Size(135, 22);
            this.lblSelectTshirtSize.TabIndex = 2;
            this.lblSelectTshirtSize.Text = "Select shirt size";
            this.lblSelectTshirtSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(614, 224);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(92, 37);
            this.btnClearCart.TabIndex = 3;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(503, 224);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(92, 37);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(525, 155);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(146, 19);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity(Per Size)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripMenu
            // 
            this.stripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuIOrder,
            this.toolStripMenuDisplayOrder,
            this.toolStripMenuExit,
            this.toolStripMenuHelp});
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Size = new System.Drawing.Size(50, 20);
            this.stripMenu.Text = "Menu";
            // 
            // toolStripMenuIOrder
            // 
            this.toolStripMenuIOrder.Name = "toolStripMenuIOrder";
            this.toolStripMenuIOrder.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuIOrder.Text = "Order";
            this.toolStripMenuIOrder.Click += new System.EventHandler(this.toolStripMenuIOrder_Click);
            // 
            // toolStripMenuDisplayOrder
            // 
            this.toolStripMenuDisplayOrder.Name = "toolStripMenuDisplayOrder";
            this.toolStripMenuDisplayOrder.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuDisplayOrder.Text = "Display Order";
            this.toolStripMenuDisplayOrder.Click += new System.EventHandler(this.toolStripMenuDisplayOrder_Click);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // toolStripMenuHelp
            // 
            this.toolStripMenuHelp.Name = "toolStripMenuHelp";
            this.toolStripMenuHelp.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuHelp.Text = "Help";
            this.toolStripMenuHelp.Click += new System.EventHandler(this.toolStripMenuHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.lblSelectTshirtSize);
            this.Controls.Add(this.textbxQuantity);
            this.Controls.Add(this.listbxShirts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbxShirts;
        private System.Windows.Forms.TextBox textbxQuantity;
        private System.Windows.Forms.Label lblSelectTshirtSize;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDisplayOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelp;
    }
}

