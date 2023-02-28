namespace RondomKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int say1, say2, say3, say4;
            say1=rd.Next(0,3);
            say2=rd.Next(0,3);
            say3=rd.Next(0,3);
            say4 = rd.Next(0, 3);
            label1.Text = say1.ToString();
            label2.Text = say2.ToString();
            label3.Text = say3.ToString();
            label4.Text = say4.ToString();
            if (textBox1.Text == say1.ToString())
            {
                textBox1.BackColor = Color.Green;                
            }
            else
            {
                textBox1.BackColor = Color.Red;               
            }
            if (textBox2.Text == say2.ToString())
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == say3.ToString())
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text == say4.ToString())
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }
    }
}