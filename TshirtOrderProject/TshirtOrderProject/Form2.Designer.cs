namespace TshirtOrderProject
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblHelpInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelpInformation
            // 
            this.lblHelpInformation.AutoSize = true;
            this.lblHelpInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpInformation.Location = new System.Drawing.Point(33, 144);
            this.lblHelpInformation.Name = "lblHelpInformation";
            this.lblHelpInformation.Size = new System.Drawing.Size(755, 100);
            this.lblHelpInformation.TabIndex = 0;
            this.lblHelpInformation.Text = resources.GetString("lblHelpInformation.Text");
            this.lblHelpInformation.Click += new System.EventHandler(this.lblHelpInformation_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHelpInformation);
            this.Name = "Help";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelpInformation;
    }
}