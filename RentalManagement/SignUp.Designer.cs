namespace RentalManagement
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.go_back = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.usersignupPassTextBox = new System.Windows.Forms.TextBox();
            this.usersingupTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gendercombobox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.otpTextBox = new System.Windows.Forms.TextBox();
            this.send_otp_btn = new System.Windows.Forms.Button();
            this.username_check_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // go_back
            // 
            this.go_back.BackColor = System.Drawing.Color.MediumPurple;
            this.go_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.go_back.Location = new System.Drawing.Point(1185, 517);
            this.go_back.Margin = new System.Windows.Forms.Padding(4);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(164, 42);
            this.go_back.TabIndex = 0;
            this.go_back.Text = "Go Back";
            this.go_back.UseVisualStyleBackColor = false;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.Thistle;
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(553, 409);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(223, 78);
            this.confirm_btn.TabIndex = 13;
            this.confirm_btn.Text = "Confirm Information";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneTextBox.Location = new System.Drawing.Point(442, 273);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(296, 37);
            this.phoneTextBox.TabIndex = 14;
            this.phoneTextBox.Text = "Phone Number";
            this.phoneTextBox.Click += new System.EventHandler(this.phoneTextBox_Click);
            this.phoneTextBox.Leave += new System.EventHandler(this.phoneTextBox_Leave);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.addressTextBox.Location = new System.Drawing.Point(442, 180);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(464, 85);
            this.addressTextBox.TabIndex = 12;
            this.addressTextBox.Text = "Address";
            this.addressTextBox.Click += new System.EventHandler(this.addressTextBox_Click);
            this.addressTextBox.Leave += new System.EventHandler(this.addressTextBox_Leave);
            // 
            // usersignupPassTextBox
            // 
            this.usersignupPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersignupPassTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usersignupPassTextBox.Location = new System.Drawing.Point(442, 135);
            this.usersignupPassTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usersignupPassTextBox.Name = "usersignupPassTextBox";
            this.usersignupPassTextBox.Size = new System.Drawing.Size(370, 37);
            this.usersignupPassTextBox.TabIndex = 10;
            this.usersignupPassTextBox.Text = "Password";
            this.usersignupPassTextBox.Click += new System.EventHandler(this.usersignupPassTextBox_Click);
            this.usersignupPassTextBox.Leave += new System.EventHandler(this.usersignupPassTextBox_Leave);
            // 
            // usersingupTextBox
            // 
            this.usersingupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersingupTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usersingupTextBox.Location = new System.Drawing.Point(442, 93);
            this.usersingupTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usersingupTextBox.Name = "usersingupTextBox";
            this.usersingupTextBox.Size = new System.Drawing.Size(334, 37);
            this.usersingupTextBox.TabIndex = 9;
            this.usersingupTextBox.Text = "Username";
            this.usersingupTextBox.Click += new System.EventHandler(this.usersingupTextBox_Click);
            this.usersingupTextBox.Leave += new System.EventHandler(this.usersingupTextBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastNameTextBox.Location = new System.Drawing.Point(682, 48);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(224, 37);
            this.lastNameTextBox.TabIndex = 8;
            this.lastNameTextBox.Text = "Last Name";
            this.lastNameTextBox.Click += new System.EventHandler(this.lastNameTextBox_Click);
            this.lastNameTextBox.Leave += new System.EventHandler(this.lastNameTextBox_Leave);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.firstNameTextBox.Location = new System.Drawing.Point(442, 48);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(219, 37);
            this.firstNameTextBox.TabIndex = 7;
            this.firstNameTextBox.Text = "First Name";
            this.firstNameTextBox.Click += new System.EventHandler(this.firstNameTextBox_Click);
            this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1368, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // gendercombobox
            // 
            this.gendercombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendercombobox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.gendercombobox.FormattingEnabled = true;
            this.gendercombobox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gendercombobox.Location = new System.Drawing.Point(769, 273);
            this.gendercombobox.Margin = new System.Windows.Forms.Padding(4);
            this.gendercombobox.Name = "gendercombobox";
            this.gendercombobox.Size = new System.Drawing.Size(137, 38);
            this.gendercombobox.TabIndex = 16;
            this.gendercombobox.Text = "Gender";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTextBox.Location = new System.Drawing.Point(442, 319);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(464, 37);
            this.emailTextBox.TabIndex = 19;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // otpTextBox
            // 
            this.otpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.otpTextBox.Location = new System.Drawing.Point(440, 364);
            this.otpTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.otpTextBox.Name = "otpTextBox";
            this.otpTextBox.Size = new System.Drawing.Size(221, 37);
            this.otpTextBox.TabIndex = 20;
            this.otpTextBox.Text = "Enter OTP";
            this.otpTextBox.Enter += new System.EventHandler(this.otpTextBox_Enter);
            this.otpTextBox.Leave += new System.EventHandler(this.otpTextBox_Leave);
            // 
            // send_otp_btn
            // 
            this.send_otp_btn.BackColor = System.Drawing.Color.Thistle;
            this.send_otp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_otp_btn.Location = new System.Drawing.Point(683, 363);
            this.send_otp_btn.Margin = new System.Windows.Forms.Padding(4);
            this.send_otp_btn.Name = "send_otp_btn";
            this.send_otp_btn.Size = new System.Drawing.Size(223, 38);
            this.send_otp_btn.TabIndex = 21;
            this.send_otp_btn.Text = "Send OTP";
            this.send_otp_btn.UseVisualStyleBackColor = false;
            this.send_otp_btn.Click += new System.EventHandler(this.send_otp_btn_Click);
            // 
            // username_check_btn
            // 
            this.username_check_btn.BackColor = System.Drawing.Color.Thistle;
            this.username_check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_check_btn.Location = new System.Drawing.Point(784, 93);
            this.username_check_btn.Margin = new System.Windows.Forms.Padding(4);
            this.username_check_btn.Name = "username_check_btn";
            this.username_check_btn.Size = new System.Drawing.Size(126, 38);
            this.username_check_btn.TabIndex = 22;
            this.username_check_btn.Text = "Check";
            this.username_check_btn.UseVisualStyleBackColor = false;
            this.username_check_btn.Click += new System.EventHandler(this.username_check_btn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 574);
            this.Controls.Add(this.username_check_btn);
            this.Controls.Add(this.send_otp_btn);
            this.Controls.Add(this.otpTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.gendercombobox);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.usersignupPassTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.usersingupTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go_back;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox usersignupPassTextBox;
        private System.Windows.Forms.TextBox usersingupTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox gendercombobox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox otpTextBox;
        private System.Windows.Forms.Button send_otp_btn;
        private System.Windows.Forms.Button username_check_btn;
    }
}