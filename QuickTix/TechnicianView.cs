using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            LoadCatagories();

            this.Load += new EventHandler(TechnicianView_Load); // Ensure the Load event is hooked
            listView1.ItemActivate += new EventHandler(listView1_ItemActivate);
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
                        listView1.Columns.Add("Ticket #", 80);
                        listView1.Columns.Add("Title", 500);

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
                        bxState.Items.Clear();

                        while (reader.Read())
                        {
                            bxState.Items.Add(reader["StatusName"].ToString());
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
                        bxPriority.Items.Clear();

                        while (reader.Read())
                        {
                            bxPriority.Items.Add(reader["PriorityName"].ToString());
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
        private void LoadCatagories()
        {
            string query = "SELECT CategoryName FROM dbo.TicketCategories";

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
                        bxCategory.Items.Clear();

                        while (reader.Read())
                        {
                            bxCategory.Items.Add(reader["CategoryName"].ToString());
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

                PopulateTicketDetails(int.Parse(ticketID));
            }
        }
        private void PopulateTicketDetails(int ticketID)
        {
            string storedProcedureName = "GetTicketDetails";

            try
            {
                if (quicktixdbConnection.State == ConnectionState.Closed)
                {
                    quicktixdbConnection.Open();
                }

                using (SqlCommand command = new SqlCommand(storedProcedureName, quicktixdbConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TicketID", ticketID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtID.Text = reader["TicketID"].ToString();
                            txtTitle.Text = reader["Title"].ToString();
                            txtCaller.Text = reader["CreatedBy"].ToString();
                            txtEmail.Text = reader["CreatedByEmail"].ToString();
                            txtPhone.Text = reader["CreatedByPhone"].ToString();
                            txtLocation.Text = reader["Location"].ToString();
                            bxState.SelectedItem = reader["StatusName"].ToString();
                            bxPriority.SelectedItem = reader["PriorityName"].ToString();
                            bxCategory.SelectedItem = reader["CategoryName"].ToString();
                            bxAssigned.SelectedItem = reader["AssignedTo"].ToString();
                            txtCreatedDate.Text = reader["CreatedAt"].ToString();
                            txtUpdatedDate.Text = reader["UpdatedAt"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                        }

                        // Clear existing comments
                        flowLayoutPanelComments.Controls.Clear();

                        // Move to the next result set for comments
                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                System.Windows.Forms.TextBox txtComment = new System.Windows.Forms.TextBox();
                                txtComment.Multiline = true;
                                txtComment.ReadOnly = true;
                                txtComment.Width = flowLayoutPanelComments.ClientSize.Width - 20;
                                txtComment.Font = new System.Drawing.Font("Segoe UI", 12); // Set font size to 12

                                string commentText = $"{reader["CreatedAt"]}{": "}{reader["UserName"]}\r\n{reader["CommentText"]}";
                                txtComment.Text = commentText;

                                // Calculate the required height based on the text
                                int textHeight = TextRenderer.MeasureText(commentText, txtComment.Font).Height;
                                txtComment.Height = textHeight + 20; // Add some padding

                                flowLayoutPanelComments.Controls.Add(txtComment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching ticket details: {ex.Message}");
            }
            finally
            {
                if (quicktixdbConnection.State == ConnectionState.Open)
                {
                    quicktixdbConnection.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string storedProcedureName = "UpdateTicketWithComment";
            int currentUserID = GetCurrentUserID();

            if (currentUserID == -1)
            {
                MessageBox.Show("An error occurred while retrieving the current user ID.");
                return;
            }

            try
            {
                if (quicktixdbConnection.State == ConnectionState.Closed)
                {
                    quicktixdbConnection.Open();
                }

                // Retrieve the IDs based on the selected names
                int stateID = GetIDFromName("dbo.TicketStatus", "StatusName", bxState.SelectedItem.ToString(), "StatusID");
                int priorityID = GetIDFromName("dbo.Priority", "PriorityName", bxPriority.SelectedItem.ToString(), "PriorityID");
                int categoryID = GetIDFromName("dbo.TicketCategories", "CategoryName", bxCategory.SelectedItem.ToString(), "CategoryID");
                int assignedToID = GetIDFromName("dbo.Users", "UserName", bxAssigned.SelectedItem.ToString(), "UserID");

                using (SqlCommand command = new SqlCommand(storedProcedureName, quicktixdbConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TicketID", int.Parse(txtID.Text));
                    command.Parameters.AddWithValue("@Title", txtTitle.Text);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text);
                    command.Parameters.AddWithValue("@Location", txtLocation.Text);
                    command.Parameters.AddWithValue("@StateID", stateID);
                    command.Parameters.AddWithValue("@PriorityID", priorityID);
                    command.Parameters.AddWithValue("@CategoryID", categoryID);
                    command.Parameters.AddWithValue("@AssignedTo", assignedToID);
                    command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                    command.Parameters.AddWithValue("@CommentText", txtComment.Text);
                    command.Parameters.AddWithValue("@UserID", currentUserID);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Ticket updated successfully.");
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

            // Optionally, refresh the data on the form
            LoadData();
            PopulateTicketDetails(int.Parse(txtID.Text));
        }

        private int GetIDFromName(string tableName, string nameColumn, string nameValue, string idColumn)
        {
            try
            {
                string query = $"SELECT {idColumn} FROM {tableName} WHERE {nameColumn} = @nameValue";
                using (SqlCommand command = new SqlCommand(query, quicktixdbConnection))
                {
                    command.Parameters.AddWithValue("@nameValue", nameValue);
                    return (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the ID: {ex.Message}");
                return -1;
            }
        }

        private int GetCurrentUserID()
        {

            string sqlLogin = quicktixdbConnection.ConnectionString.Split(';').FirstOrDefault(p => p.StartsWith("User ID="))?.Split('=')[1];
            quicktixdbConnection.Open();
            if (string.IsNullOrEmpty(sqlLogin))
            {
                return -1;
            }
            try
            {
                string query = "SELECT UserID FROM dbo.Users WHERE SQLLogin = @sqlLogin";
                using (SqlCommand command = new SqlCommand(query, quicktixdbConnection))
                {
                    command.Parameters.AddWithValue("@sqlLogin", sqlLogin);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the current user ID: {ex.Message}");
                return -1;
            }
            finally
            {
                quicktixdbConnection.Close();
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
        /*

             private void btnUpdateAssignedTo_Click(object sender, EventArgs e)
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

        private void TechnicianView_Load_1(object sender, EventArgs e)
        {

        }

    }
}
