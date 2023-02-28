using System.Security.Cryptography;

namespace metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazdýr()
        {
            textBox1.Text = "Muhammet";
            textBox2.Text = "Dicel";
            textBox3.Text = "Yaþ 25";
            textBox4.Text = "Ýstanbul";
        }
        int topla(int s1, int s2)
        {

            

            int s3 = s1 + s2;
            return s3;
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yazdýr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayý1 = Convert.ToInt16(textBox5.Text);
            int sayý2 = Convert.ToInt16(textBox6.Text);
            label1.Text = topla(sayý1,sayý2).ToString();
        }
    }
}