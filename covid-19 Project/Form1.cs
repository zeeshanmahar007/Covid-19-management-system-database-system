using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covid_19_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if(pos.Y<cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if(pos.X>=this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox3.Visible = false;
            bunifuTransition1.HideSync(isolationWards1);
            bunifuTransition1.HideSync(removepatientfromQward1);
            bunifuTransition1.HideSync(addpatientinQward1);
            groupBox2.Visible = false;
            bunifuTransition1.HideSync(quarantinewards1);
            buttonchart1.Visible = false;
            buttonchart.Visible = false;
            groupBox1.Visible = false;
            bunifuTransition1.ShowSync(patientrecord1);
            groupBox1.Visible = true;
            bunifuTransition1.HideSync(userControl11);
            bunifuTransition1.HideSync(home1);
            bunifuTransition1.HideSync(international1);
            bunifuTransition1.HideSync(addnewrecord1);
            bunifuTransition1.HideSync(editnewrecord1);
            bunifuTransition1.HideSync(deletenewrecord1);
            button2.Visible = false;
            button3.Visible = false;
            panelleft.Height = buttonrecord.Height;
            panelleft.Top = buttonrecord.Top;
            
        }

        private void buttonQuarantine_Click(object sender, EventArgs e)
        {

            groupBox3.Visible = false;
            bunifuTransition1.HideSync(isolationWards1);
            bunifuTransition1.HideSync(removepatientfromQward1);
            bunifuTransition1.HideSync(addpatientinQward1);
            groupBox2.Visible = true;
            bunifuTransition1.ShowSync(quarantinewards1);
            buttonchart1.Visible = false;
            buttonchart.Visible = false;
            panelleft.Height = buttonQuarantine.Height;
            panelleft.Top = buttonQuarantine.Top;
            groupBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            bunifuTransition1.HideSync(deletenewrecord1);
            bunifuTransition1.HideSync(editnewrecord1);
            bunifuTransition1.HideSync(addnewrecord1);
            bunifuTransition1.HideSync(patientrecord1);
            bunifuTransition1.HideSync(userControl11);
            bunifuTransition1.HideSync(international1);
            bunifuTransition1.HideSync(home1);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            groupBox3.Visible = false;
            bunifuTransition1.HideSync(isolationWards1);
            bunifuTransition1.HideSync(removepatientfromQward1);
            bunifuTransition1.HideSync(addpatientinQward1);
            groupBox2.Visible = false;
            buttonchart1.Visible = false;
            buttonchart.Visible = false;
            bunifuTransition1.HideSync(quarantinewards1);
            bunifuTransition1.ShowSync(userControl11);
            bunifuTransition1.HideSync(home1);
            bunifuTransition1.HideSync(patientrecord1);
            bunifuTransition1.HideSync(international1);
            bunifuTransition1.HideSync(addnewrecord1);
            bunifuTransition1.HideSync(editnewrecord1);
            bunifuTransition1.HideSync(deletenewrecord1);
            groupBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            panelleft.Height = buttonsymptoms.Height;
            panelleft.Top = buttonsymptoms.Top;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            bunifuTransition1.ShowSync(isolationWards1);
            bunifuTransition1.HideSync(removepatientfromQward1);
            bunifuTransition1.HideSync(addpatientinQward1);
            groupBox2.Visible = false;
            bunifuTransition1.HideSync(quarantinewards1);
            buttonchart1.Visible = false;
            buttonchart.Visible = false;
            bunifuTransition1.HideSync(userControl11);
            bunifuTransition1.HideSync(home1);
            bunifuTransition1.HideSync(editnewrecord1);
            groupBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            bunifuTransition1.HideSync(deletenewrecord1);
            bunifuTransition1.HideSync(patientrecord1);
            bunifuTransition1.HideSync(addnewrecord1);
            bunifuTransition1.HideSync(international1);
            panelleft.Height = buttonisolation.Height;
            panelleft.Top = buttonisolation.Top;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            bunifuTransition1.HideSync(isolationWards1);
            bunifuTransition1.HideSync(removepatientfromQward1);
            bunifuTransition1.HideSync(addpatientinQward1);
            groupBox2.Visible = false;
            bunifuTransition1.HideSync(quarantinewards1);
            buttonchart1.Visible = false;
            buttonchart.Visible = true;
            panelleft.Height = buttonhome.Height;
            panelleft.Top = buttonhome.Top;
            bunifuTransition1.ShowSync(home1);
            groupBox1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            bunifuTransition1.HideSync(deletenewrecord1);
            bunifuTransition1.HideSync(editnewrecord1);
            bunifuTransition1.HideSync(patientrecord1);
            bunifuTransition1.HideSync(addnewrecord1);
            bunifuTransition1.HideSync(international1);
            bunifuTransition1.HideSync(userControl11);
        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            buttonchart1.Visible = true;
            buttonchart.Visible = false;
            bunifuTransition1.HideSync(home1);
            bunifuTransition1.HideSync(userControl11);
            bunifuTransition1.HideSync(deletenewrecord1);
            bunifuTransition1.ShowSync(international1);
            button2.Visible = false;
            button3.Visible = true;
        }

        private void international1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonchart1.Visible = false;
            buttonchart.Visible = true;
            bunifuTransition1.ShowSync(home1);
            button3.Visible = false;
            button2.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(patientrecord1);
            bunifuTransition1.HideSync(editnewrecord1);
            bunifuTransition1.HideSync(deletenewrecord1);
            bunifuTransition1.ShowSync(addnewrecord1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(patientrecord1);
            bunifuTransition1.HideSync(addnewrecord1);
            bunifuTransition1.HideSync(deletenewrecord1);
            bunifuTransition1.ShowSync(editnewrecord1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(patientrecord1);
            bunifuTransition1.HideSync(addnewrecord1);
            bunifuTransition1.HideSync(editnewrecord1);
            bunifuTransition1.ShowSync(deletenewrecord1);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home1.Visible = true;
            button2.Visible = true;
            addpatientinQward1.Visible = false;
            
        }

        private void buttonchart1_Click(object sender, EventArgs e)
        {
            interchart f2 = new interchart();
            f2.ShowDialog();
        }

        private void buttonchart_Click_1(object sender, EventArgs e)
        {
            pakchart f2 = new pakchart();
            f2.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void quarantinewards1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e) //add patient in wards
        {

            bunifuTransition1.HideSync(removepatientfromQward1);
            bunifuTransition1.HideSync(quarantinewards1);
            bunifuTransition1.ShowSync(addpatientinQward1);
        }

        private void removepatientfromward_Click(object sender, EventArgs e)
        {

            bunifuTransition1.ShowSync(removepatientfromQward1);
            bunifuTransition1.HideSync(addpatientinQward1);
        }

        private void addpatientinQward1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(isolationWards1);
            bunifuTransition1.HideSync(addpatientin_Iward1);
            bunifuTransition1.ShowSync(removepatientfrom_Iward1);
        }

        private void addpatientin_Iward_Click(object sender, EventArgs e)
        { 
            bunifuTransition1.HideSync(isolationWards1);
            bunifuTransition1.HideSync(removepatientfrom_Iward1);
            bunifuTransition1.ShowSync(addpatientin_Iward1);
        }
    }
}
