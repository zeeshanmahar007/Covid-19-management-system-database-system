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
    public partial class IsolationWards : UserControl
    {
        public IsolationWards()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True");

        private void IsolationWards_Load(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT * FROM Isolation_ward";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
                string nopatient = textBoxnopatients.Text.ToString();
                string recovered = textBoxrecovered.Text.ToString();
                string availablebeds = textBoxavailablebeds.Text.ToString();

                string q = "insert into Isolation_ward values ('" + wardid + "','" + nopatient + "','" + capacity + "','" + totalroom + "','" + recovered + "','" + availablebeds + "','"+ address +"')";

                SqlCommand cmd = new SqlCommand(q, con);

                int n1 = cmd.ExecuteNonQuery();

                textBoxwardid.Clear();
                textBoxaddress.Clear();
                textBoxcapacity.Clear();
                textBoxtotalroom.Clear();
                textBoxnopatients.Clear();
                textBoxrecovered.Clear();
                textBoxavailablebeds.Clear();

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
