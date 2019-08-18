using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var select = "SELECT * FROM Student WHERE Firstname = '" + searchBox.Text + "'";
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (lNameRB.Checked)
            {
                var select = "SELECT * FROM Student WHERE LastName = '" + searchBox.Text + "'";
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (emailRB.Checked)
            {
                var select = "SELECT * FROM Student WHERE Email = '" + searchBox.Text + "'";
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (pNumRB.Checked)
            {
                var select = "SELECT * FROM Student WHERE PhoneNumber = '" + searchBox.Text + "'";
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (pAddressRB.Checked)
            {
                var select = "SELECT * FROM Student WHERE PhysicalAddress = '" + searchBox.Text + "'";
                var c = new SqlConnection("Data Source = reddb.database.windows.net; Initial Catalog = Red_DB; Persist Security Info = True; User ID = red; Password = Passw0rd");
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Please select what you want to search for");
            }
        }
    }
}
