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
    public partial class International : UserControl
    {
        public International()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True";
        private void International_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM internationalhome WHERE primary_key=1", con);
            SqlDataReader re = cmd.ExecuteReader();
            if (re.Read())
            {
                textBoxconfirmed.Text = re.GetString(re.GetOrdinal("confirmed"));
                textBoxdeaths.Text = re.GetString(re.GetOrdinal("deaths"));
                textBoxrecovered.Text = re.GetString(re.GetOrdinal("recovered"));
                textBoxtodaycases.Text = re.GetString(re.GetOrdinal("todaycases"));
                textBoxtodaydeaths.Text = re.GetString(re.GetOrdinal("todaydeaths"));
                textBoxcritical.Text = re.GetString(re.GetOrdinal("critical"));
            }
            else
            {
                MessageBox.Show("Please enter a valid item barcode");
            }
            re.Close();
        }

        private void textBoxrecovered_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
