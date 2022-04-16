//using MySqlConnector;
using MySql.Data.MySqlClient;
namespace PayrollSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = this.password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Username/Password is needed!");
                return;
            }

            DatabaseConnectionWrapper databaseConnectionWrapper = new ();
            if (databaseConnectionWrapper != null)
            {
                
            
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();        
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM admin WHERE username = @username AND USERPASSword=PASSWORD(@user_pass);";
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("user_pass", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string user_name = (string)reader["USERNAME"];
                            string user_pass = (string)reader["USERPASSWORD"];

                            if (user_name == username)
                            {

                                string success = $"Logged in as {user_name}";
                                MessageBox.Show(success);
                                //MessageBox.Show("Correct credentials. Logged in!");
                                Hide();
                                Dashboard dashboard = new();
                                dashboard.Show();
                                return;

                            }


                        }
                        MessageBox.Show("Incorrect credentials. Try again!");

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to database! Exiting");
                    Application.Exit();
                    throw;
                }
                conn.Close();

            }



        }
    }
}