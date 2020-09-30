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
    public partial class graph : UserControl
    {
        public graph()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True";
        private void graph_Load(object sender, EventArgs e)
        {
            int no = 1;
            string x="";
            int y=0;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            for (int i = 0; i < 3; i++)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dataforgraph WHERE primary_key='"+no+"'" , con);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    x = re.GetString(re.GetOrdinal("Name"));
                    y = re.GetInt32(re.GetOrdinal("Cases"));

                    chart1.Series["Series1"].Points.AddXY(x, y);
                }
                else
                {
                    MessageBox.Show("Something went Wrong With Database...");
                }
                re.Close();
                no++;
            }
            
        }
    }
}
