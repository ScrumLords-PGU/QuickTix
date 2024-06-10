using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuickTix;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuickTix
{
    public partial class AdminForm : Form
    {
        private string adminUsername;
        private string adminPassword;
        private SqlConnection masterConnection;
        private SqlConnection quicktixdbConnection;

        public AdminForm(string username, string password)
        {
            InitializeComponent();
            adminUsername = username;
            adminPassword = password;
            InitializeConnections();
        }

        private void InitializeConnections()
        {
            string masterConnectionString = $"Server=tcp:quicktixsrvr.database.windows.net,1433;Initial Catalog=master;Persist Security Info=False;User ID={adminUsername};Password={adminPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string quicktixdbConnectionString = $"Server=tcp:quicktixsrvr.database.windows.net,1433;Initial Catalog=quicktixdb;Persist Security Info=False;User ID={adminUsername};Password={adminPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            masterConnection = new SqlConnection(masterConnectionString);
            quicktixdbConnection = new SqlConnection(quicktixdbConnectionString);
        }
        
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

            try
            {
                masterConnection.Open();
                string createLoginQuery = $"CREATE LOGIN {newUsername} WITH PASSWORD = '{newPassword}';";
                SqlCommand createLoginCommand = new SqlCommand(createLoginQuery, masterConnection);
                createLoginCommand.ExecuteNonQuery();
                masterConnection.Close();

                quicktixdbConnection.Open();
                string createUserQuery = $"CREATE USER {newUsername} FOR LOGIN {newUsername};";
                SqlCommand createUserCommand = new SqlCommand(createUserQuery, quicktixdbConnection);
                createUserCommand.ExecuteNonQuery();

                string assignRoleQuery = $"EXEC sp_addrolemember 'db_datareader', '{newUsername}'; EXEC sp_addrolemember 'db_datawriter', '{newUsername}';";
                SqlCommand assignRoleCommand = new SqlCommand(assignRoleQuery, quicktixdbConnection);
                assignRoleCommand.ExecuteNonQuery();

                MessageBox.Show("User created and roles assigned successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (masterConnection.State == ConnectionState.Open)
                {
                    masterConnection.Close();
                }
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            } 
       }
    }
}
