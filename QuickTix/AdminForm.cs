using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuickTix
{
    public partial class AdminForm : Form
    {
        private SqlConnection quicktixdbConnection;
        private SqlConnection masterConnection;
        private string adminUsername;
        private string adminPassword;

        public AdminForm(SqlConnection quicktixdbConnection, string adminUsername, string adminPassword)
        {
            InitializeComponent();
            this.quicktixdbConnection = quicktixdbConnection;
            this.adminUsername = adminUsername;
            this.adminPassword = adminPassword;
            InitializeConnections();
            roleAssignment.Items.Add("Customer");
            roleAssignment.Items.Add("Technician");
            roleAssignment.Items.Add("Admin");
            roleAssignment.DropDownStyle = ComboBoxStyle.DropDownList;
            roleAssignment.SelectedIndex = 0;
            this.Load += new System.EventHandler(this.AdminForm_Load); // Color palette //
        }

        // Color Palette //
        private void AdminForm_Load(object sender, EventArgs e)
        {
            ColorPalette.ApplyColorPalette(this);
        }


        private void InitializeConnections()
        {
            string masterConnectionString = $"Server=tcp:quicktixsrvr.database.windows.net,1433;Initial Catalog=master;Persist Security Info=False;" +
                $"User ID={adminUsername};Password={adminPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            masterConnection = new SqlConnection(masterConnectionString);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

            try
            {
                if (masterConnection.State == ConnectionState.Closed)
                {
                    masterConnection.Open();
                }
                string createLoginQuery = $"CREATE LOGIN {newUsername} WITH PASSWORD = '{newPassword}';";
                SqlCommand createLoginCommand = new SqlCommand(createLoginQuery, masterConnection);
                createLoginCommand.ExecuteNonQuery();
                masterConnection.Close();

                if (quicktixdbConnection.State == ConnectionState.Closed)
                {
                    quicktixdbConnection.Open();
                }
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

        private void tchView_Click(object sender, EventArgs e)
        {
            if (quicktixdbConnection.State == ConnectionState.Closed)
            {
                quicktixdbConnection.Open();
            }

            TechnicianView mainForm = new TechnicianView(quicktixdbConnection);
            mainForm.Show();
            mainForm.FormClosed += (s, args) =>
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            };
        }

        private void tchForm_Click(object sender, EventArgs e)
        {
            if (quicktixdbConnection.State == ConnectionState.Closed)
            {
                quicktixdbConnection.Open();
            }
            TechnicianForm mainForm = new TechnicianForm(quicktixdbConnection);
            mainForm.Show();
            mainForm.FormClosed += (s, args) =>
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            };
        }

        private void cstForm_Click(object sender, EventArgs e)
        {
            if (quicktixdbConnection.State == ConnectionState.Closed)
            {
                quicktixdbConnection.Open();
            }

            int userId = 0;

            CustomerForm mainForm = new CustomerForm(quicktixdbConnection, userId);
            mainForm.Show();
            mainForm.FormClosed += (s, args) =>
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            };
        }

        private void lgOut_Click(object sender, EventArgs e)
        {
            if (quicktixdbConnection != null && quicktixdbConnection.State == ConnectionState.Open)
            {
                quicktixdbConnection.Close();
            }

            if (masterConnection != null && masterConnection.State == ConnectionState.Open)
            {
                masterConnection.Close();
            }

            // Show the LoginForm
            Application.Restart();
            // Close the current form (AdminForm)
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
