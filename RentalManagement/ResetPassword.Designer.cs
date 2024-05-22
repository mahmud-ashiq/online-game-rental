namespace RentalManagement
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.cnpassTextBox = new System.Windows.Forms.TextBox();
            this.n_passTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cnpassTextBox
            // 
            this.cnpassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpassTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cnpassTextBox.Location = new System.Drawing.Point(470, 258);
            this.cnpassTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cnpassTextBox.Name = "cnpassTextBox";
            this.cnpassTextBox.Size = new System.Drawing.Size(380, 37);
            this.cnpassTextBox.TabIndex = 17;
            this.cnpassTextBox.Text = "Confirm New Password";
            this.cnpassTextBox.Enter += new System.EventHandler(this.cnpassTextBox_Enter);
            this.cnpassTextBox.Leave += new System.EventHandler(this.cnpassTextBox_Leave);
            // 
            // n_passTextBox
            // 
            this.n_passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_passTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.n_passTextBox.Location = new System.Drawing.Point(470, 212);
            this.n_passTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.n_passTextBox.Name = "n_passTextBox";
            this.n_passTextBox.Size = new System.Drawing.Size(380, 37);
            this.n_passTextBox.TabIndex = 14;
            this.n_passTextBox.Text = "New Password";
            this.n_passTextBox.UseSystemPasswordChar = true;
            this.n_passTextBox.Enter += new System.EventHandler(this.n_passTextBox_Enter);
            this.n_passTextBox.Leave += new System.EventHandler(this.n_passTextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1348, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Thistle;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(560, 348);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(223, 38);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Update ";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // showpass
            // 
            this.showpass.Appearance = System.Windows.Forms.Appearance.Button;
            this.showpass.AutoSize = true;
            this.showpass.BackColor = System.Drawing.Color.Transparent;
            this.showpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showpass.BackgroundImage")));
            this.showpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showpass.FlatAppearance.BorderSize = 0;
            this.showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.Location = new System.Drawing.Point(808, 212);
            this.showpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(42, 35);
            this.showpass.TabIndex = 18;
            this.showpass.Text = "    ";
            this.showpass.UseVisualStyleBackColor = false;
            this.showpass.Click += new System.EventHandler(this.showpass_Click);
            // 
            // usernametextbox
            // 
            this.usernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usernametextbox.Location = new System.Drawing.Point(470, 167);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(380, 37);
            this.usernametextbox.TabIndex = 19;
            this.usernametextbox.Text = "Username";
            this.usernametextbox.Enter += new System.EventHandler(this.usernametextbox_Enter);
            this.usernametextbox.Leave += new System.EventHandler(this.usernametextbox_Leave);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 524);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.cnpassTextBox);
            this.Controls.Add(this.n_passTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox n_passTextBox;
        private System.Windows.Forms.TextBox cnpassTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.TextBox usernametextbox;
    }
}