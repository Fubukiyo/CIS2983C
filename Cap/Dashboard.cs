using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
    }
}
