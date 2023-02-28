namespace donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i=1; i<=10; i++)
            {
                listBox1.Items.Add (i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam=0;
            for(int i=1; i<=10; i++)
            {
                toplam=toplam+i;
                listBox2.Items.Add(toplam);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            for (int i = 1; i <= 100; i++)
            {
                if (i%3==0 && i%7==0)
                {
                    listBox3.Items.Add(i);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(textBox1.Text);
            for (int i=0; i <= x; i++)
            {
                listBox4.Items.Add(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi%i==0)
                {
                    listBox5.Items.Add(i);

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox3.Text);
            int toplam=1;
            for (int i = 1; i <=sayi; i++)
            {
                toplam = toplam*i;
                listBox6.Items.Add(toplam);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i<5)
            {
                listBox7.Items.Add(i);
                i++;
            }
        }
        int sayac=0;
        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac==50)
            {
                timer1.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            label4.Text= sayac.ToString();
            if(sayac==5)
            {
                groupBox9.BackColor = Color.Red;
            }
            if (sayac==10)
            {
                groupBox9.BackColor = Color.Blue;
                sayac = 0;
            }
        }

        int saat = 0, dk = 0, sn = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            sn++;
            label5.Text = sn.ToString();
            if (sn==60)
            {
                dk++;
                label6.Text = dk.ToString();
                sn =0;
                if (dk==60)
                {
                    saat++;
                    label7.Text = saat.ToString();    
                    dk =0;
                }
            }
        }
    }
}