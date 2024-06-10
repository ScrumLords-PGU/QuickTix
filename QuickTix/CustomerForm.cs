using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTix
{
    public partial class CustomerForm : Form
    {
        private SqlConnection connection;
        private string priority;
         public CustomerForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.connection = sqlConnection;
            LoadData();
        }



        //Method loads data from database, to fill in form known information (name, email, phone ect)
        private void LoadData()
        {

        }
        //Returns chosen status value as string
        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            priority = cdPriority.SelectedItem.ToString();
        }
 
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(priority))
            {
                MessageBox.Show("Please select a priority option before submitting the ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrEmpty(tbDetails.Text))
            {
                MessageBox.Show("Please enter comments before submitting the ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SaveToDatabase(priority, tbDetails.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting the ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Method saves information to database
        //TODO: add other values from the form
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
    }
}
