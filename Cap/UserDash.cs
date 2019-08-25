using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cap
{
    public partial class UserDash : Form
    {
        public UserDash(string username)
        {
            InitializeComponent();
            SqlCommand com;
            var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
            c.Open();
            var select = "SELECT * FROM Student WHERE FirstName = '" + username + "'";
            com = new SqlCommand(select, c);
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                fNameShow.Text = reader["FirstName"].ToString();
                lNameShow.Text = reader["LastName"].ToString();
                pNumShow.Text = reader["PhoneNumber"].ToString();
                emailShow.Text = reader["Email"].ToString();
                addressShow.Text = reader["PhysicalAddress"].ToString();
                fieldBoxShow.Text = reader["Field"].ToString();
                reader.Close();
                c.Close();
            }
        }

        private void UserDash_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search SearchWindow = new Search();

            SearchWindow.Show();
        }

        private void classesPage_Click(object sender, EventArgs e)
        {

            InitializeComponent();
            SqlCommand com;
            int totalClasses;
            var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
            c.Open();
            var select = "SELECT * FROM StudentRecords WHERE StudentID = '" + 1 + "'";
            com = new SqlCommand(select, c);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            totalClasses = reader.GetInt32(1);
            MessageBox.Show("" + totalClasses + "");
            if (totalClasses > 3)
            {
                MessageBox.Show("Sorry, you're already enrolled in the maximum amount of classes!");
            }
            reader.Close();
            c.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("You've reached the maximum amount of classes at one time.\nYour total classes are: " + totalClasses);
            }
            else
            {

            }
            reader.Close();
            c.Close();
        }
    }
}
