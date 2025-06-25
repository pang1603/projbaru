using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projbaru
{
    public partial class SignIn : Form
    {
        // Connection string for your database (update this with your actual connection string)
        private string connectionString = "your_connection_string_here";

        public SignIn()
        {
            InitializeComponent();
        }

        // Event to load the SignIn Form
        private void SignIn_Load(object sender, EventArgs e)
        {
            // You can load any necessary data if required
            // For example: load user or guest data or perform any database connection test
        }

        // Button click event for Sign In (User Login)
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text; // Assuming txtUsername is the username textbox
            string password = passwordTextBox.Text; // Assuming txtPassword is the password textbox

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.");
                return;
            }

            if (IsUserValid(username, password))
            {
                MessageBox.Show("Login successful!");
                // Proceed to the next form (Order Form, Guest Form, etc.)
                // For example:
                this.Hide(); // Hide SignIn form
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }

        // Method to check if the user exists in the User table
        private bool IsUserValid(string username, string password)
        {
            bool isValid = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM [dbo].[User] WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); // Ideally, you'd hash the password, but using plain text for now
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                isValid = result > 0;
            }
            return isValid;
        }

        // Button click event for guest check-in (if applicable)
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (checkBoxGuest.Checked) // If user opts to check in as a guest
            {
                // Check if guest details are filled
                if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(phoneNumberTextBox.Text))
                {
                    MessageBox.Show("Please fill in all guest information.");
                    return;
                }

                string guestId = guestIDTextBox.Text; // Guest ID (could be auto-generated in the guest table)
                string name = nameTextBox.Text; // Guest name
                string phoneNumber = phoneNumberTextBox.Text; // Guest phone number
                DateTime checkInTime = checkInTimeDateTimePicker.Value; // Get check-in time from DateTimePicker

                // Insert guest details into the Guest table
                if (InsertGuest(name, phoneNumber, checkInTime))
                {
                    MessageBox.Show("Guest check-in successful!");
                    // Proceed to the next guest form (e.g., order form for guest)

                    this.Hide(); // Hide SignIn form
                }
                else
                {
                    MessageBox.Show("Failed to check-in guest.");
                }
            }
            else
            {
                MessageBox.Show("Please check 'Check in as Guest' to proceed.");
            }
        }

        // Method to insert guest details into the Guest table
        private bool InsertGuest(string name, string phoneNumber, DateTime checkInTime)
        {
            bool isSuccess = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO [dbo].[Guest] (Name, PhoneNumber, CheckInTime) VALUES (@Name, @PhoneNumber, @CheckInTime)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@CheckInTime", checkInTime);

                int rowsAffected = cmd.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;
            }
            return isSuccess;
        }

        // This event handler can be used for handling picture box click or other events if needed
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle picture box click here if needed
        }

        // When the guest check-in checkbox is checked or unchecked
        private void checkBoxGuest_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide guest-related fields based on whether the checkbox is checked
            bool isGuest = checkBoxGuest.Checked;

            // Show the guest information fields if the checkbox is checked
            nameTextBox.Visible = isGuest;
            phoneNumberTextBox.Visible = isGuest;
            guestIDTextBox.Visible = isGuest;
            checkInTimeDateTimePicker.Visible = isGuest;

            // Optionally, show/hide labels for these controls
        }

        // This event handler can be used for any other user interactions on the form
        private void usernameLabel_Click(object sender, EventArgs e) { }
        private void usernameTextBox_TextChanged(object sender, EventArgs e) { }
        private void nameTextBox_TextChanged(object sender, EventArgs e) { }
        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e) { }
    }
}