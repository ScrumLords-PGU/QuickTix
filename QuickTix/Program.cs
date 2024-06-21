using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QuickTix
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new();
            loginForm.LoginSuccessful += OnLoginSuccessful; // Subscribe to the event
            Application.Run(loginForm);
        }

        private static void OnLoginSuccessful(string userRole, SqlConnection connection, string userName, string password, int userId)
        {
            // Create and show the main form based on user role
            Form mainForm = null;

            if (userRole == "Admin")
            {
                mainForm = new AdminForm(connection, userName, password);
            }
            else if (userRole == "Technician")
            {
                mainForm = new TechnicianView(connection);
            }
            else if (userRole == "Customer")
            {
                mainForm = new CustomerForm(connection, userId);
            }

            if (mainForm != null)
            {
                mainForm.ShowDialog();
            }

            // Exit the application after the main form is closed
            Application.Exit();
        }
    }
}
