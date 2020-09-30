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
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True";

        private void home_Load(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM pakhome WHERE primary_key=1", con);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    textBoxconfirmed.Text = re.GetString(re.GetOrdinal("confirmed"));
                    textBoxdeaths.Text = re.GetString(re.GetOrdinal("death"));
                    textBoxrecovered.Text = re.GetString(re.GetOrdinal("recovered"));
                    textBoxsindh.Text = re.GetString(re.GetOrdinal("sindh"));
                    textBoxislamabad.Text = re.GetString(re.GetOrdinal("islamabad"));
                    textBoxkp.Text = re.GetString(re.GetOrdinal("kp"));
                    textBoxajk.Text = re.GetString(re.GetOrdinal("ajk"));
                    textBoxgb.Text = re.GetString(re.GetOrdinal("gb"));
                    textBoxpunjab.Text = re.GetString(re.GetOrdinal("punjab"));
                    textBoxbalochistan.Text = re.GetString(re.GetOrdinal("balochistan"));


            }
                else
                {
                    MessageBox.Show("Please enter a valid item barcode");
                }
                re.Close();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
