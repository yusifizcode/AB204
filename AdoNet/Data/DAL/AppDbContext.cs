using System.Data;
using System.Data.SqlClient;

namespace Data.DAL
{
    public class AppDbContext
    {
        string conString = "Server=DESKTOP-L6JGBQE\\SQLEXPRESS;Database=AdoNetAB204;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true;";
        public SqlConnection sqlConnection;

        public AppDbContext()
        {
            sqlConnection = new SqlConnection(conString);
        }

        public void NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            var result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine("Completed successfully: " + result);
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
            sqlConnection.Close();
        }

        public DataTable Query(string selectCommand)
        {
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
