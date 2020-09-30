using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace covid_19_Project.usercontrol
{
    public partial class deletenewrecord : UserControl
    {
        public deletenewrecord()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxpid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void deletenewrecord_Load(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT P.*,T.Test_No,T.Condition,T.test_status FROM Patientrecord as P,Test as T Where P.P_ID=T.P_ID";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Delete From Patientrecord where P_ID='" + textBoxpid.Text.ToString() + "' ";
            string q1 = "Delete From Test where P_ID='" + textBoxpid.Text.ToString() + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            SqlDataAdapter SDA1 = new SqlDataAdapter(q1, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted...");
        }
    }
}
