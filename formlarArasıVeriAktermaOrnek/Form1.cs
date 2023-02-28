namespace formlarArasıVeriAktermaOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr =new Form2();
            fr.ms1 = textBox1.Text;
            fr.ms2 = textBox2.Text;
            fr.ms3 = textBox3.Text;
            fr.ms4 = textBox4.Text;
            fr.Show();
        }
    }
}