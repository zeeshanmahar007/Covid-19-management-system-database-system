namespace covid_19_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonhome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonsymptoms = new System.Windows.Forms.Button();
            this.buttonisolation = new System.Windows.Forms.Button();
            this.buttonQuarantine = new System.Windows.Forms.Button();
            this.buttonrecord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelleft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removepatientfrom_Iward1 = new covid_19_Project.usercontrol.removepatientfrom_Iward();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.addpatientin_Iward = new System.Windows.Forms.Button();
            this.isolationWards1 = new covid_19_Project.usercontrol.IsolationWards();
            this.removepatientfromQward1 = new covid_19_Project.usercontrol.removepatientfromQward();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removepatientfromward = new System.Windows.Forms.Button();
            this.addpatientinward = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonchart1 = new System.Windows.Forms.Button();
            this.buttonchart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.addpatientinQward1 = new covid_19_Project.usercontrol.addpatientinQward();
            this.quarantinewards1 = new covid_19_Project.Quarantinewards();
            this.home1 = new covid_19_Project.usercontrol.home();
            this.userControl11 = new covid_19_Project.usercontrol.UserControl1();
            this.international1 = new covid_19_Project.usercontrol.International();
            this.addnewrecord1 = new covid_19_Project.usercontrol.addnewrecord();
            this.editnewrecord1 = new covid_19_Project.usercontrol.editnewrecord();
            this.deletenewrecord1 = new covid_19_Project.usercontrol.deletenewrecord();
            this.graph1 = new covid_19_Project.usercontrol.graph();
            this.patientrecord1 = new covid_19_Project.usercontrol.patientrecord();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.addpatientin_Iward1 = new covid_19_Project.usercontrol.addpatientin_Iward();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonhome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonsymptoms);
            this.panel1.Controls.Add(this.buttonisolation);
            this.panel1.Controls.Add(this.buttonQuarantine);
            this.panel1.Controls.Add(this.buttonrecord);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 554);
            this.panel1.TabIndex = 0;
            // 
            // buttonhome
            // 
            this.buttonhome.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.buttonhome, BunifuAnimatorNS.DecorationType.None);
            this.buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhome.Image = global::covid_19_Project.Properties.Resources.web;
            this.buttonhome.Location = new System.Drawing.Point(-3, 122);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(177, 82);
            this.buttonhome.TabIndex = 5;
            this.buttonhome.Text = "  Home";
            this.buttonhome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonhome.UseVisualStyleBackColor = false;
            this.buttonhome.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel3
            // 
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(174, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 27);
            this.panel3.TabIndex = 3;
            // 
            // buttonsymptoms
            // 
            this.buttonsymptoms.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.buttonsymptoms, BunifuAnimatorNS.DecorationType.None);
            this.buttonsymptoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsymptoms.Image = global::covid_19_Project.Properties.Resources.symptoms11;
            this.buttonsymptoms.Location = new System.Drawing.Point(0, 465);
            this.buttonsymptoms.Name = "buttonsymptoms";
            this.buttonsymptoms.Size = new System.Drawing.Size(174, 85);
            this.buttonsymptoms.TabIndex = 4;
            this.buttonsymptoms.Text = "Symptoms ";
            this.buttonsymptoms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonsymptoms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonsymptoms.UseVisualStyleBackColor = false;
            this.buttonsymptoms.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonisolation
            // 
            this.buttonisolation.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.buttonisolation, BunifuAnimatorNS.DecorationType.None);
            this.buttonisolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonisolation.Image = global::covid_19_Project.Properties.Resources.isolation;
            this.buttonisolation.Location = new System.Drawing.Point(0, 382);
            this.buttonisolation.Name = "buttonisolation";
            this.buttonisolation.Size = new System.Drawing.Size(174, 90);
            this.buttonisolation.TabIndex = 3;
            this.buttonisolation.Text = "Isolation Wards";
            this.buttonisolation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonisolation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonisolation.UseVisualStyleBackColor = false;
            this.buttonisolation.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonQuarantine
            // 
            this.buttonQuarantine.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.buttonQuarantine, BunifuAnimatorNS.DecorationType.None);
            this.buttonQuarantine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuarantine.Image = global::covid_19_Project.Properties.Resources.lock2;
            this.buttonQuarantine.Location = new System.Drawing.Point(0, 296);
            this.buttonQuarantine.Name = "buttonQuarantine";
            this.buttonQuarantine.Size = new System.Drawing.Size(174, 87);
            this.buttonQuarantine.TabIndex = 2;
            this.buttonQuarantine.Text = "Quarantine Wards";
            this.buttonQuarantine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonQuarantine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonQuarantine.UseVisualStyleBackColor = false;
            this.buttonQuarantine.Click += new System.EventHandler(this.buttonQuarantine_Click);
            // 
            // buttonrecord
            // 
            this.buttonrecord.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.buttonrecord, BunifuAnimatorNS.DecorationType.None);
            this.buttonrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonrecord.Image = global::covid_19_Project.Properties.Resources.file12;
            this.buttonrecord.Location = new System.Drawing.Point(0, 203);
            this.buttonrecord.Name = "buttonrecord";
            this.buttonrecord.Size = new System.Drawing.Size(174, 97);
            this.buttonrecord.TabIndex = 1;
            this.buttonrecord.Text = "Patient Record";
            this.buttonrecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonrecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonrecord.UseVisualStyleBackColor = false;
            this.buttonrecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::covid_19_Project.Properties.Resources._24209111;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Yellow;
            this.bunifuTransition1.SetDecoration(this.panelleft, BunifuAnimatorNS.DecorationType.None);
            this.panelleft.Location = new System.Drawing.Point(174, 122);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(7, 84);
            this.panelleft.TabIndex = 1;
            this.panelleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleft_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.isolationWards1);
            this.panel2.Controls.Add(this.removepatientfromQward1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.buttonchart1);
            this.panel2.Controls.Add(this.buttonchart);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.addpatientinQward1);
            this.panel2.Controls.Add(this.quarantinewards1);
            this.panel2.Controls.Add(this.home1);
            this.panel2.Controls.Add(this.userControl11);
            this.panel2.Controls.Add(this.international1);
            this.panel2.Controls.Add(this.addnewrecord1);
            this.panel2.Controls.Add(this.editnewrecord1);
            this.panel2.Controls.Add(this.deletenewrecord1);
            this.panel2.Controls.Add(this.graph1);
            this.panel2.Controls.Add(this.patientrecord1);
            this.panel2.Controls.Add(this.addpatientin_Iward1);
            this.panel2.Controls.Add(this.removepatientfrom_Iward1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(180, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 512);
            this.panel2.TabIndex = 2;
            // 
            // removepatientfrom_Iward1
            // 
            this.removepatientfrom_Iward1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.removepatientfrom_Iward1, BunifuAnimatorNS.DecorationType.None);
            this.removepatientfrom_Iward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removepatientfrom_Iward1.Location = new System.Drawing.Point(0, 0);
            this.removepatientfrom_Iward1.Margin = new System.Windows.Forms.Padding(5);
            this.removepatientfrom_Iward1.Name = "removepatientfrom_Iward1";
            this.removepatientfrom_Iward1.Size = new System.Drawing.Size(742, 512);
            this.removepatientfrom_Iward1.TabIndex = 39;
            this.removepatientfrom_Iward1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.addpatientin_Iward);
            this.bunifuTransition1.SetDecoration(this.groupBox3, BunifuAnimatorNS.DecorationType.None);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(14, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 98);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Isolation Ward Operations";
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(471, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 32);
            this.button7.TabIndex = 8;
            this.button7.Text = "Remove Patient From Ward";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // addpatientin_Iward
            // 
            this.addpatientin_Iward.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.addpatientin_Iward, BunifuAnimatorNS.DecorationType.None);
            this.addpatientin_Iward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addpatientin_Iward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpatientin_Iward.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addpatientin_Iward.Location = new System.Drawing.Point(283, 44);
            this.addpatientin_Iward.Name = "addpatientin_Iward";
            this.addpatientin_Iward.Size = new System.Drawing.Size(174, 32);
            this.addpatientin_Iward.TabIndex = 2;
            this.addpatientin_Iward.Text = "Add Patient In Ward";
            this.addpatientin_Iward.UseVisualStyleBackColor = false;
            this.addpatientin_Iward.Click += new System.EventHandler(this.addpatientin_Iward_Click);
            // 
            // isolationWards1
            // 
            this.isolationWards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.isolationWards1, BunifuAnimatorNS.DecorationType.None);
            this.isolationWards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isolationWards1.Location = new System.Drawing.Point(0, 0);
            this.isolationWards1.Margin = new System.Windows.Forms.Padding(5);
            this.isolationWards1.Name = "isolationWards1";
            this.isolationWards1.Size = new System.Drawing.Size(742, 512);
            this.isolationWards1.TabIndex = 37;
            this.isolationWards1.Visible = false;
            // 
            // removepatientfromQward1
            // 
            this.removepatientfromQward1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.removepatientfromQward1, BunifuAnimatorNS.DecorationType.None);
            this.removepatientfromQward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removepatientfromQward1.Location = new System.Drawing.Point(0, 0);
            this.removepatientfromQward1.Margin = new System.Windows.Forms.Padding(5);
            this.removepatientfromQward1.Name = "removepatientfromQward1";
            this.removepatientfromQward1.Size = new System.Drawing.Size(742, 512);
            this.removepatientfromQward1.TabIndex = 36;
            this.removepatientfromQward1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removepatientfromward);
            this.groupBox2.Controls.Add(this.addpatientinward);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(15, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 98);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quarantine Ward Operations";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // removepatientfromward
            // 
            this.removepatientfromward.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.removepatientfromward, BunifuAnimatorNS.DecorationType.None);
            this.removepatientfromward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removepatientfromward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removepatientfromward.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.removepatientfromward.Location = new System.Drawing.Point(471, 44);
            this.removepatientfromward.Name = "removepatientfromward";
            this.removepatientfromward.Size = new System.Drawing.Size(216, 32);
            this.removepatientfromward.TabIndex = 8;
            this.removepatientfromward.Text = "Remove Patient From Ward";
            this.removepatientfromward.UseVisualStyleBackColor = false;
            this.removepatientfromward.Click += new System.EventHandler(this.removepatientfromward_Click);
            // 
            // addpatientinward
            // 
            this.addpatientinward.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.addpatientinward, BunifuAnimatorNS.DecorationType.None);
            this.addpatientinward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addpatientinward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpatientinward.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addpatientinward.Location = new System.Drawing.Point(283, 44);
            this.addpatientinward.Name = "addpatientinward";
            this.addpatientinward.Size = new System.Drawing.Size(174, 32);
            this.addpatientinward.TabIndex = 2;
            this.addpatientinward.Text = "Add Patient In Ward";
            this.addpatientinward.UseVisualStyleBackColor = false;
            this.addpatientinward.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(467, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 38);
            this.button3.TabIndex = 25;
            this.button3.Text = "Pakistan Cases Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonchart1
            // 
            this.bunifuTransition1.SetDecoration(this.buttonchart1, BunifuAnimatorNS.DecorationType.None);
            this.buttonchart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonchart1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchart1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonchart1.Location = new System.Drawing.Point(291, 5);
            this.buttonchart1.Name = "buttonchart1";
            this.buttonchart1.Size = new System.Drawing.Size(160, 38);
            this.buttonchart1.TabIndex = 33;
            this.buttonchart1.Text = "Show on Chart";
            this.buttonchart1.UseVisualStyleBackColor = true;
            this.buttonchart1.Visible = false;
            this.buttonchart1.Click += new System.EventHandler(this.buttonchart1_Click);
            // 
            // buttonchart
            // 
            this.bunifuTransition1.SetDecoration(this.buttonchart, BunifuAnimatorNS.DecorationType.None);
            this.buttonchart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonchart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchart.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonchart.Location = new System.Drawing.Point(291, 5);
            this.buttonchart.Name = "buttonchart";
            this.buttonchart.Size = new System.Drawing.Size(160, 38);
            this.buttonchart.TabIndex = 32;
            this.buttonchart.Text = "Show on Chart";
            this.buttonchart.UseVisualStyleBackColor = true;
            this.buttonchart.Click += new System.EventHandler(this.buttonchart_Click_1);
            // 
            // button2
            // 
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(467, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "International Cases Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button6);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(17, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 89);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Operations";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(563, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(471, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(378, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 32);
            this.button6.TabIndex = 2;
            this.button6.Text = "Add New";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // addpatientinQward1
            // 
            this.addpatientinQward1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.addpatientinQward1, BunifuAnimatorNS.DecorationType.None);
            this.addpatientinQward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addpatientinQward1.Location = new System.Drawing.Point(0, 0);
            this.addpatientinQward1.Margin = new System.Windows.Forms.Padding(5);
            this.addpatientinQward1.Name = "addpatientinQward1";
            this.addpatientinQward1.Size = new System.Drawing.Size(742, 512);
            this.addpatientinQward1.TabIndex = 9;
            this.addpatientinQward1.Visible = false;
            this.addpatientinQward1.Load += new System.EventHandler(this.addpatientinQward1_Load);
            // 
            // quarantinewards1
            // 
            this.quarantinewards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.quarantinewards1, BunifuAnimatorNS.DecorationType.None);
            this.quarantinewards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quarantinewards1.Location = new System.Drawing.Point(0, 0);
            this.quarantinewards1.Margin = new System.Windows.Forms.Padding(5);
            this.quarantinewards1.Name = "quarantinewards1";
            this.quarantinewards1.Size = new System.Drawing.Size(742, 512);
            this.quarantinewards1.TabIndex = 34;
            this.quarantinewards1.Visible = false;
            this.quarantinewards1.Load += new System.EventHandler(this.quarantinewards1_Load);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(5);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(742, 512);
            this.home1.TabIndex = 1;
            this.home1.Visible = false;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.userControl11, BunifuAnimatorNS.DecorationType.None);
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(742, 512);
            this.userControl11.TabIndex = 0;
            this.userControl11.Visible = false;
            // 
            // international1
            // 
            this.international1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.international1, BunifuAnimatorNS.DecorationType.None);
            this.international1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.international1.Location = new System.Drawing.Point(0, 0);
            this.international1.Name = "international1";
            this.international1.Size = new System.Drawing.Size(742, 512);
            this.international1.TabIndex = 24;
            this.international1.Visible = false;
            this.international1.Load += new System.EventHandler(this.international1_Load);
            // 
            // addnewrecord1
            // 
            this.addnewrecord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.addnewrecord1, BunifuAnimatorNS.DecorationType.None);
            this.addnewrecord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addnewrecord1.Location = new System.Drawing.Point(0, 0);
            this.addnewrecord1.Margin = new System.Windows.Forms.Padding(5);
            this.addnewrecord1.Name = "addnewrecord1";
            this.addnewrecord1.Size = new System.Drawing.Size(742, 512);
            this.addnewrecord1.TabIndex = 28;
            this.addnewrecord1.Visible = false;
            // 
            // editnewrecord1
            // 
            this.editnewrecord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.editnewrecord1, BunifuAnimatorNS.DecorationType.None);
            this.editnewrecord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editnewrecord1.Location = new System.Drawing.Point(0, 0);
            this.editnewrecord1.Margin = new System.Windows.Forms.Padding(5);
            this.editnewrecord1.Name = "editnewrecord1";
            this.editnewrecord1.Size = new System.Drawing.Size(742, 512);
            this.editnewrecord1.TabIndex = 29;
            this.editnewrecord1.Visible = false;
            // 
            // deletenewrecord1
            // 
            this.deletenewrecord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.deletenewrecord1, BunifuAnimatorNS.DecorationType.None);
            this.deletenewrecord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletenewrecord1.Location = new System.Drawing.Point(0, 0);
            this.deletenewrecord1.Margin = new System.Windows.Forms.Padding(5);
            this.deletenewrecord1.Name = "deletenewrecord1";
            this.deletenewrecord1.Size = new System.Drawing.Size(742, 512);
            this.deletenewrecord1.TabIndex = 30;
            this.deletenewrecord1.Visible = false;
            // 
            // graph1
            // 
            this.graph1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.graph1, BunifuAnimatorNS.DecorationType.None);
            this.graph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graph1.Location = new System.Drawing.Point(0, 0);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(742, 512);
            this.graph1.TabIndex = 31;
            this.graph1.Visible = false;
            // 
            // patientrecord1
            // 
            this.patientrecord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.patientrecord1, BunifuAnimatorNS.DecorationType.None);
            this.patientrecord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientrecord1.Location = new System.Drawing.Point(0, 0);
            this.patientrecord1.Name = "patientrecord1";
            this.patientrecord1.Size = new System.Drawing.Size(742, 512);
            this.patientrecord1.TabIndex = 26;
            this.patientrecord1.Visible = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation5;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelHeader.Controls.Add(this.button1);
            this.bunifuTransition1.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Location = new System.Drawing.Point(174, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(752, 36);
            this.panelHeader.TabIndex = 1;
            // 
            // button1
            // 
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::covid_19_Project.Properties.Resources.signs1;
            this.button1.Location = new System.Drawing.Point(710, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // addpatientin_Iward1
            // 
            this.addpatientin_Iward1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuTransition1.SetDecoration(this.addpatientin_Iward1, BunifuAnimatorNS.DecorationType.None);
            this.addpatientin_Iward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addpatientin_Iward1.Location = new System.Drawing.Point(0, 0);
            this.addpatientin_Iward1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addpatientin_Iward1.Name = "addpatientin_Iward1";
            this.addpatientin_Iward1.Size = new System.Drawing.Size(742, 512);
            this.addpatientin_Iward1.TabIndex = 40;
            this.addpatientin_Iward1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(924, 554);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonrecord;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button buttonQuarantine;
        private System.Windows.Forms.Button buttonsymptoms;
        private System.Windows.Forms.Button buttonisolation;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelHeader;
        private usercontrol.UserControl1 userControl11;
        private System.Windows.Forms.Button buttonhome;
        private usercontrol.home home1;
        private System.Windows.Forms.Button button2;
        private usercontrol.International international1;
        private System.Windows.Forms.Button button3;
        private usercontrol.patientrecord patientrecord1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private usercontrol.addnewrecord addnewrecord1;
        private usercontrol.editnewrecord editnewrecord1;
        private usercontrol.deletenewrecord deletenewrecord1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private usercontrol.graph graph1;
        private System.Windows.Forms.Button buttonchart;
        private System.Windows.Forms.Button buttonchart1;
        private Quarantinewards quarantinewards1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removepatientfromward;
        private System.Windows.Forms.Button addpatientinward;
        private usercontrol.addpatientinQward addpatientinQward1;
        private usercontrol.removepatientfromQward removepatientfromQward1;
        private usercontrol.IsolationWards isolationWards1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button addpatientin_Iward;
        private usercontrol.removepatientfrom_Iward removepatientfrom_Iward1;
        private usercontrol.addpatientin_Iward addpatientin_Iward1;
    }
}

