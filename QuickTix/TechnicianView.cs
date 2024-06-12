using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuickTix
{
    public partial class TechnicianView : Form
    {
        private SqlConnection quicktixdbConnection;

        public TechnicianView(SqlConnection connection)
        {
            quicktixdbConnection = connection;
            InitializeComponent();
            LoadData();
            LoadCategories();

            listView1.ItemActivate += new EventHandler(listView1_ItemActivate);
            listView1.FullRowSelect = true; // Ensure the full row is selectable
        }

        private void LoadData()
        {
            string query = "SELECT TicketID, Title FROM dbo.Tickets";
            try
            {
                if (quicktixdbConnection == null)
                {
                    MessageBox.Show("Database connection is not initialized.");
                    return;
                }

                if (quicktixdbConnection.State == ConnectionState.Closed)
                {
                    quicktixdbConnection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, quicktixdbConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items and columns
                        listView1.Items.Clear();
                        listView1.Columns.Clear();

                        // Define the single column
                        listView1.Columns.Add("#", 30);
                        listView1.Columns.Add("Title", 400);

                        listView1.View = View.Details;

                        while (reader.Read())
                        {
                            // Create a new ListViewItem with the TicketID value
                            ListViewItem item = new ListViewItem(reader["TicketID"].ToString());
                            // Add the Title as a sub-item
                            item.SubItems.Add(reader["Title"].ToString());

                            // Add the ListViewItem to the ListView
                            listView1.Items.Add(item);
                        }
                    }
                }

                quicktixdbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            string query = "SELECT StatusName FROM dbo.TicketStatus";

            try
            {
                if (quicktixdbConnection.State == ConnectionState.Closed)
                {
                    quicktixdbConnection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, quicktixdbConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        statusBox.Items.Clear();

                        while (reader.Read())
                        {
                            statusBox.Items.Add(reader["StatusName"].ToString());
                        }
                    }
                }

                quicktixdbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading categories: {ex.Message}");
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string ticketID = selectedItem.Text; // TicketID is in the first column
                string title = selectedItem.SubItems[1].Text; // Title is in the second column

                MessageBox.Show($"TicketID: {ticketID}\nTitle: {title}", "Item Activated");
            }
        }

        private void TechnicianView_Load(object sender, EventArgs e)
        {

        }

        private void lgOut_Click(object sender, EventArgs e)
        {
            if (quicktixdbConnection != null && quicktixdbConnection.State == ConnectionState.Open)
            {
                quicktixdbConnection.Close();
            }

            // Show the LoginForm
            Application.Restart();
            // Close the current form (TechnicianView)
            this.Close();
        }
    }
}
