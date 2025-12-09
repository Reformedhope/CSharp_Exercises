namespace TshirtOrderProject
{
    partial class OrderSummary
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
            this.listvwOrdersummary = new System.Windows.Forms.ListView();
            this.clmnhderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhdrQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhdrTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSummaryCheckout = new System.Windows.Forms.Button();
            this.btnSummaryClearCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listvwOrdersummary
            // 
            this.listvwOrdersummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnhderSize,
            this.clmnhdrQuantity,
            this.clmnhderPrice,
            this.clmnhdrTotal});
            this.listvwOrdersummary.HideSelection = false;
            this.listvwOrdersummary.Location = new System.Drawing.Point(169, 86);
            this.listvwOrdersummary.Name = "listvwOrdersummary";
            this.listvwOrdersummary.Size = new System.Drawing.Size(496, 262);
            this.listvwOrdersummary.TabIndex = 0;
            this.listvwOrdersummary.UseCompatibleStateImageBehavior = false;
            this.listvwOrdersummary.View = System.Windows.Forms.View.Details;
            // 
            // clmnhderSize
            // 
            this.clmnhderSize.Text = "Size";
            // 
            // clmnhdrQuantity
            // 
            this.clmnhdrQuantity.Text = "Quantity";
            this.clmnhdrQuantity.Width = 148;
            // 
            // clmnhderPrice
            // 
            this.clmnhderPrice.Text = "Price";
            this.clmnhderPrice.Width = 111;
            // 
            // clmnhdrTotal
            // 
            this.clmnhdrTotal.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Summary";
            // 
            // btnSummaryCheckout
            // 
            this.btnSummaryCheckout.Location = new System.Drawing.Point(219, 365);
            this.btnSummaryCheckout.Name = "btnSummaryCheckout";
            this.btnSummaryCheckout.Size = new System.Drawing.Size(109, 46);
            this.btnSummaryCheckout.TabIndex = 2;
            this.btnSummaryCheckout.Text = "Checkout";
            this.btnSummaryCheckout.UseVisualStyleBackColor = true;
            this.btnSummaryCheckout.Click += new System.EventHandler(this.btnSummaryCheckout_Click);
            // 
            // btnSummaryClearCart
            // 
            this.btnSummaryClearCart.Location = new System.Drawing.Point(385, 365);
            this.btnSummaryClearCart.Name = "btnSummaryClearCart";
            this.btnSummaryClearCart.Size = new System.Drawing.Size(129, 46);
            this.btnSummaryClearCart.TabIndex = 3;
            this.btnSummaryClearCart.Text = "Clear Cart ";
            this.btnSummaryClearCart.UseVisualStyleBackColor = true;
            this.btnSummaryClearCart.Click += new System.EventHandler(this.btnSummaryClearCart_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSummaryClearCart);
            this.Controls.Add(this.btnSummaryCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listvwOrdersummary);
            this.Name = "OrderSummary";
            this.Text = "form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listvwOrdersummary;
        private System.Windows.Forms.ColumnHeader clmnhderSize;
        private System.Windows.Forms.ColumnHeader clmnhdrQuantity;
        private System.Windows.Forms.ColumnHeader clmnhderPrice;
        private System.Windows.Forms.ColumnHeader clmnhdrTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSummaryCheckout;
        private System.Windows.Forms.Button btnSummaryClearCart;
    }
}