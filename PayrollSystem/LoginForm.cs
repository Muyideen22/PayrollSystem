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
            MessageBox.Show("Correct credentials. Logged in!");
            this.Hide();
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
        }
    }
}