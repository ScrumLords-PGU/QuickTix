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
        private SqlConnection connection;
        private string priority;
        private string category;
        public CustomerForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.connection = sqlConnection;
            LoadData();
           
            InitializeForm();
        }
        private void InitializeForm()
        {
            InitializePriorityComboBox();
            InitializeCategoryComboBox();
            LoadData();
        }

        //Method loads data from database, to fill in form known information (name, email, phone ect)
        private void LoadData()
        {
            try
            {
                //TODO: Below variable is a placeholder. Needs method to load known data (UserName, Email, Phone)  

                string query = "SELECT UserName, Email, Phone FROM Users WHERE UserID = @UserID"; //Placeholder for stored procedure

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                }
            }
            catch
            {

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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.category = cbCategory.SelectedItem.ToString();
        }

        private bool ValidateGeneralInformation(StringBuilder errorMessage)
        {

            if (string.IsNullOrEmpty(txtPhone.Text) || !IsValidPhoneNumber(txtPhone.Text))
            {
                errorMessage.AppendLine("Please enter a valid phone number.");
            }

            if (string.IsNullOrEmpty(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                errorMessage.AppendLine("Please enter a valid email address.");
            }

            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                errorMessage.AppendLine("Please enter a valid location.");
            }

            return true;
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
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        // Validates Ticket Information
        private bool ValidateTicketInformation(StringBuilder errorMessage)
        {

            if (cbPriority.SelectedItem == null)
            {
                errorMessage.AppendLine("Please select a priority option.");
            }

            if (cbCategory.SelectedItem == null)
            {
                errorMessage.AppendLine("Please select a category option.");
            }

            if (string.IsNullOrEmpty(txtDetails.Text))
            {
                errorMessage.AppendLine("Please enter comments.");
            }

            return true;
        }

        // Shows all error messages from General Info and Ticket Info forms
        private bool ValidateAllInformation()
        {
            StringBuilder errorMessage = new StringBuilder();

            ValidateGeneralInformation(errorMessage);

            ValidateTicketInformation(errorMessage);

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString(), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            if (!ValidateAllInformation())
            {
                return;
            }

            string location = txtLocation.Text;
            string priority = cbPriority.SelectedItem.ToString();
            string category = cbCategory.SelectedItem.ToString();
            string comments = txtDetails.Text;
        }

        //TODO: Replace with stored procedure
        private void SaveToDatabase(string statusOption, string comments)
        {
            string query = "INSERT INTO Tickets (Status, Comments) VALUES (@Status, @Comments)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Status", statusOption);
                command.Parameters.AddWithValue("@Comments", comments);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Ticket submitted succesfully!");
        }

        private void lgOut_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            // Show the LoginForm
            Application.Restart();
            // Close the current form (AdminForm)
            this.Close();
        }
    }
}
