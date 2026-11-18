namespace _20261118_CSE1322_Lecture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_button = new Button();
            test_label = new Label();
            email_textbox = new TextBox();
            password_textbox = new TextBox();
            email_label = new Label();
            password_label = new Label();
            error_label = new Label();
            show_password = new Button();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Location = new Point(349, 383);
            login_button.Margin = new Padding(0);
            login_button.Name = "login_button";
            login_button.Size = new Size(169, 56);
            login_button.TabIndex = 0;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // test_label
            // 
            test_label.AutoSize = true;
            test_label.Location = new Point(349, 151);
            test_label.Name = "test_label";
            test_label.Size = new Size(0, 20);
            test_label.TabIndex = 1;
            // 
            // email_textbox
            // 
            email_textbox.Location = new Point(157, 230);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(258, 27);
            email_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(157, 296);
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.Size = new Size(258, 27);
            password_textbox.TabIndex = 3;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(157, 207);
            email_label.Name = "email_label";
            email_label.Size = new Size(46, 20);
            email_label.TabIndex = 4;
            email_label.Text = "Email";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(157, 273);
            password_label.Name = "password_label";
            password_label.Size = new Size(70, 20);
            password_label.TabIndex = 5;
            password_label.Text = "Password";
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.Location = new Point(162, 161);
            error_label.Name = "error_label";
            error_label.Size = new Size(0, 20);
            error_label.TabIndex = 6;
            // 
            // show_password
            // 
            show_password.Location = new Point(438, 295);
            show_password.Name = "show_password";
            show_password.Size = new Size(156, 29);
            show_password.TabIndex = 7;
            show_password.Text = "Show Password";
            show_password.UseVisualStyleBackColor = true;
            show_password.Click += show_password_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(show_password);
            Controls.Add(error_label);
            Controls.Add(password_label);
            Controls.Add(email_label);
            Controls.Add(password_textbox);
            Controls.Add(email_textbox);
            Controls.Add(test_label);
            Controls.Add(login_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private Label test_label;
        private TextBox email_textbox;
        private TextBox password_textbox;
        private Label email_label;
        private Label password_label;
        private Label error_label;
        private Button show_password;
    }
}
