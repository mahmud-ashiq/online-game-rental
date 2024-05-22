namespace RentalManagement
{
    partial class Verify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verify));
            this.send_otp_btn = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.resetotpTextBox = new System.Windows.Forms.TextBox();
            this.verify_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.go_back_verify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // send_otp_btn
            // 
            this.send_otp_btn.BackColor = System.Drawing.Color.Thistle;
            this.send_otp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_otp_btn.Location = new System.Drawing.Point(515, 190);
            this.send_otp_btn.Name = "send_otp_btn";
            this.send_otp_btn.Size = new System.Drawing.Size(167, 31);
            this.send_otp_btn.TabIndex = 16;
            this.send_otp_btn.Text = "Send OTP";
            this.send_otp_btn.UseVisualStyleBackColor = false;
            this.send_otp_btn.Click += new System.EventHandler(this.send_otp_btn_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTextBox.Location = new System.Drawing.Point(333, 153);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(349, 31);
            this.emailTextBox.TabIndex = 15;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // resetotpTextBox
            // 
            this.resetotpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetotpTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.resetotpTextBox.Location = new System.Drawing.Point(333, 190);
            this.resetotpTextBox.Name = "resetotpTextBox";
            this.resetotpTextBox.Size = new System.Drawing.Size(167, 31);
            this.resetotpTextBox.TabIndex = 14;
            this.resetotpTextBox.Text = "Enter OTP";
            this.resetotpTextBox.Click += new System.EventHandler(this.otpTextBox_Click);
            this.resetotpTextBox.Leave += new System.EventHandler(this.otpTextBox_Leave);
            // 
            // verify_btn
            // 
            this.verify_btn.BackColor = System.Drawing.Color.Thistle;
            this.verify_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_btn.Location = new System.Drawing.Point(425, 227);
            this.verify_btn.Name = "verify_btn";
            this.verify_btn.Size = new System.Drawing.Size(167, 31);
            this.verify_btn.TabIndex = 13;
            this.verify_btn.Text = "Verify";
            this.verify_btn.UseVisualStyleBackColor = false;
            this.verify_btn.Click += new System.EventHandler(this.verify_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // go_back_verify
            // 
            this.go_back_verify.BackColor = System.Drawing.Color.MediumPurple;
            this.go_back_verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back_verify.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.go_back_verify.Location = new System.Drawing.Point(889, 420);
            this.go_back_verify.Name = "go_back_verify";
            this.go_back_verify.Size = new System.Drawing.Size(123, 34);
            this.go_back_verify.TabIndex = 17;
            this.go_back_verify.Text = "Go Back";
            this.go_back_verify.UseVisualStyleBackColor = false;
            this.go_back_verify.Click += new System.EventHandler(this.go_back_verify_Click);
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 466);
            this.Controls.Add(this.go_back_verify);
            this.Controls.Add(this.verify_btn);
            this.Controls.Add(this.send_otp_btn);
            this.Controls.Add(this.resetotpTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Verify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resetotpTextBox;
        private System.Windows.Forms.Button verify_btn;
        private System.Windows.Forms.Button send_otp_btn;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button go_back_verify;
    }
}