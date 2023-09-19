using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ceylon
{
    public partial class DestinationDisplay : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dtUser = new DataTable();
        public DestinationDisplay()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Close();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Hanthana_Mountain_Range");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void DestinationDisplay_Load(object sender, EventArgs e)
        {
            SqlCommand insertComand = new SqlCommand("Select * From Destination");
            int row = obj2.executeQuery(insertComand);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(insertComand);
            DataTable dtUser = new DataTable();
            sqlDataAdapter.Fill(dtUser);
            DataGridView4.DataSource = dtUser;
            this.TopMost = true;
        }
    }
}
