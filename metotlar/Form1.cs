using System.Security.Cryptography;

namespace metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazd�r()
        {
            textBox1.Text = "Muhammet";
            textBox2.Text = "Dicel";
            textBox3.Text = "Ya� 25";
            textBox4.Text = "�stanbul";
        }
        int topla(int s1, int s2)
        {

            

            int s3 = s1 + s2;
            return s3;
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yazd�r();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int say�1 = Convert.ToInt16(textBox5.Text);
            int say�2 = Convert.ToInt16(textBox6.Text);
            label1.Text = topla(say�1,say�2).ToString();
        }
    }
}