using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuickTix;
using System.Data;


public class Controller
{
    private SqlConnection connection;

    public Controller(SqlConnection sqlConnection)
    {
        this.connection = sqlConnection;
    }
    public bool TestConnection()
    {
        try
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                // Perform a simple query to ensure the connection is valid
                SqlCommand command = new SqlCommand("SELECT 1", connection);
                command.ExecuteScalar();
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }
   
    public DataTable GetData(string query)
    {
        DataTable dataTable = new DataTable();
        try
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(dataTable);
        }
        catch (Exception ex)
        {
            // Handle exceptions
            throw new Exception("Error retrieving data: " + ex.Message);
        }
        return dataTable;
    }
}