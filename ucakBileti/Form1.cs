namespace ucakBileti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden : " + comboBox1.Text + " " + "Nereye :" + comboBox2.Text + " " + "Tarih :" + dateTimePicker1.Text + " " + "Saat :" + comboBox3.Text + " " + "Ad & Soyad :" + textBox1.Text + " " + textBox2.Text + " " + "TC" + maskedTextBox1.Text + " " + "Telefon" + maskedTextBox2);
            MessageBox.Show("Kayýt Tamamlandý");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label10.Text;
        }
    }
}