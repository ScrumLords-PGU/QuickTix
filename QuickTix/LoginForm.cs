using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuickTix
{
    public partial class LoginForm : Form
    {
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

        public void btnConnect_Click(object sender, EventArgs e)
        {
            string user_name = tbUsername.Text;
            string password = tbPassword.Text;
            string selectedRole = roleSelection.Text;

            try
            {
                if (selectedRole == "Admin" && VerifyUserRole(user_name, password, "master", selectedRole))
                {
                    this.Hide();
                    AdminForm mainForm = new AdminForm(user_name, password);
                    mainForm.ShowDialog();
                    this.Close();
                }
                else if ((selectedRole == "Technician" || selectedRole == "TechnicianView" || selectedRole == "Customer") && VerifyUserRole(user_name, password, "quicktixdb", selectedRole))
                {
                    this.Hide();

                    if (selectedRole == "Technician" || selectedRole == "TechnicianView")
                    {
                        TechnicianForm mainForm = new TechnicianForm(CreateConnection("quicktixdb", user_name, password));
                        mainForm.ShowDialog();
                    }
                    else if (selectedRole == "Customer")
                    {
                        CustomerForm mainForm = new CustomerForm(CreateConnection("quicktixdb", user_name, password));
                        mainForm.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Access denied: You do not have the required role.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private SqlConnection CreateConnection(string database, string username, string password)
        {
            string connectionString = $"Server=tcp:quicktixsrvr.database.windows.net,1433;Initial Catalog={database};Persist Security Info=False;User ID={username};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return new SqlConnection(connectionString);
        }

        private bool VerifyUserRole(string username, string password, string database, string role)
        {
            try
            {
                using (SqlConnection connection = CreateConnection(database, username, password))
                {
                    connection.Open();

                    string query = "SELECT Role FROM dbo.Users WHERE UserName = @Username AND Password = @Password";
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

