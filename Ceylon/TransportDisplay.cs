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
    public partial class TransportDisplay : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dtUser = new DataTable();
        public TransportDisplay()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TransportDisplay_Load(object sender, EventArgs e)
        {
            SqlCommand insertComand = new SqlCommand("Select * From Transport");
            int row = obj2.executeQuery(insertComand);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(insertComand);
            DataTable dtUser = new DataTable();
            sqlDataAdapter.Fill(dtUser);
            DataGridView4.DataSource = dtUser;
            this.TopMost = true;
        }
    }
}
