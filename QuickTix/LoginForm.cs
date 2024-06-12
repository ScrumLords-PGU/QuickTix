using System;
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

                string userRole = GetUserRole(user_name, password);

                if (userRole != null)
                {
                   
                    this.Hide(); // Hide the Login
                    Form mainForm = null;

                    if (userRole == "Admin")
                    {
                        mainForm = new AdminForm(user_name, password);
                        mainForm.ShowDialog();
                    }
                    else if (userRole == "Technician")
                    {
                        mainForm = new TechnicianView(user_name, password);
                        mainForm.ShowDialog();
                    }
                    else if (userRole == "TechnicianView")
                    {
                        mainForm = new TechnicianView(user_name, password);
                        mainForm.ShowDialog();
                    }
                    else if (userRole == "Customer")
                    {
                        mainForm = new CustomerForm(connection);
                        mainForm.ShowDialog();
                    }
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
    }
}