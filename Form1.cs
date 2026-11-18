namespace _20261118_CSE1322_Lecture
{
    public partial class Form1 : Form
    {
        // Hardcoded email and password for demonstration purposes
        string email = "ekim54@kennesaw.edu";
        string password = "password123";
      
        bool isPasswordVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // Get the input from the textboxes
            string email_input = email_textbox.Text;
            string password_input = password_textbox.Text;

            // Validate the input against the hardcoded email and password
            if (email_input == email && password_input == password)
            {
                // If the email and password match, open Form2 and hide Form1
                Form2 f2 = new Form2();
                f2.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
                f2.Show();
                this.Hide();
            }
            else
            {
                // If the email and password do not match, display an error message
                error_label.Text = "Invalid email or password.";
            }
        }

        private void show_password_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the password
            if (isPasswordVisible == true)
            {
                password_textbox.PasswordChar = '*';
                isPasswordVisible = false;

                // Update the button text to indicate the current state
                show_password.Text = "Show Password";
            }
            else
            {
                password_textbox.PasswordChar = '\0';
                isPasswordVisible = true;
                show_password.Text = "Hide Password";
            }
        }
    }
}
