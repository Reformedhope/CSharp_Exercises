namespace Chapter10Assignment4
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdobtnFootball = new System.Windows.Forms.RadioButton();
            this.rdobtnTennis = new System.Windows.Forms.RadioButton();
            this.rdobtnGolf = new System.Windows.Forms.RadioButton();
            this.rdobtnTrack = new System.Windows.Forms.RadioButton();
            this.rdobtnVolleyBall = new System.Windows.Forms.RadioButton();
            this.picbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up for a community group. ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdobtnFootball
            // 
            this.rdobtnFootball.AutoSize = true;
            this.rdobtnFootball.Location = new System.Drawing.Point(563, 88);
            this.rdobtnFootball.Name = "rdobtnFootball";
            this.rdobtnFootball.Size = new System.Drawing.Size(62, 17);
            this.rdobtnFootball.TabIndex = 1;
            this.rdobtnFootball.Text = "Football";
            this.rdobtnFootball.UseVisualStyleBackColor = true;
            this.rdobtnFootball.CheckedChanged += new System.EventHandler(this.rdobtnFootball_CheckedChanged);
            // 
            // rdobtnTennis
            // 
            this.rdobtnTennis.AutoSize = true;
            this.rdobtnTennis.Location = new System.Drawing.Point(563, 111);
            this.rdobtnTennis.Name = "rdobtnTennis";
            this.rdobtnTennis.Size = new System.Drawing.Size(57, 17);
            this.rdobtnTennis.TabIndex = 2;
            this.rdobtnTennis.Text = "Tennis";
            this.rdobtnTennis.UseVisualStyleBackColor = true;
            this.rdobtnTennis.CheckedChanged += new System.EventHandler(this.rdobtnTennis_CheckedChanged);
            // 
            // rdobtnGolf
            // 
            this.rdobtnGolf.AutoSize = true;
            this.rdobtnGolf.Location = new System.Drawing.Point(563, 134);
            this.rdobtnGolf.Name = "rdobtnGolf";
            this.rdobtnGolf.Size = new System.Drawing.Size(44, 17);
            this.rdobtnGolf.TabIndex = 3;
            this.rdobtnGolf.Text = "Golf";
            this.rdobtnGolf.UseVisualStyleBackColor = true;
            this.rdobtnGolf.CheckedChanged += new System.EventHandler(this.rdobtnGolf_CheckedChanged);
            // 
            // rdobtnTrack
            // 
            this.rdobtnTrack.AutoSize = true;
            this.rdobtnTrack.Location = new System.Drawing.Point(563, 157);
            this.rdobtnTrack.Name = "rdobtnTrack";
            this.rdobtnTrack.Size = new System.Drawing.Size(53, 17);
            this.rdobtnTrack.TabIndex = 4;
            this.rdobtnTrack.Text = "Track";
            this.rdobtnTrack.UseVisualStyleBackColor = true;
            this.rdobtnTrack.CheckedChanged += new System.EventHandler(this.rdobtnTrack_CheckedChanged);
            // 
            // rdobtnVolleyBall
            // 
            this.rdobtnVolleyBall.AutoSize = true;
            this.rdobtnVolleyBall.Location = new System.Drawing.Point(563, 180);
            this.rdobtnVolleyBall.Name = "rdobtnVolleyBall";
            this.rdobtnVolleyBall.Size = new System.Drawing.Size(70, 17);
            this.rdobtnVolleyBall.TabIndex = 5;
            this.rdobtnVolleyBall.Text = "VolleyBall";
            this.rdobtnVolleyBall.UseVisualStyleBackColor = true;
            this.rdobtnVolleyBall.CheckedChanged += new System.EventHandler(this.rdobtnVolleyBall_CheckedChanged);
            // 
            // picbx
            // 
            this.picbx.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picbx.Location = new System.Drawing.Point(60, 28);
            this.picbx.Name = "picbx";
            this.picbx.Size = new System.Drawing.Size(335, 222);
            this.picbx.TabIndex = 6;
            this.picbx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdobtnVolleyBall);
            this.Controls.Add(this.rdobtnTrack);
            this.Controls.Add(this.rdobtnGolf);
            this.Controls.Add(this.rdobtnTennis);
            this.Controls.Add(this.rdobtnFootball);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbx);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdobtnFootball;
        private System.Windows.Forms.RadioButton rdobtnTennis;
        private System.Windows.Forms.RadioButton rdobtnGolf;
        private System.Windows.Forms.RadioButton rdobtnTrack;
        private System.Windows.Forms.RadioButton rdobtnVolleyBall;
        private System.Windows.Forms.PictureBox picbx;
    }
}

