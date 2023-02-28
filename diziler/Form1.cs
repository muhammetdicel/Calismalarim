using System.Security.Cryptography.X509Certificates;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kisiler = { "Ahemt", "Memet", "Ali", "Kemal", "Elif", "Murat","Ayten","Aliþan","Gülten","Nursel" };
        int[] sayýlar = { 5, 2, 54, 20, 7, 12, 8, 80, 3, 58 };
        char[] harfler = { 'k','a','h','ö','2','z','y','7','f','4' };
        double[] ondalýk = { 12.2, 43.3, 64.2, 4.12, 4.84, 32.6, 6.42, 73.12, 3.84, 5.12 };
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = kisiler[x];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = sayýlar[x].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = harfler[x].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            label1.Text = ondalýk[x].ToString();
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
            for (int i = 0; i < sayýlar.Length; i++)
            {
                if (sayýlar[i] %2==0)
                {
                    listBox2.Items.Add(sayýlar[i]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayýlar.Length; i++)
            {
                if (sayýlar[i] >= 10 && sayýlar[i]%2 ==0)
                {
                    listBox3.Items.Add(sayýlar[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (int x in sayýlar)
            {
                if (x%4 ==0)
                {
                    listBox4.Items.Add(x);
                    toplam = toplam + x;

                }
                label1.Text = toplam.ToString();

                // Dörede bölünenler ve toplamlarýný yazdýrdým 
            }
        }
    }
}