namespace formlarArasıVeriTasıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.mesaj = textBox1.Text;
            frm.mesaj2 = textBox2.Text;
            frm.Show();
            this.Hide();
        }
    }
}