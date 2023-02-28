namespace formArasıGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr=new Form2();
            fr.Show();
            this.Hide(); // ilk formu gizler
        }
    }
}