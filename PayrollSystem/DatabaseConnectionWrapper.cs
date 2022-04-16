using System;
using MySql.Data.MySqlClient;
namespace PayrollSystem
{
    public class DatabaseConnectionWrapper
    {

        public MySqlConnection Connection { get; set; }

        public DatabaseConnectionWrapper()
        {
            Connection = Connect();
        }

        public MySqlConnection Connect()
        {

            string connectionString = @"host=127.0.0.1;port=3306;user id=root;password=root;database=payrollsys;";

            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            return cnn;
        }

        public void Select(MySqlCommand statement)
        {
            try
            {
                Connection.Open();

            }
            catch (Exception)
            {

                throw;
            }
            Connection.Close();
        }
    }
}