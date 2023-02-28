namespace Degiskenler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(188, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(205, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yaşı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(251, 23);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "  0-7",
            " 8-18",
            "19-25",
            "26-65"});
            this.comboBox1.Location = new System.Drawing.Point(251, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(36, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 49);
            this.listBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 221);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(409, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 221);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesaplama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(102, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Çevre";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(102, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kısa kenar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uzun kenar :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(15, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 158);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ortalama Hesaplama";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Hesapla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(118, 104);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 29);
            this.textBox7.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 69);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 29);
            this.textBox6.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sonuç";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 29);
            this.textBox5.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sınav Notları :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private Button button1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Button button2;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private GroupBox groupBox3;
        private Button button3;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox5;
        private Label label9;
    }
}