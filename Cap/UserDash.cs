using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cap
{
    public partial class UserDash : Form
    {
        private int totalClasses;
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
                studentIDBox.Text = reader["studentID"].ToString();
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

        public void UserDash_Load(object sender, EventArgs e)
        {

            SqlCommand com;
            int totalClasses;
            int maxClasses = 3;
            var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
            c.Open();
            var select = "SELECT * FROM StudentRecords WHERE StudentID = '" + studentIDBox.Text + "'";
            com = new SqlCommand(select, c);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            totalClasses = reader.GetInt32(1);
            apologyText.Visible = false;
            registerMoreClassesLabel.Visible = false;
            if (totalClasses >= maxClasses)
            {
                careerCourse1.Visible = false;
                careerCourse2.Visible = false;
                generalCourse1.Visible = false;
                generalCourse2.Visible = false;
                registerClassLabel.Visible = false;
                TestButton.Visible = false;
                apologyText.Visible = true;

            }
            else
            {
                registerMoreClassesLabel.Visible = true;
            }
            reader.Close();
            c.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search SearchWindow = new Search();

            SearchWindow.Show();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (generalCourse1.Checked)
            {
                totalClasses++;
                SqlCommand com;
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                c.Open();
                var select = "SELECT * FROM StudentRecords WHERE StudentID = '" + studentIDBox.Text + "'";
                com = new SqlCommand(select, c);
                MessageBox.Show("You're now registered for " + generalCourse1.Text + "!");

            }
            if (generalCourse2.Checked)
            {
                MessageBox.Show("You're now registered for "+ generalCourse2.Text + "!");

            }
            if(careerCourse1.Checked)
            {
                MessageBox.Show("You're now registered for "+ careerCourse1.Text + "!");

            }
            if (careerCourse2.Checked)
            {
                MessageBox.Show("You're now registered for " + careerCourse2.Text + "!");

            }
        }
        public int GSTC { get; set; }
    }
}
