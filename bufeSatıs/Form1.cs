namespace bufeSatıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasaToplam;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int bilet, mısır, su, cola, toplam ;
            bilet = Convert.ToInt32(textBox1.Text);
            mısır = Convert.ToInt32(textBox2.Text);
            su = Convert.ToInt32(textBox3.Text);
            cola = Convert.ToInt32(textBox4.Text);
            toplam = bilet * 20 + mısır * 14 + su * 3 + cola * 9;
            kasaToplam = kasaToplam + toplam;
            
            label11.Text =toplam.ToString() + " TL";
            label13.Text=kasaToplam.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Focus();
        }
    }
}