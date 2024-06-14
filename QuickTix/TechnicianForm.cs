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
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.ActiveDirectory;
using QuickTix;

namespace QuickTix
{
    public partial class TechnicianForm : Form
    {
        private SqlConnection connection;

        public TechnicianForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.connection = sqlConnection;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (connection == null)
                {
                    MessageBox.Show("Database connection is not initialized.");
                    return;
                }

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand("GetTicketDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    this.bindingSource.DataSource = dataTable;
                    this.dataGridView1.DataSource = this.bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void TechnicianForm_Load(object sender, EventArgs e)
        {
            // Set the DataGridView to fill the form
            dataGridView1.Dock = DockStyle.Fill;

            // Automatically resize column widths to fit the text content
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Exclude the "Description" column from being automatically resized
            dataGridView1.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            // Set specific width for the "Description" column
            dataGridView1.Columns["Description"].Width = 500; // Adjust the value as needed

            // Automatically resize row heights to fit the text content
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Make all columns read-only
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }

            // Handle the CellClick event
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a cell and it's not a header
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Try to parse the TicketID cell value as an integer
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (int.TryParse(row.Cells["TicketID"].Value.ToString(), out int ticketID))
                {
                    MessageBox.Show($"TicketID row clicked: {ticketID}");
                    // Add your event handling code here for the TicketID
                }
                else
                {
                    MessageBox.Show("Invalid TicketID value.");
                }
            }
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
