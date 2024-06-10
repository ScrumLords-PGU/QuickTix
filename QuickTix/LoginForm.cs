using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.ActiveDirectory;
using QuickTix;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace QuickTix
{
    public partial class LoginForm : Form
    {
        private SqlConnection connection;


        public LoginForm()
        {
            InitializeComponent();
            // Initialize the ComboBox
            
            roleSelection.Items.Add("Customer");
            roleSelection.Items.Add("Technician");
            roleSelection.Items.Add("TechnicianView");
            roleSelection.Items.Add("Admin");

            // Set the DropDownStyle to DropDownList to disable typing
            roleSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            roleSelection.SelectedIndex = 0;
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            string user_name = tbUsername.Text;
            string password = tbPassword.Text;
            string connectionString = ("Server = tcp:quicktixsrvr.database.windows.net, 1433; " +
                    "Initial Catalog = quicktixdb; Persist Security Info = False;" +
                    "User ID =  " + user_name + ";" +
                    "Password = " + password + ";" +
                    "MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                if (roleSelection.Text == "")
                {
                    MessageBox.Show("Select role from dropdown box");
                }
                else
                {
                    Controller userController = new Controller(connection);

                    if (roleSelection.Text == "Technician")
                    {
                        if (userController.TestConnection())
                        {
                            this.Hide(); // Hide the Login form
                            TechnicianForm mainForm = new TechnicianForm(connection);
                            mainForm.ShowDialog();
                            this.Close(); // Close the login form after the main form is closed
                        }
                    }

                    if (roleSelection.Text == "TechnicianView")
                    {
                        if (userController.TestConnection())
                        {
                            this.Hide(); // Hide the Login form
                            TechnicianView mainForm = new TechnicianView(connection);
                            mainForm.ShowDialog();
                            this.Close(); // Close the login form after the main form is closed
                        }
                    }

                    else if (roleSelection.Text == "Admin")
                    {
                        if (userController.TestConnection())
                        {
                            this.Hide(); // Hide the Login form
                            AdminForm mainForm = new AdminForm(connection);
                            mainForm.ShowDialog();
                            this.Close(); // Close the login form after the main form is closed
                        }
                    }
                    else if (roleSelection.Text == "Customer")
                    {
                        if (userController.TestConnection())
                        {
                            this.Hide(); // Hide the Login form
                            CustomerForm mainForm = new CustomerForm(connection);
                            mainForm.ShowDialog();
                            this.Close(); // Close the login form after the main form is closed
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
    }
}
