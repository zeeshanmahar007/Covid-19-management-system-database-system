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

namespace covid_19_Project
{
    public partial class interchart : Form
    {
        public interchart()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True";
        private void interchart_Load(object sender, EventArgs e)
        {
            int no = 1;
            string x = "",x1="",x2="";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM internationalhome WHERE primary_key='" + no + "'", con);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    x = re.GetString(re.GetOrdinal("confirmed"));
                    x1 = re.GetString(re.GetOrdinal("deaths"));
                    x2 = re.GetString(re.GetOrdinal("recovered"));

                chart1.Series["Series1"].Points.AddXY("Confirmed", x);
                chart1.Series["Series1"].Points.AddXY("Deaths", x1);
                chart1.Series["Series1"].Points.AddXY("Recovered", x2);
            }
                else
                {
                    MessageBox.Show("Something went Wrong With Database Connection...");
                }
                re.Close();
            }
    }
}
