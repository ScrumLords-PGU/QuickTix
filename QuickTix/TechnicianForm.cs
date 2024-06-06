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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
