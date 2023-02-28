namespace enumYapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       enum sehirler { X ,Adana, Adiyaman, Afyon , Ağrı ,Amasya,Ankara,Antalya,Artvin}
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt16(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label1.Text = s.ToString();
        }
    }
}