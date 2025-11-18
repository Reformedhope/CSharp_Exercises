namespace PracticeFormApp
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
            this.btnclickthis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclickthis
            // 
            this.btnclickthis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclickthis.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnclickthis.Location = new System.Drawing.Point(309, 164);
            this.btnclickthis.Name = "btnclickthis";
            this.btnclickthis.Size = new System.Drawing.Size(75, 23);
            this.btnclickthis.TabIndex = 0;
            this.btnclickthis.Text = "Click this\r\n";
            this.btnclickthis.UseVisualStyleBackColor = true;
            this.btnclickthis.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(306, 148);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(69, 13);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "lblHelloWorld";
            this.lblHelloWorld.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnclickthis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclickthis;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

