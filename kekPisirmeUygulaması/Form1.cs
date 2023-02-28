namespace kekPisirmeUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 20;
            label1.BackColor=Color.Red;
            if (progressBar1.Value==100)
            {
                label1.BackColor=Color.Green;
                timer1.Stop();
                label1.Text="Un ve yumurta karıştırıldı";
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value+=10;
            label2.BackColor=Color.Red;
            if (progressBar2.Value==100)
            {
                label2.Text = "Çırpılma işlemi tamamlandı";
                label2.BackColor = Color.Green;
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            label3.BackColor=Color.Red;
            if (progressBar3.Value==100)
            {
                label3.Text = "Malzemeler eklendi";
                label3.BackColor = Color.Green;
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;
            label4.BackColor = Color.Red;
            if (progressBar4.Value == 100) 
            {
                
                timer4.Stop();
                MessageBox.Show("Kekiniz hazır");
            }

        }
    }
}