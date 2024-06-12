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
            LoadPriorities();

            this.Load += new EventHandler(TechnicianView_Load); // Ensure the Load event is hooked
            listView1.ItemActivate += new EventHandler(listView1_ItemActivate);
            listView1.FullRowSelect = true; // Ensure the full row is selectable
        }

        private void TechnicianView_Load(object sender, EventArgs e)
        {
            PopulateTechnicianComboBox();
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

        private List<string> GetTechnicianUsers()
        {
            List<string> technicians = new List<string>();
            string query = "SELECT UserName FROM dbo.Users WHERE Role = 'Technician'";

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
                        
                        while (reader.Read())
                        {
                            technicians.Add(reader["UserName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching technicians: {ex.Message}");
            }
            finally
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            }

            return technicians;
        }

        private void PopulateTechnicianComboBox()
        {

            List<string> technicians = GetTechnicianUsers();
            bxAssigned.Items.Clear(); // Clear the combo box before setting the data source
            bxAssigned.DataSource = technicians;
            bxAssigned.SelectedIndex = -1; // Ensure no item is selected initially

 
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

        private void LoadPriorities()
        {
            string query = "SELECT PriorityName FROM dbo.Priority";

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
                        priorityBox.Items.Clear();

                        while (reader.Read())
                        {
                            priorityBox.Items.Add(reader["PriorityName"].ToString());
                        }
                    }
                }

                quicktixdbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading priorities: {ex.Message}");
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

        private void UpdateAssignedTo(string toUserName, int ticketId)
        {
            string storedProcedureName = "UpdateAssignedTo";

            try
            {
                if (quicktixdbConnection.State == ConnectionState.Closed)
                {
                    quicktixdbConnection.Open();
                }

                using (SqlCommand command = new SqlCommand(storedProcedureName, quicktixdbConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ToUserName", toUserName);
                    command.Parameters.AddWithValue("@TicketID", ticketId);

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show($"{rowsAffected} row updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the ticket: {ex.Message}");
            }
            finally
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            }
        }

        /* private void btnUpdateAssignedTo_Click(object sender, EventArgs e)
        {
            string toUserName = bxAssigned.Text; // The new user
            string ticketIdText = txtID.Text; // The Ticket ID from a TextBox

            if (int.TryParse(ticketIdText, out int ticketId))
            {
                UpdateAssignedTo(toUserName, ticketId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Ticket ID.");
            }
        }
        */

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
