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
    public partial class removepatientfromQward : UserControl
    {
        public removepatientfromQward()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True");
        private void removepatientfromQward_Load(object sender, EventArgs e)
        {

            con.Open();
            string q = "SELECT * FROM Patientrecord Where Quarantine_Ward IS NOT NULL";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxwardid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxpid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Update Patientrecord SET Quarantine_Ward = NULL Where P_ID ='" + textBoxpid.Text.ToString() + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            int n = SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            if (n == 1)
            {
                MessageBox.Show("Sucessfully Removed Patient From Quarantine Ward...");
            }
            else
            {
                MessageBox.Show("Error...");
            }
        }
    }
}
