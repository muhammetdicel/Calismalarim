namespace sınıflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb=new Araba();
            rb.renk = "mavi";
            rb.hız = 120;
            rb.motor = 1242.21;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.YIL = -2012;
            rb.MARKA = "fort";
            rb.muayene = 2013;
            rb.plaka = "34 MDK 2192";
            rb.sahip = "Muhammet Dicel";

            label1.Text=rb.renk;
            label2.Text=rb.hız.ToString();
            label3.Text=rb.motor.ToString();
            label4.Text=rb.fiyat.ToString();
            label5.Text=rb.durum.ToString();
            label6.Text=rb.YIL.ToString();
            label7.Text = rb.MARKA;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.plaka;
            label10.Text = rb.sahip;
            
        }
    }
}