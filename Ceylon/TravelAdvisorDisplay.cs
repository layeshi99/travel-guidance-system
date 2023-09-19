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
    public partial class TravelAdvisorDisplay : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dtUser = new DataTable();
        public TravelAdvisorDisplay()
        {
            InitializeComponent();
        }

 
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Close();
        }

        private void TravelAdvisorDisplay_Load(object sender, EventArgs e)
        {
            SqlCommand insertComand = new SqlCommand("Select * From Travel_Advisor");
            int row = obj2.executeQuery(insertComand);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(insertComand);
            DataTable dtUser = new DataTable();
            sqlDataAdapter.Fill(dtUser);
            DataGridView3.DataSource = dtUser;
            this.TopMost = true;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
