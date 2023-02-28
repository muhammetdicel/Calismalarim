namespace bilgiYarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label8.Text = button1.Text;
            if(label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                label6.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label8.Text = button2.Text;
            if (label7.Text == label8.Text) 
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                label6.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label8.Text = button3.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                label6.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label8.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                label6.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            label4.Text = soruno.ToString();
            if (soruno ==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                button1.Text = "1920";
                button2.Text = "1921";
                button3.Text = "1922";
                button4.Text = "1923";
                label7.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi şehir Ege bölgesinde bulunmaz?";
                button1.Text = "İzmir";
                button2.Text = "Giresun";
                button3.Text = "Aydın";
                button4.Text = "Manisa";
                label7.Text = "Giresun";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Türkiyenin başkenti neresidir?";
                button1.Text = "İstanbul";
                button2.Text = "Giresun";
                button3.Text = "Adana";
                button4.Text = "Ankara";
                label7.Text = "Ankara";
                button5.Text = "Sonuçlar";
            }
            if (soruno==4)
            {
                button1.Enabled=false;
                button2.Enabled=false;
                button3.Enabled=false;
                button4.Enabled=false;
                button5.Enabled=false;


                richTextBox1.Text = "Doğru Sayısı :" + dogru+ "\n" + "Yanlış Sayıs :" + yanlıs; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}