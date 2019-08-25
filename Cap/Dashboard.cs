using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cap
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            usernameTextBox.Text.ToString() ;

        }
        private void Dashboard_Load()
        {
        }
        private void searchStudents_Click(object sender, EventArgs e)
        {
            Search SearchWindow = new Search();

            SearchWindow.Show();
        }

        private void addFormButton_Click(object sender, EventArgs e)
        {
            Add addWindow = new Add();

            addWindow.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text != "" && passwordBox.Text != "")
            {

                UserDash UserDash = new UserDash(usernameTextBox.Text);
                UserDash.Show();

            }
            else
            {
                MessageBox.Show("Please enter a valid username or password!");
            }

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the help box, but right now it's the diagnostic box.");
            SqlCommand com;
            int totalClasses;
            var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
            c.Open();
            var select = "SELECT * FROM StudentRecords WHERE StudentID = '" + 1 + "'";
            com = new SqlCommand(select, c);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            totalClasses = reader.GetInt32(1);
            if (totalClasses >= 3)
            {
                MessageBox.Show("You've reached the maximum amount of classes at one time.\nYour total classes are: "+totalClasses);
            }
            else
            {

            }
            reader.Close();
            c.Close();
        }
    }
}
