using System.Data;
using System.Data.SqlClient;
using QuickTix; 

namespace QuickTix
{
    public partial class TechnicianView : Form
    {
        private string techUsername;
        private string techPassword;
        private SqlConnection quicktixdbConnection;

        public TechnicianView(string username, string password)
        {
            InitializeComponent();
            techUsername = username;
            techPassword = password;
            InitializeConnections();
        }
        private void InitializeConnections()
        {
            string quicktixdbConnectionString = $"Server=tcp:quicktixsrvr.database.windows.net,1433;Initial Catalog=quicktixdb;Persist Security Info=False;" +
                $"User ID={techUsername};Password={techPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            quicktixdbConnection = new SqlConnection(quicktixdbConnectionString);
        }
        private void LoadData()
        {
            try
            {
                quicktixdbConnection.Open();

                if (quicktixdbConnection == null)
                {
                    MessageBox.Show("Database connection is not initialized.");
                    return;
                }
                else
                { 
                    //populate listview1 with tickets
                }

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void tchForm_Click(object sender, EventArgs e)
        {
            if (quicktixdbConnection.State == ConnectionState.Closed)
            {
                quicktixdbConnection.Open();
            }
            TechnicianForm mainForm = new TechnicianForm(quicktixdbConnection);
            mainForm.Show();
            mainForm.FormClosed += (s, args) =>
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            };
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
