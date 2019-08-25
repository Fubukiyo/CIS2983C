using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cap
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            connetionString = @"Data Source=reddb.database.windows.net;Initial Catalog=Red_DB;User ID=red;Password=Passw0rd";
            cnn = new SqlConnection(connetionString);

            cnn.Open();

            String fName = fNameBox.Text;
            String lName = lNameBox.Text;
            String pNumber = pNumberBox.Text;
            String email = emailBox.Text;
            String pAddress = pAddressBox.Text;
            String choice = "";
            if (itField.Checked)
            {
                choice = "IT";
            }
            else if(medicalField.Checked)
            {
                choice = "Medical";
            }
            else if(businessField.Checked)
            {
                choice = "Business";
            }
            else
            {
                MessageBox.Show("Please choose your career path!");
            }

            sql = "INSERT INTO Student VALUES ('" + fName + "', '" + lName + "', '" + pNumber + "', '" + email + "', '" + pAddress + "', '" + choice + "'  )";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Registration complete!");

            fNameBox.Text = "";
            lNameBox.Text = "";
            pNumberBox.Text = "";
            emailBox.Text = "";
            pAddressBox.Text = "";
            choice = "";

            command.Dispose();
            cnn.Close();
        }
    }
}
