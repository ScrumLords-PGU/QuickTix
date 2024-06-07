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

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Tickets", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                this.bindingSource.DataSource = dataTable;
                this.dataGridView1.DataSource = this.bindingSource;
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

            // Replace the TicketID column with a DataGridViewLinkColumn
            DataGridViewLinkColumn ticketIDLinkColumn = new DataGridViewLinkColumn
            {
                Name = "TicketID",
                HeaderText = "TicketID",
                DataPropertyName = "TicketID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                LinkBehavior = LinkBehavior.HoverUnderline,
                ReadOnly = false, // Make the TicketID column clickable
                SortMode = DataGridViewColumnSortMode.Automatic // Make the column sortable
            };
            dataGridView1.Columns.Remove("TicketID");
            dataGridView1.Columns.Insert(0, ticketIDLinkColumn);

            // Handle the CellContentClick event
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a link cell
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                // Try to parse the cell value as an integer
                if (int.TryParse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString(), out int ticketID))
                {
                    MessageBox.Show($"TicketID link clicked: {ticketID}");
                    // Add your event handling code here for the TicketID link
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