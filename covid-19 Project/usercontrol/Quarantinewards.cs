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

namespace covid_19_Project
{
    public partial class Quarantinewards : UserControl
    {
        public Quarantinewards()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Quarantinewards_Load(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT * FROM Quarantine_wards";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string wardid = textBoxwardid.Text.ToString();
                string address = textBoxaddress.Text.ToString();
                string capacity = textBoxcapacity.Text.ToString();
                string totalroom = textBoxtotalroom.Text.ToString();
                string staffcount = textBoxstaffcount.Text.ToString();
                string recovered = textBoxrecovered.Text.ToString();

                string q = "insert into Quarantine_wards values ('" + wardid + "','" + capacity + "','" + address + "','" + totalroom + "','" + staffcount + "','" + recovered + "')";

                SqlCommand cmd = new SqlCommand(q, con);

                int n1 = cmd.ExecuteNonQuery();

                textBoxwardid.Clear();
                textBoxaddress.Clear();
                textBoxcapacity.Clear();
                textBoxtotalroom.Clear();
                textBoxstaffcount.Clear();
                textBoxrecovered.Clear();

                con.Close();

                if (n1 == 1)
                {
                    MessageBox.Show("New Record Added successfuly..!");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
        }
    }
}
