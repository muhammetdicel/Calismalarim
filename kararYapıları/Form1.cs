namespace kararYapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "muhammet" && textBox2.Text == "dicel")
            {
                MessageBox.Show("Hoş gelidiniz");
            }
            if (textBox1.Text != "muhammet" || textBox2.Text != "dicel")
            {
                MessageBox.Show("Kullanıcı adı ya da Şifre yanlış");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı = Convert.ToInt16(textBox3.Text);
            if (sayı==7)
            {
                MessageBox.Show("Dogru Tahmin");
            }
            if (0<= sayı && sayı <=6)
            {
                MessageBox.Show("Girdiğiniz sayıdan büyük");
            }
            if (8 <= sayı && sayı <=21)
            {
                MessageBox.Show("Girdiğiniz sayıdan küçük");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, ort;
            string durum;
            not1 = Convert.ToDouble(textBox4.Text);
            not2 = Convert.ToDouble(textBox5.Text);     
            not3 = Convert.ToDouble(textBox6.Text);

            ort = (not1 + not2 + not3) / 3;
            if (ort <= 50)
            {
                durum = "Kaldı";
            }
            else
            {
                durum = "Geçti";
            }
            label8.Text = ort.ToString("0.00") +" / "+ durum;
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            int kitap;
            double toplam;

            kitap = Convert.ToInt32(textBox7.Text);

            if (kitap <= 4) 
            {
                toplam = kitap * 8;
                label11.Text = toplam.ToString();
            }
            if ( 5 <=kitap && kitap <=9)
            {
                toplam = (kitap * 8)-(kitap*8*0.20) ;
                label11.Text = toplam.ToString("0.00") + "TL";
                label13.Text = "%20";
            }
            if (10 <= kitap && kitap <= 14)
            {
                toplam = (kitap * 8) - (kitap * 8 * 0.30);
                label11.Text = toplam.ToString("0.00") + "TL";
                label13.Text = "%30";
            }
            if (15 <= kitap)
            {
                toplam = (kitap * 8) - (kitap * 8 * 0.40);
                label11.Text = toplam.ToString("0.00") + "TL";
                label13.Text = "%40";
            }
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2,sonuc;
            sayı1 = Convert.ToDouble(textBox8.Text);
            sayı2 = Convert.ToDouble(textBox9.Text);
            
            string islem= textBox10.Text;
            switch(islem)
            {
                case "+": sonuc = sayı1 + sayı2; label17.Text = sonuc.ToString("0.00"); break;
                case "-": sonuc = sayı1 - sayı2; label17.Text = sonuc.ToString("0.00"); break;
                case "/": sonuc = sayı1 / sayı2; label17.Text = sonuc.ToString("0.00"); break;
                case "*": sonuc = sayı1 * sayı2; label17.Text = sonuc.ToString("0.00"); break;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(textBox11.Text);
            switch (ay)
            {
                case 1: label19.Text = "Ocak"; break;
                case 2: label19.Text = "Şubat"; break;
                case 3: label19.Text = "Mart"; break;
                case 4: label19.Text = "Nisan"; break;
                case 5: label19.Text = "Mayıs"; break;
                case 6: label19.Text = "Haziran"; break;
                case 7: label19.Text = "Temmuz"; break;
                case 8: label19.Text = "Ağustos"; break;
                case 9: label19.Text = "Eylül"; break;
                case 10: label19.Text = "Ekim"; break;
                case 11: label19.Text = "Kasım"; break;
                case 12: label19.Text = "Aralık"; break;
                default: label19.Text = "Yanlış tarih"; break;
                

            }
        }
    }
}
