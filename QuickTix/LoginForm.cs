﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuickTix
{
 /*Test accounts
  
  Admin: Access to all forms
  Technician: Access to TechnicianForm, TechnicianViewForm, CustomerForm
  Customer: Access to CustomerForm only
  Developers account I created for everyone are Admin accounts.

   AliceSmith password123! Technician
   BobJohnson password123! Technician
   CharlieBrown password123! Technician
   DianaPrince password123! Technician
   EvanWright password123! Technician
   FrankMiller password123!	Customer
   GraceHopper password123!	Customer
   HenryFord password123!	Customer
   IreneCurie password123!	Customer
   JackLondon password123!	Customer
    
 */
    public partial class LoginForm : Form
    {
        private SqlConnection connection;

        public LoginForm()
        {
            InitializeComponent();
            roleSelection.Items.Add("Customer");
            roleSelection.Items.Add("Technician");
            roleSelection.Items.Add("TechnicianView");
            roleSelection.Items.Add("Admin");
            roleSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            roleSelection.SelectedIndex = 0;
        }

        public void btnConnect_Click(object sender, EventArgs e) // Might need to be changed to public to pass infomration to other forms, or private for better security. Looking into this. 
        {
            string user_name = tbUsername.Text;
            string password = tbPassword.Text;
            string quicktixdbConnectionString = $"Server=tcp:quicktixsrvr.database.windows.net,1433;Initial Catalog=quicktixdb;Persist Security Info=False;User ID={user_name};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            

            try
            {
                connection = new SqlConnection(quicktixdbConnectionString);
                connection.Open();

                if (roleSelection.Text == "")
                {
                    MessageBox.Show("Select role from dropdown box");
                }
                else
                {
                    if (VerifyUserRole(user_name, password, roleSelection.Text))
                    {
                        Controller userController = new Controller(connection);

                        if (userController.TestConnection())
                        {
                            this.Hide(); // Hide the Login form

                            if (roleSelection.Text == "Admin")
                            {
                                AdminForm mainForm = new AdminForm(user_name, password);
                                mainForm.ShowDialog();
                            }
                            else if (roleSelection.Text == "Technician") 
                            {
                                TechnicianForm mainForm = new TechnicianForm(connection);
                                mainForm.ShowDialog();
                            }
                            else if (roleSelection.Text ==  "TechnicianView")
                                {
                                TechnicianView mainForm = new TechnicianView(connection);
                                mainForm.ShowDialog();
                            }
                            else if (roleSelection.Text == "Customer")
                            {
                                CustomerForm mainForm = new CustomerForm(connection);
                                mainForm.ShowDialog();
                            }

                            this.Close(); // Close the login form after the main form is closed
                        }
                        else
                        {
                            MessageBox.Show("Access denied: You do not have the required role.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Access denied: You do not have the required role.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private bool VerifyUserRole(string username, string password, string role)
        {
            try
            {
                string connectionString = $"Server=tcp:quicktixsrvr.database.windows.net,1433;Initial Catalog=quicktixdb;Persist Security Info=False;User ID={username};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Role FROM dbo.Users WHERE UserName = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        string userRole = (string)cmd.ExecuteScalar();

                        if (userRole == null)
                        {
                            return false; // User not found or incorrect password
                        }

                        // Check role compatibility
                        if (role == "Admin" && userRole == "Admin")
                        {
                            return true;
                        }
                        if ((role == "Technician" || role == "TechnicianView") && (userRole == "Technician" || userRole == "Admin"))
                        {
                            return true;
                        }
                        if (role == "Customer" && (userRole == "Customer" || userRole == "Technician" || userRole == "Admin"))
                        {
                            return true;
                        }

                        return false; // Role mismatch
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while verifying user role: " + ex.Message);
                return false;
            }
        }
    }
}