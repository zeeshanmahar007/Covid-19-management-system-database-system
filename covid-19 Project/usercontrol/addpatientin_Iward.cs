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
    public partial class addpatientin_Iward : UserControl
    {
        public addpatientin_Iward()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True");

        private void addpatientin_Iward_Load(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT * FROM Isolation_ward";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;

            string q1 = "select * from Patientrecord where Quarantine_Ward IS NULL AND Isolation_Ward IS NULL;";
            SqlDataAdapter SDA1 = new SqlDataAdapter(q1, con);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            con.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Update Patientrecord SET Isolation_Ward='" + textBoxwardid.Text.ToString() + "' Where P_ID ='" + textBoxpid.Text.ToString() + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            int n = SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            if (n == 1)
            {
                MessageBox.Show("Sucessfully Admitted Patient In Isolation Ward...");
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxwardid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxpid.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
