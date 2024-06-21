using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuickTix
{
    public partial class CustomerForm : Form
    {
        private SqlConnection quicktixdbConnection;
        private int userId;
        private string priority = "";
        private string category = "";
        public CustomerForm(SqlConnection sqlConnection, int userId)
        {
            InitializeComponent();
            this.quicktixdbConnection = sqlConnection;
            this.userId = userId;
            LoadData();
            InitializeForm();
        }
        private void InitializeForm()
        {
            InitializePriorityComboBox();
            InitializeCategoryComboBox();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(tbEmail, tbEmail.Text);

            tbUserName.ForeColor = SystemColors.ControlText;

            tbLocation.Select();
        }

        //Method loads data from database, to fill in form known information (name, email, phone ect)
        private void LoadData()
        {
            try
            {
                //TODO: Edit as needed 

                string query = "SELECT UserName, Email, Phone FROM dbo.Users WHERE UserID = @UserID"; 

                using (SqlCommand cmd = new SqlCommand(query, quicktixdbConnection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    if (quicktixdbConnection.State == ConnectionState.Closed)
                        quicktixdbConnection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbUserName.Text = reader["UserName"].ToString();
                            tbEmail.Text = reader["Email"].ToString();
                            tbPhone.Text = reader["Phone"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
            finally
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                    quicktixdbConnection.Close();
            }
        }

        private void InitializePriorityComboBox()
        {
            cbPriority.Items.Clear();
            cbPriority.Items.Add("Low");
            cbPriority.Items.Add("Medium");
            cbPriority.Items.Add("High");
            cbPriority.Items.Add("Critical");
        }

        private void InitializeCategoryComboBox()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("Hardware");
            cbCategory.Items.Add("Software");
            cbCategory.Items.Add("Network");
        }

        //Returns chosen priority value as string
        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.priority = cbPriority.SelectedItem.ToString();
        }

        //Returns chosen category value as string
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.category = cbCategory.SelectedItem.ToString();
        }

        //Validates General Information 
        private bool ValidateGeneralInformation(StringBuilder errorMessage)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(tbPhone.Text) || !IsValidPhoneNumber(tbPhone.Text))
            {
                errorMessage.AppendLine("Please enter a valid phone number.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbEmail.Text) || !IsValidEmail(tbEmail.Text))
            {
                errorMessage.AppendLine("Please enter a valid email address.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbLocation.Text))
            {
                errorMessage.AppendLine("Please enter a valid location.");
                isValid = false;
            }

            return isValid;
        }

        // Email validation
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //Phone validation
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{3}-?\d{3}-?\d{4}$");
        }

        // Validates Ticket Information
        private bool ValidateTicketInformation(StringBuilder errorMessage)
        {
            bool isValid = true;

            if (cbPriority.SelectedItem == null)
            {
                errorMessage.AppendLine("Please select a priority option.");
                isValid = false;
            }

            if (cbCategory.SelectedItem == null)
            {
                errorMessage.AppendLine("Please select a category option.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbSubject.Text))
            {
                errorMessage.AppendLine("Please enter a subject.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbDetails.Text))
            {
                errorMessage.AppendLine("Please enter the details of your issue.");
                isValid = false;
            }

            return isValid;
        }

        // Shows all error messages from General Info and Ticket Info forms
        private bool ValidateAllInformation()
        {
            StringBuilder errorMessage = new StringBuilder();
            bool isValid = true;

            if (!ValidateGeneralInformation(errorMessage))
            {
                isValid = false;
            }

            if (!ValidateTicketInformation(errorMessage))
            {
                isValid = false;
            }

            // Displays all error messages in single box
            if (!isValid)
            {
                MessageBox.Show(errorMessage.ToString(), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        //Validates all information befor submit, then sends to SaveToDatabase method
        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            if (!ValidateAllInformation())
            {
                return;
            }

            string username = tbUserName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string location = tbLocation.Text;
            this.priority = cbPriority.SelectedItem.ToString();
            this.category = cbCategory.SelectedItem.ToString();
            string subject = tbSubject.Text;
            string details = tbDetails.Text;

            SaveToDatabase(username, phone, email, location, priority, category, subject, details);
        }

        //Sends data to database
        //TODO: Replace with stored procedure
        private void SaveToDatabase(string username, string phone, string email, string location,
            string priority, string category, string subject, string details)
        {
            string query = "INSERT INTO Tickets (Status, Comments) VALUES (@Status, @Comments)";
            using (SqlCommand command = new SqlCommand(query, quicktixdbConnection))
            {

            }

            MessageBox.Show("Ticket submitted succesfully!");
        }

        private void lgOut_Click(object sender, EventArgs e)
        {
            if (quicktixdbConnection != null && quicktixdbConnection.State == ConnectionState.Open)
            {
                quicktixdbConnection.Close();
            }

            // Show the LoginForm
            Application.Restart();
            // Close the current form (AdminForm)
            this.Close();
        }
    }
}
