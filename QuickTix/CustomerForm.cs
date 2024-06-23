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
        private int priorityId;
        private int categoryId;
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

            //Sprint 3
            /*ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(tbEmail, tbEmail.Text);*/

            tbLocation.Select();
        }

        //Method loads data from database, to fill in form known information (name, email, phone ect)
        private void LoadData()
        {
            try
            {

                string query = "SELECT UserName, Email, Phone FROM dbo.Users WHERE UserID = @UserID"; 

                using (SqlCommand cmd = new SqlCommand(query, quicktixdbConnection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

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

        public enum Priority
        {
            Critical = 1,
            High = 2,
            Medium = 3,
            Low = 4
        }

        public enum Category
        {
            Hardware = 1,
            Software = 2,
            Network = 3
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

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPriority.SelectedItem != null && Enum.TryParse(cbPriority.SelectedItem.ToString(), out Priority selectedPriority))
            {
                this.priorityId = (int)selectedPriority;
            }
            else
            {
                this.priorityId = -1;
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem != null && Enum.TryParse(cbCategory.SelectedItem.ToString(), out Category selectedCategory))
            {
                this.categoryId = (int)selectedCategory;
            }
            else
            {
                this.categoryId = -1;
            }
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

            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                errorMessage.AppendLine("Please enter a subject.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbDescription.Text))
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

            if (!isValid)
            {
                MessageBox.Show(errorMessage.ToString(), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        //Validates all information before submit, then sends to SaveToDatabase method
        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            if (!ValidateAllInformation())
            {
                return;
            }
            //TODO: Sprint 3
            //string phone = tbPhone.Text;
            //string email = tbEmail.Text;
            string location = tbLocation.Text;
            int priorityId = this.priorityId;
            int categoryId = this.categoryId;
            string title = tbTitle.Text;
            string description = tbDescription.Text;
            int statusID = 1;

            //TODO: Sprint 3
            //UpdateUserInfo(phone, email);
            SaveToDatabase(this.userId, location, priorityId, categoryId, title, description, statusID);
        }

        //TODO: Implement user update information for Sprint 3

        /*private void UpdateUserInfo(string phone, string email)
        {
            string storedProcedure = "";
            using (SqlCommand cmd = new SqlCommand()) 
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
            }
        } 
        */

        //Submits ticket info to database
        private void SaveToDatabase(int userId, string location,
            int priorityId, int categoryId, string title, string description, int statusId)
        {
            string storedProcedure = "InsertTicket";

            try
            {

                using (SqlCommand cmd = new SqlCommand(storedProcedure, quicktixdbConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@PriorityID", priorityId);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@StatusID", statusId);

                    if (quicktixdbConnection.State == ConnectionState.Closed)
                        quicktixdbConnection.Open();

                    
                    cmd.ExecuteNonQuery();
                    quicktixdbConnection.Close();

                    MessageBox.Show("Ticket submitted succesfully!");

                    ClearFormFields();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while submitting the ticket: {ex.Message}");
            }
            finally
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            }
        }

        private void ClearFormFields(Control parentControl)
        {
            //Reset text boxes 
            tbLocation.Text = string.Empty;
            tbTitle.Text = string.Empty;
            tbDescription.Text = string.Empty;

            // Reset combo boxes
            cbPriority.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;

            // Set focus to the first input field
            tbLocation.Select();
        }

        private void ClearFormFields()
        {
            ClearFormFields(this); // Start from the form
            tbLocation.Select(); // Set focus to
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
