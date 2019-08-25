using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cap
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (fNameRB.Checked)
            {
                SqlCommand com;
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                c.Open();
                var select = "SELECT * FROM Student WHERE Firstname = '" + searchBox.Text + "'";
                com = new SqlCommand(select, c);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    fNameShow.Text = reader["FirstName"].ToString();
                    lNameShow.Text = reader["LastName"].ToString();
                    pNumShow.Text = reader["PhoneNumber"].ToString();
                    emailShow.Text = reader["Email"].ToString();
                    addressShow.Text = reader["PhysicalAddress"].ToString();
                    reader.Close();
                    c.Close();
                }
            }
            else if (lNameRB.Checked)
            {

                SqlCommand com;
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                c.Open();
                var select = "SELECT * FROM Student WHERE LastName = '" + searchBox.Text + "'";
                com = new SqlCommand(select, c);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    fNameShow.Text = reader["FirstName"].ToString();
                    lNameShow.Text = reader["LastName"].ToString();
                    pNumShow.Text = reader["PhoneNumber"].ToString();
                    emailShow.Text = reader["Email"].ToString();
                    addressShow.Text = reader["PhysicalAddress"].ToString();

                    reader.Close();
                    c.Close();
                }
            }
            else if (emailRB.Checked)
            {
                SqlCommand com;
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                c.Open();
                var select = "SELECT * FROM Student WHERE EmailAddress = '" + searchBox.Text + "'";
                com = new SqlCommand(select, c);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    fNameShow.Text = reader["FirstName"].ToString();
                    lNameShow.Text = reader["LastName"].ToString();
                    pNumShow.Text = reader["PhoneNumber"].ToString();
                    emailShow.Text = reader["Email"].ToString();
                    addressShow.Text = reader["PhysicalAddress"].ToString();

                    reader.Close();
                    c.Close();
                }
            }
            else if (pNumRB.Checked)
            {
                SqlCommand com;
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                c.Open();
                var select = "SELECT * FROM Student WHERE PhoneNumber = '" + searchBox.Text + "'";
                com = new SqlCommand(select, c);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    fNameShow.Text = reader["FirstName"].ToString();
                    lNameShow.Text = reader["LastName"].ToString();
                    pNumShow.Text = reader["PhoneNumber"].ToString();
                    emailShow.Text = reader["Email"].ToString();
                    addressShow.Text = reader["PhysicalAddress"].ToString();

                    reader.Close();
                    c.Close();
                }
            }
            else if (pAddressRB.Checked)
            {
                SqlCommand com;
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                c.Open();
                var select = "SELECT * FROM Student WHERE PhysicalAddress = '" + searchBox.Text + "'";
                com = new SqlCommand(select, c);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    fNameShow.Text = reader["FirstName"].ToString();
                    lNameShow.Text = reader["LastName"].ToString();
                    pNumShow.Text = reader["PhoneNumber"].ToString();
                    emailShow.Text = reader["Email"].ToString();
                    addressShow.Text = reader["PhysicalAddress"].ToString();

                    reader.Close();
                    c.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select what you want to search for");
            }
        }
    }
}
