namespace WinFormsApp5
{
    public partial class aracKullanýmý : Form
    {
        public aracKullanýmý()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "merhaba dünya";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "merhaba dünya";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(maskedTextBox1.Text + "   " + maskedTextBox2.Text + "   " + maskedTextBox3.Text + "   " + maskedTextBox4.Text);
        }
    }
} 