namespace RentalManagement
{
    partial class PassResetVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassResetVerification));
            this.send_otp_btn = new System.Windows.Forms.Button();
            this.reserpass_usernameTextBox = new System.Windows.Forms.TextBox();
            this.otpTextBox = new System.Windows.Forms.TextBox();
            this.reset_pass_verify_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.go_back_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // send_otp_btn
            // 
            this.send_otp_btn.BackColor = System.Drawing.Color.Thistle;
            this.send_otp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_otp_btn.Location = new System.Drawing.Point(679, 230);
            this.send_otp_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.send_otp_btn.Name = "send_otp_btn";
            this.send_otp_btn.Size = new System.Drawing.Size(223, 38);
            this.send_otp_btn.TabIndex = 16;
            this.send_otp_btn.Text = "Send OTP";
            this.send_otp_btn.UseVisualStyleBackColor = false;
            this.send_otp_btn.Click += new System.EventHandler(this.send_otp_btn_Click);
            // 
            // reserpass_usernameTextBox
            // 
            this.reserpass_usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserpass_usernameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.reserpass_usernameTextBox.Location = new System.Drawing.Point(436, 171);
            this.reserpass_usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reserpass_usernameTextBox.Name = "reserpass_usernameTextBox";
            this.reserpass_usernameTextBox.Size = new System.Drawing.Size(464, 37);
            this.reserpass_usernameTextBox.TabIndex = 15;
            this.reserpass_usernameTextBox.Text = "Enter Email";
            this.reserpass_usernameTextBox.Enter += new System.EventHandler(this.reserpass_usernameTextBox_Enter);
            this.reserpass_usernameTextBox.Leave += new System.EventHandler(this.reserpass_usernameTextBox_Leave);
            // 
            // otpTextBox
            // 
            this.otpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.otpTextBox.Location = new System.Drawing.Point(436, 230);
            this.otpTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otpTextBox.Name = "otpTextBox";
            this.otpTextBox.Size = new System.Drawing.Size(221, 37);
            this.otpTextBox.TabIndex = 14;
            this.otpTextBox.Text = "Enter OTP";
            this.otpTextBox.Click += new System.EventHandler(this.otpTextBox_Click);
            this.otpTextBox.Leave += new System.EventHandler(this.otpTextBox_Leave);
            // 
            // reset_pass_verify_btn
            // 
            this.reset_pass_verify_btn.BackColor = System.Drawing.Color.Thistle;
            this.reset_pass_verify_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_pass_verify_btn.Location = new System.Drawing.Point(545, 276);
            this.reset_pass_verify_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset_pass_verify_btn.Name = "reset_pass_verify_btn";
            this.reset_pass_verify_btn.Size = new System.Drawing.Size(223, 38);
            this.reset_pass_verify_btn.TabIndex = 13;
            this.reset_pass_verify_btn.Text = "Verify";
            this.reset_pass_verify_btn.UseVisualStyleBackColor = false;
            this.reset_pass_verify_btn.Click += new System.EventHandler(this.reset_pass_verify_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1349, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // go_back_reset
            // 
            this.go_back_reset.BackColor = System.Drawing.Color.MediumPurple;
            this.go_back_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back_reset.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.go_back_reset.Location = new System.Drawing.Point(1152, 468);
            this.go_back_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.go_back_reset.Name = "go_back_reset";
            this.go_back_reset.Size = new System.Drawing.Size(164, 42);
            this.go_back_reset.TabIndex = 18;
            this.go_back_reset.Text = "Go Back";
            this.go_back_reset.UseVisualStyleBackColor = false;
            this.go_back_reset.Click += new System.EventHandler(this.go_back_reset_Click);
            // 
            // PassResetVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 524);
            this.Controls.Add(this.go_back_reset);
            this.Controls.Add(this.reset_pass_verify_btn);
            this.Controls.Add(this.otpTextBox);
            this.Controls.Add(this.send_otp_btn);
            this.Controls.Add(this.reserpass_usernameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PassResetVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassResetVerification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button send_otp_btn;
        private System.Windows.Forms.TextBox reserpass_usernameTextBox;
        private System.Windows.Forms.TextBox otpTextBox;
        private System.Windows.Forms.Button reset_pass_verify_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button go_back_reset;
    }
}