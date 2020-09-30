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
    public partial class editnewrecord : UserControl
    {
        public editnewrecord()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AQ49O2F;Initial Catalog=Covid19;Integrated Security=True");
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxpid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxpname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxpaddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxpcontact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxgender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxage.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBoxpcnic.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBoxtestno.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBoxcondition.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBoxteststatus.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void editnewrecord_Load(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT P.*,T.Test_No,T.Condition,T.test_status FROM Patientrecord as P,Test as T Where P.P_ID=T.P_ID";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void submit_Click(object sender, EventArgs e)
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
            con.Open();
            string q = "Update Patientrecord SET P_ID='" + ID + "',P_Name='" + name + "',P_Address='" + address + "',P_Contact='" + Contact + "',Gender='" + Gender + "',Age='" + Age + "',P_Cnic='" + cnic + "' Where P_ID='"+ ID+"' ";
            string q1 = "Update Test SET P_ID= '" + ID + "',Test_No='" + Test_No + "',Condition='" + Condition + "',test_status='" + Test_Status + "'Where P_ID='" + ID + "'";

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
                MessageBox.Show("Record Updated successfuly..!");
            }
            else
            {
                MessageBox.Show("Something Went Wrong...");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
