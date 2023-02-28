namespace matemetikFonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToUInt16(textBox1.Text);
            // label1.Text = Math.Abs(sayi).ToString();
            // label1.Text = Math.Ceiling(sayi).ToString();
            // label1.Text = Math.Floor(sayi).ToString();
            // label1.Text = Math.Pow(sayi, 3).ToString();
            label1.Text = Math.Sqrt(sayi).ToString();


            /*
             * Abs mutlak değeri alır
             * Ceiling 1.02 yi 2 ye yuvarlar
             * Floor 1.99 1 ye yuvarlar
             * Pow üst alır ikili değişken ile yazman gerekir
             * Sqrt kara kök allır
             */
        }
    }
}
