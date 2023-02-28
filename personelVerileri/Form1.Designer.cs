namespace personelVerileri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CmbSehir = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.Btnİstatislik = new System.Windows.Forms.Button();
            this.BtnGrafik = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.MskMaas = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskMaas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.CmbSehir);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMeslek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veri Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel id :";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(157, 28);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(121, 29);
            this.Txtid.TabIndex = 1;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(157, 63);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(121, 29);
            this.TxtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(157, 98);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(121, 29);
            this.TxtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad :";
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(157, 249);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(121, 29);
            this.TxtMeslek.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Medeni Durum :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Meslek :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(157, 214);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 25);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CmbSehir
            // 
            this.CmbSehir.FormattingEnabled = true;
            this.CmbSehir.Location = new System.Drawing.Point(157, 135);
            this.CmbSehir.Name = "CmbSehir";
            this.CmbSehir.Size = new System.Drawing.Size(121, 29);
            this.CmbSehir.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(211, 214);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 25);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGrafik);
            this.groupBox2.Controls.Add(this.Btnİstatislik);
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(80, 33);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(125, 35);
            this.BtnListele.TabIndex = 0;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(80, 74);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(125, 35);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(80, 115);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(125, 35);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(80, 156);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(125, 35);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(80, 197);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(125, 35);
            this.BtnTemizle.TabIndex = 4;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            // 
            // Btnİstatislik
            // 
            this.Btnİstatislik.Location = new System.Drawing.Point(80, 238);
            this.Btnİstatislik.Name = "Btnİstatislik";
            this.Btnİstatislik.Size = new System.Drawing.Size(125, 35);
            this.Btnİstatislik.TabIndex = 5;
            this.Btnİstatislik.Text = "İstatislik";
            this.Btnİstatislik.UseVisualStyleBackColor = true;
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.Location = new System.Drawing.Point(80, 279);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(125, 35);
            this.BtnGrafik.TabIndex = 2;
            this.BtnGrafik.Text = "Grafikler";
            this.BtnGrafik.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(842, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(836, 136);
            this.dataGridView1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Maaş :";
            // 
            // MskMaas
            // 
            this.MskMaas.Location = new System.Drawing.Point(157, 173);
            this.MskMaas.Mask = "0000";
            this.MskMaas.Name = "MskMaas";
            this.MskMaas.Size = new System.Drawing.Size(121, 29);
            this.MskMaas.TabIndex = 5;
            this.MskMaas.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(866, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private ComboBox CmbSehir;
        private RadioButton radioButton1;
        private Label label6;
        private Label label5;
        private TextBox TxtSoyad;
        private Label label3;
        private TextBox TxtMeslek;
        private Label label4;
        private TextBox TxtAd;
        private Label label2;
        private TextBox Txtid;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnGrafik;
        private Button Btnİstatislik;
        private Button BtnTemizle;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnKaydet;
        private Button BtnListele;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private MaskedTextBox MskMaas;
        private Label label7;
    }
}