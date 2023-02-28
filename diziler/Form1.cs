using System.Security.Cryptography.X509Certificates;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kisiler = { "Ahemt", "Memet", "Ali", "Kemal", "Elif", "Murat","Ayten","Ali�an","G�lten","Nursel" };
        int[] say�lar = { 5, 2, 54, 20, 7, 12, 8, 80, 3, 58 };
        char[] harfler = { 'k','a','h','�','2','z','y','7','f','4' };
        double[] ondal�k = { 12.2, 43.3, 64.2, 4.12, 4.84, 32.6, 6.42, 73.12, 3.84, 5.12 };
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = kisiler[x];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = say�lar[x].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = harfler[x].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = ondal�k[x].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kisiler.Length; i++)
            {
                listBox1.Items.Add(kisiler[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < say�lar.Length; i++)
            {
                if (say�lar[i] %2==0)
                {
                    listBox2.Items.Add(say�lar[i]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < say�lar.Length; i++)
            {
                if (say�lar[i] >= 10 && say�lar[i]%2 ==0)
                {
                    listBox3.Items.Add(say�lar[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (int x in say�lar)
            {
                if (x%4 ==0)
                {
                    listBox4.Items.Add(x);
                    toplam = toplam + x;

                }
                label1.Text = toplam.ToString();

                // D�rede b�l�nenler ve toplamlar�n� yazd�rd�m 
            }
        }
    }
}