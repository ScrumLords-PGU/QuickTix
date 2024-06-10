using System.Data;
using System.Data.SqlClient;
using QuickTix; 

namespace QuickTix
{
    public partial class TechnicianView : Form
    {
        private SqlConnection connection;

        public TechnicianView(SqlConnection sqlConnection)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void TechnicianView_Load(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
