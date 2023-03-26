namespace WinFormAPIConsumer
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
            this.InstructorsGridView = new System.Windows.Forms.DataGridView();
            this.SSNtxt = new System.Windows.Forms.TextBox();
            this.Passwordtx = new System.Windows.Forms.TextBox();
            this.Salarytxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.Adresstxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Deptcbx = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.insComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InstructorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructorsGridView
            // 
            this.InstructorsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstructorsGridView.Location = new System.Drawing.Point(12, 282);
            this.InstructorsGridView.Name = "InstructorsGridView";
            this.InstructorsGridView.RowHeadersWidth = 51;
            this.InstructorsGridView.RowTemplate.Height = 24;
            this.InstructorsGridView.Size = new System.Drawing.Size(1043, 263);
            this.InstructorsGridView.TabIndex = 0;
            this.InstructorsGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InstructorsGridView_RowHeaderMouseDoubleClick);
            // 
            // SSNtxt
            // 
            this.SSNtxt.Location = new System.Drawing.Point(116, 42);
            this.SSNtxt.Name = "SSNtxt";
            this.SSNtxt.Size = new System.Drawing.Size(100, 22);
            this.SSNtxt.TabIndex = 1;
            // 
            // Passwordtx
            // 
            this.Passwordtx.Location = new System.Drawing.Point(353, 146);
            this.Passwordtx.Name = "Passwordtx";
            this.Passwordtx.Size = new System.Drawing.Size(100, 22);
            this.Passwordtx.TabIndex = 4;
            // 
            // Salarytxt
            // 
            this.Salarytxt.Location = new System.Drawing.Point(353, 210);
            this.Salarytxt.Name = "Salarytxt";
            this.Salarytxt.Size = new System.Drawing.Size(100, 22);
            this.Salarytxt.TabIndex = 5;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(353, 94);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(100, 22);
            this.phonetxt.TabIndex = 6;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(116, 210);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(100, 22);
            this.Emailtxt.TabIndex = 7;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(353, 42);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(100, 22);
            this.agetxt.TabIndex = 9;
            // 
            // Adresstxt
            // 
            this.Adresstxt.Location = new System.Drawing.Point(116, 146);
            this.Adresstxt.Name = "Adresstxt";
            this.Adresstxt.Size = new System.Drawing.Size(100, 22);
            this.Adresstxt.TabIndex = 10;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(116, 94);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(100, 22);
            this.Nametxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adreess";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Department ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Name";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(610, 152);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(101, 25);
            this.Addbtn.TabIndex = 24;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Deptcbx
            // 
            this.Deptcbx.FormattingEnabled = true;
            this.Deptcbx.Location = new System.Drawing.Point(611, 92);
            this.Deptcbx.Name = "Deptcbx";
            this.Deptcbx.Size = new System.Drawing.Size(100, 24);
            this.Deptcbx.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(610, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 22);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insComboBox
            // 
            this.insComboBox.FormattingEnabled = true;
            this.insComboBox.Location = new System.Drawing.Point(887, 50);
            this.insComboBox.Name = "insComboBox";
            this.insComboBox.Size = new System.Drawing.Size(121, 24);
            this.insComboBox.TabIndex = 29;
            this.insComboBox.SelectedIndexChanged += new System.EventHandler(this.insComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(821, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 557);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.insComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Deptcbx);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Adresstxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.Salarytxt);
            this.Controls.Add(this.Passwordtx);
            this.Controls.Add(this.SSNtxt);
            this.Controls.Add(this.InstructorsGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InstructorsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InstructorsGridView;
        private System.Windows.Forms.TextBox SSNtxt;
        private System.Windows.Forms.TextBox Passwordtx;
        private System.Windows.Forms.TextBox Salarytxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox Adresstxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ComboBox Deptcbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox insComboBox;
        private System.Windows.Forms.Label label12;
    }
}

