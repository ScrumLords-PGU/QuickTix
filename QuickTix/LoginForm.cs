﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
/*
AliceSmith password123! Technician
BobJohnson password123! Technician
CharlieBrown password123! Technician
DianaPrince password123! Technician
EvanWright password123! Technician
FrankMiller password123! Customer
GraceHopper password123! Customer
HenryFord password123! Customer
IreneCurie password123! Customer
JackLondon password123! Customer

 */
namespace QuickTix
{
    public partial class LoginForm : Form
    {
        public event Action<string, SqlConnection, string, string, int> LoginSuccessful; // Modify event to include username and password

        private SqlConnection connection;

        public LoginForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.LoginForm_Load); // Color Palette //
        }

        // Color Palette //
        private void LoginForm_Load(object sender, EventArgs e)
        {
            ColorPalette.ApplyColorPalette(this);
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            string user_name = tbUsername.Text;
            string password = tbPassword.Text;
            string quicktixdbConnectionString = $"Server=tcp:quicktixsrvr.database.windows.net,1433;Initial Catalog=quicktixdb;Persist Security Info=False;" +
                $"User ID={user_name};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            try
            {
                connection = new SqlConnection(quicktixdbConnectionString);
                connection.Open();

                int userID = GetUserID(user_name, password);

                string userRole = GetUserRole(user_name, password);

                if (userRole != null)
                {
                    this.Hide(); // Hide the login form
                    LoginSuccessful?.Invoke(userRole, connection, user_name, password, userID); // Trigger the event with the connection, username, and password
                }
                else
                {
                    MessageBox.Show("Access denied: Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private int GetUserID (string username, string password)
        {
            try
            {
                string query = "SELECT UserID from dbo.Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while tretrieving user ID: " + ex.Message);
            }

            return -1;
        }

        private string GetUserRole(string username, string password)
        {
            try
            {
                string query = "SELECT Role FROM dbo.Users WHERE UserName = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    return (string)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while verifying user role: " + ex.Message);
                return null;
            }
        }

        //(jose) Keyboard enter works to move to next line and enter to login
        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
            }
        }


        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
