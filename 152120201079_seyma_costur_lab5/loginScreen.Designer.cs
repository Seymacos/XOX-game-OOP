namespace _152120201079_seyma_costur_lab6
{
    partial class loginScreen
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
            this.textBox_loginScreen_username = new System.Windows.Forms.TextBox();
            this.textBox_loginScreen_password = new System.Windows.Forms.TextBox();
            this.label_loginScreen_username = new System.Windows.Forms.Label();
            this.label_loginScreen_password = new System.Windows.Forms.Label();
            this.button_loginScreen = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.radioButton_showPassword = new System.Windows.Forms.RadioButton();
            this.checkBox_rememberMe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_loginScreen_username
            // 
            this.textBox_loginScreen_username.Location = new System.Drawing.Point(81, 49);
            this.textBox_loginScreen_username.Name = "textBox_loginScreen_username";
            this.textBox_loginScreen_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_loginScreen_username.TabIndex = 0;
            // 
            // textBox_loginScreen_password
            // 
            this.textBox_loginScreen_password.HideSelection = false;
            this.textBox_loginScreen_password.Location = new System.Drawing.Point(81, 88);
            this.textBox_loginScreen_password.Name = "textBox_loginScreen_password";
            this.textBox_loginScreen_password.PasswordChar = '*';
            this.textBox_loginScreen_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_loginScreen_password.TabIndex = 1;
            // 
            // label_loginScreen_username
            // 
            this.label_loginScreen_username.AutoSize = true;
            this.label_loginScreen_username.Location = new System.Drawing.Point(78, 33);
            this.label_loginScreen_username.Name = "label_loginScreen_username";
            this.label_loginScreen_username.Size = new System.Drawing.Size(60, 13);
            this.label_loginScreen_username.TabIndex = 2;
            this.label_loginScreen_username.Text = "User Name";
            // 
            // label_loginScreen_password
            // 
            this.label_loginScreen_password.AutoSize = true;
            this.label_loginScreen_password.Location = new System.Drawing.Point(78, 72);
            this.label_loginScreen_password.Name = "label_loginScreen_password";
            this.label_loginScreen_password.Size = new System.Drawing.Size(53, 13);
            this.label_loginScreen_password.TabIndex = 3;
            this.label_loginScreen_password.Text = "Password";
            // 
            // button_loginScreen
            // 
            this.button_loginScreen.Location = new System.Drawing.Point(94, 210);
            this.button_loginScreen.Name = "button_loginScreen";
            this.button_loginScreen.Size = new System.Drawing.Size(87, 37);
            this.button_loginScreen.TabIndex = 4;
            this.button_loginScreen.Text = "LOG IN";
            this.button_loginScreen.UseVisualStyleBackColor = true;
            this.button_loginScreen.Click += new System.EventHandler(this.button_loginScreen_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(80, 160);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // radioButton_showPassword
            // 
            this.radioButton_showPassword.AutoSize = true;
            this.radioButton_showPassword.Location = new System.Drawing.Point(80, 114);
            this.radioButton_showPassword.Name = "radioButton_showPassword";
            this.radioButton_showPassword.Size = new System.Drawing.Size(101, 17);
            this.radioButton_showPassword.TabIndex = 6;
            this.radioButton_showPassword.TabStop = true;
            this.radioButton_showPassword.Text = "Show Password";
            this.radioButton_showPassword.UseVisualStyleBackColor = true;
            this.radioButton_showPassword.CheckedChanged += new System.EventHandler(this.radioButton_showPassword_CheckedChanged);
            // 
            // checkBox_rememberMe
            // 
            this.checkBox_rememberMe.AutoSize = true;
            this.checkBox_rememberMe.Location = new System.Drawing.Point(81, 137);
            this.checkBox_rememberMe.Name = "checkBox_rememberMe";
            this.checkBox_rememberMe.Size = new System.Drawing.Size(80, 17);
            this.checkBox_rememberMe.TabIndex = 7;
            this.checkBox_rememberMe.Text = "Beni Hatirla";
            this.checkBox_rememberMe.UseVisualStyleBackColor = true;
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.checkBox_rememberMe);
            this.Controls.Add(this.radioButton_showPassword);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_loginScreen);
            this.Controls.Add(this.label_loginScreen_password);
            this.Controls.Add(this.label_loginScreen_username);
            this.Controls.Add(this.textBox_loginScreen_password);
            this.Controls.Add(this.textBox_loginScreen_username);
            this.Name = "loginScreen";
            this.Text = "loginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_loginScreen_username;
        private System.Windows.Forms.TextBox textBox_loginScreen_password;
        private System.Windows.Forms.Label label_loginScreen_username;
        private System.Windows.Forms.Label label_loginScreen_password;
        private System.Windows.Forms.Button button_loginScreen;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.RadioButton radioButton_showPassword;
        private System.Windows.Forms.CheckBox checkBox_rememberMe;
    }
}