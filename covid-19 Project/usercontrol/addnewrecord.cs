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
    public partial class addnewrecord : UserControl
    {
        public addnewrecord()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True";
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addnewrecord_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string name = textBoxpname.Text.ToString();
                string address = textBoxpaddress.Text.ToString();
                string cnic = textBoxpcnic.Text.ToString();
                string ID = textBoxpid.Text.ToString();
                string Contact = textBoxpcontact.Text.ToString();
                string Gender = textBoxgender.Text.ToString();
                string Age = textBoxage.Text.ToString();
                string Test_No = textBoxtestno.Text.ToString();
                string Condition = textBoxcondition.Text.ToString();
                string Test_Status = textBoxteststatus.Text.ToString();

                string q = "insert into Patientrecord values ('" + ID + "','" + name + "','" + address + "','" + Contact + "','" + Gender + "','" + Age + "','" + cnic + "')";
                string q1 = "insert into Test values ('" + ID + "','" + Test_No + "','" + Condition + "','" + Test_Status + "')";
                
                SqlCommand cmd = new SqlCommand(q, con);
                SqlCommand cmd1 = new SqlCommand(q1, con);

                int n1 = cmd.ExecuteNonQuery();
                int n2 = cmd1.ExecuteNonQuery();

                textBoxpname.Clear();
                textBoxpaddress.Clear();
                textBoxpcnic.Clear();
                textBoxpid.Clear();
                textBoxpcontact.Clear();
                textBoxgender.Clear();
                textBoxage.Clear();
                textBoxtestno.Clear();
                textBoxcondition.Clear();
                textBoxteststatus.Clear();

                con.Close();

                if (n1 == 1 && n2 == 1)
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
