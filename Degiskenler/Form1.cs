namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ad, soyad, telefon, yas;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            telefon = maskedTextBox1.Text;
            yas = comboBox1.Text;
            listBox1.Items.Add(ad + "  " + soyad + "  " + telefon + "  " + yas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int uzunK, kýsaK, alan, cevre ;
            uzunK = Convert.ToInt32(textBox3.Text);
            kýsaK = Convert.ToInt32(textBox4.Text);

            alan = uzunK * kýsaK;
            cevre = 2*(uzunK + kýsaK);

            label7.Text = alan.ToString();
            label8.Text = cevre.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, ortalama; 
            not1 = Convert.ToDouble(textBox5.Text);
            not2 = Convert.ToDouble(textBox6.Text);
            not3 = Convert.ToDouble(textBox7.Text);
            ortalama = (not1 + not2 + not3) / 3;
            label10.Text=ortalama.ToString("0.00");
        }
    }
}