namespace ucakBileti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Değiş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "13:00",
            "17:00",
            "19:00",
            "20:00",
            "23:00"});
            this.comboBox3.Location = new System.Drawing.Point(101, 179);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(68, 29);
            this.comboBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 29);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ankara ",
            "İstanbul",
            "Bursa",
            "Giresun",
            "Rize\t",
            "Tokat",
            "Antalya",
            "İzmir"});
            this.comboBox2.Location = new System.Drawing.Point(101, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 29);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ankara ",
            "İstanbul",
            "Bursa",
            "Giresun",
            "Rize\t",
            "Tokat",
            "Antalya",
            "İzmir"});
            this.comboBox1.Location = new System.Drawing.Point(101, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(465, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 29);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 29);
            this.textBox1.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(144, 174);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(128, 29);
            this.maskedTextBox2.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(144, 136);
            this.maskedTextBox1.Mask = "000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(128, 29);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "TC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Soyadı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adı :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(90, 437);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(744, 88);
            this.listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(90, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 122);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(87, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 53);
            this.label9.TabIndex = 0;
            this.label9.Text = "Jüpiter Hava Yolları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(887, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox3;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ListBox listBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label9;
        private Button button2;
        private Label label10;
    }
}