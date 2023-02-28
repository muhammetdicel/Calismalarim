namespace Ornekler
{
    public partial class ornekler : Form
    {
        public ornekler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            label5.Text = textBox2.Text;
            label6.Text = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text + "   " + textBox5.Text + "   " + textBox6.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox7.Text + "   " + textBox8.Text + "   " + maskedTextBox1.Text + "   " + maskedTextBox2.Text + "   " + dateTimePicker1.Text);
        }
    }
}