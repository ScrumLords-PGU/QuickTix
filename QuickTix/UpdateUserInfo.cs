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
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;

namespace QuickTix
{
    public partial class UpdateUserInfo : Form
    {
        public event Action<string, string> UpdateSuccessful;
        private SqlConnection quicktixdbConnection;
        private int userId;
        private string currentEmail;
        private string currentPhone;

        public UpdateUserInfo(SqlConnection sqlConnection, int userId, string phone, string email)
        {
            InitializeComponent();
            this.quicktixdbConnection = sqlConnection;
            this.StartPosition = FormStartPosition.CenterParent;
            this.userId = userId;
            this.currentEmail = email;
            this.currentPhone = phone;

            tbEmail.Text = email;
            tbPhone.Text = phone;
        }

        private void cbPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhone.Checked)
            {
                tbPhone.Enabled = true;
                tbPhone.Clear();
                tbPhone.ReadOnly = false;
            }
            else
            {
                tbPhone.Enabled = false;
                tbPhone.Text = currentPhone;
                tbPhone.ReadOnly = true;
            }
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmail.Checked)
            {
                tbEmail.Enabled = true;
                tbEmail.Clear();
                tbEmail.ReadOnly = false;
            }
            else
            {
                tbEmail.Enabled = false;
                tbEmail.Text = currentEmail;
                tbEmail.ReadOnly = true;
            }
        }

        // Validates phone and email and that the combo boxes are checked
        private bool ValidateContactInfo(StringBuilder errorMessage)
        {
            Color customColor = Color.FromArgb(255, 204, 204);
            bool isValid = true;

            if (!cbPhone.Checked && !cbEmail.Checked)
            {
                errorMessage.AppendLine("Please check at least one option to update.");
                return false;
            }

            if (cbPhone.Checked)
            {
                tbPhone.Text = FormatPhoneNumber(tbPhone.Text);
                if (string.IsNullOrEmpty(tbPhone.Text) || !IsValidPhoneNumber(tbPhone.Text))
                {
                    tbPhone.BackColor = Color.FromArgb(255, 204, 204);
                    errorMessage.AppendLine("Please enter a valid phone number.");
                    isValid = false;
                }
                else
                {
                    tbPhone.BackColor = SystemColors.Window;
                }
            }

            if (cbEmail.Checked)
            {
                if (string.IsNullOrEmpty(tbEmail.Text) || !IsValidEmail(tbEmail.Text))
                {
                    tbEmail.BackColor = Color.FromArgb(255, 204, 204);
                    errorMessage.AppendLine("Please enter a valid email address.");
                    isValid = false;
                }
                else
                {
                    tbEmail.BackColor = SystemColors.Window;
                }
            }

            return isValid;
        }

        // Email Validation
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

        // Phone validation
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{3}-?\d{3}-?\d{4}$");
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            phoneNumber = Regex.Replace(phoneNumber, @"\D", "");

            if (phoneNumber.Length == 10)
            {
                return string.Format("{0:###-###-####}", long.Parse(phoneNumber));
            }
            else
            {
                return phoneNumber;
            }
        }

        private bool ShowValidationErrors()
        {
            StringBuilder errorMessage = new StringBuilder();
            bool isValid = true;

            if (!ValidateContactInfo(errorMessage))
            {
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show(this,errorMessage.ToString(), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        //Checks if combo boxes have been checked, then sends those values to UpdateContactInfo
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!ShowValidationErrors())
            {
                return;
            }

            string newPhone = cbPhone.Checked ? tbPhone.Text : currentPhone;
            string newEmail = cbEmail.Checked ? tbEmail.Text : currentEmail;

            UpdateContactInfo(this.userId, newPhone, newEmail);
            this.Close();
        }

        private void UpdateContactInfo(int userId, string newPhone, string newEmail)
        {
            string storedProcedure = "UpdateUserContactInfo";
            using (SqlCommand cmd = new SqlCommand(storedProcedure, quicktixdbConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", userId);

                // Add @Email parameter only if provided
                if (cbEmail.Checked && !string.IsNullOrEmpty(newEmail))
                {
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                }

                // Add @Phone parameter only if provided
                if (cbPhone.Checked && !string.IsNullOrEmpty(newPhone))
                {
                    cmd.Parameters.AddWithValue("@Phone", newPhone);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Phone", DBNull.Value);
                }

                try
                {
                    if (quicktixdbConnection.State == ConnectionState.Closed)
                        quicktixdbConnection.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(this,"Contact information updated successfully!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateSuccessful?.Invoke(newPhone, newEmail);
                    quicktixdbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this,$"An error occurred while updating contact information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (quicktixdbConnection.State == ConnectionState.Open)
                        quicktixdbConnection.Close();
                }
            }
        }

        private void tbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
