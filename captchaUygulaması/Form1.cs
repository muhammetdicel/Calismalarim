using System.Runtime.Intrinsics.X86;

namespace captchaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "e", "d", "m", "v" };
            string[] sembol2 = { "/", "*", "+", "-","%","#" };
            string[] sembol4 = { "D", "H", "W", "Q", "Z", "B", "A", "T", "M" };
            string[] sembol5 = { "K", "R", "M", "P", "T", "R" };
            Random r = new Random();
            int s1, s2, s3 ,s4, s5;
            s1=r.Next(0,sembol1.Length);
            s2=r.Next(0,sembol2.Length);
            s3 = r.Next(0, 10);
            s4 = r.Next(0, sembol4.Length);
            s5 = r.Next(0, sembol5.Length);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString() + sembol4[s4].ToString() + sembol5[s5].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}