using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.ActiveDirectory;
using QuickTix;

namespace QuickTix
{
    public partial class LoginForm : Form
    {
        private SqlConnection connection;
       
                
        public LoginForm()
        {
            InitializeComponent();
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            bool isValid = true;
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

                
                Controller controller = new Controller(connection);
                if (controller.TestConnection())
                {
                    MessageBox.Show("Login Successful");
                    Thread.Sleep(1000);
                    this.Hide(); // Hide the login form
                   // TechnicianForm mainForm = new TechnicianForm(connection);
                    TechnicianView mainForm = new TechnicianView();
                    mainForm.ShowDialog();
                    this.Close(); // Close the login form after the main form is closed
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
