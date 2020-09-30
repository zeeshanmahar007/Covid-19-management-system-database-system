namespace covid_19_Project.usercontrol
{
    partial class International
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxdeaths = new System.Windows.Forms.TextBox();
            this.textBoxrecovered = new System.Windows.Forms.TextBox();
            this.textBoxconfirmed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxtodaycases = new System.Windows.Forms.TextBox();
            this.textBoxcritical = new System.Windows.Forms.TextBox();
            this.textBoxtodaydeaths = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::covid_19_Project.Properties.Resources.bacteria1;
            this.pictureBox1.Location = new System.Drawing.Point(18, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 86);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(389, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 32);
            this.label10.TabIndex = 41;
            this.label10.Text = "DEATHS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Location = new System.Drawing.Point(330, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 32);
            this.label9.TabIndex = 40;
            this.label9.Text = "RECOVERED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "CONFIRMED CASES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(113, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "INTERNATIONAL CORONAVIRUS CASES";
            // 
            // textBoxdeaths
            // 
            this.textBoxdeaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxdeaths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxdeaths.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdeaths.ForeColor = System.Drawing.Color.Red;
            this.textBoxdeaths.Location = new System.Drawing.Point(523, 144);
            this.textBoxdeaths.Name = "textBoxdeaths";
            this.textBoxdeaths.Size = new System.Drawing.Size(177, 59);
            this.textBoxdeaths.TabIndex = 27;
            // 
            // textBoxrecovered
            // 
            this.textBoxrecovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxrecovered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxrecovered.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrecovered.ForeColor = System.Drawing.Color.Green;
            this.textBoxrecovered.Location = new System.Drawing.Point(507, 330);
            this.textBoxrecovered.Name = "textBoxrecovered";
            this.textBoxrecovered.Size = new System.Drawing.Size(203, 59);
            this.textBoxrecovered.TabIndex = 24;
            this.textBoxrecovered.TextChanged += new System.EventHandler(this.textBoxrecovered_TextChanged);
            // 
            // textBoxconfirmed
            // 
            this.textBoxconfirmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxconfirmed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxconfirmed.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxconfirmed.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxconfirmed.Location = new System.Drawing.Point(63, 207);
            this.textBoxconfirmed.Name = "textBoxconfirmed";
            this.textBoxconfirmed.Size = new System.Drawing.Size(216, 59);
            this.textBoxconfirmed.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(15, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 32);
            this.label3.TabIndex = 45;
            this.label3.Text = "TODAY CASES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(327, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 32);
            this.label4.TabIndex = 46;
            this.label4.Text = "TODAY DEATHS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(15, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 32);
            this.label5.TabIndex = 47;
            this.label5.Text = "CRITICAL";
            // 
            // textBoxtodaycases
            // 
            this.textBoxtodaycases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxtodaycases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtodaycases.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtodaycases.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxtodaycases.Location = new System.Drawing.Point(86, 325);
            this.textBoxtodaycases.Name = "textBoxtodaycases";
            this.textBoxtodaycases.Size = new System.Drawing.Size(175, 59);
            this.textBoxtodaycases.TabIndex = 48;
            // 
            // textBoxcritical
            // 
            this.textBoxcritical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxcritical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcritical.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcritical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxcritical.Location = new System.Drawing.Point(86, 433);
            this.textBoxcritical.Name = "textBoxcritical";
            this.textBoxcritical.Size = new System.Drawing.Size(158, 59);
            this.textBoxcritical.TabIndex = 49;
            // 
            // textBoxtodaydeaths
            // 
            this.textBoxtodaydeaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxtodaydeaths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtodaydeaths.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtodaydeaths.ForeColor = System.Drawing.Color.Red;
            this.textBoxtodaydeaths.Location = new System.Drawing.Point(552, 230);
            this.textBoxtodaydeaths.Name = "textBoxtodaydeaths";
            this.textBoxtodaydeaths.Size = new System.Drawing.Size(158, 59);
            this.textBoxtodaydeaths.TabIndex = 50;
            // 
            // International
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.textBoxtodaydeaths);
            this.Controls.Add(this.textBoxcritical);
            this.Controls.Add(this.textBoxtodaycases);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxdeaths);
            this.Controls.Add(this.textBoxrecovered);
            this.Controls.Add(this.textBoxconfirmed);
            this.Name = "International";
            this.Size = new System.Drawing.Size(742, 512);
            this.Load += new System.EventHandler(this.International_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxdeaths;
        private System.Windows.Forms.TextBox textBoxrecovered;
        private System.Windows.Forms.TextBox textBoxconfirmed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxtodaycases;
        private System.Windows.Forms.TextBox textBoxcritical;
        private System.Windows.Forms.TextBox textBoxtodaydeaths;
    }
}
