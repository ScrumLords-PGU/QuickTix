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
    public partial class TechnicianForm : LoginForm
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
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM ticket", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
