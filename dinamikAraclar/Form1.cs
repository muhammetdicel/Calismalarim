namespace dinamikAraclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20,10);
            btn.Location = btnkonum;
            btn.Name = "Button1";
            btn.Text = "týkla";
            btn.Height=40;
            btn.Width=75;

            Label lbl = new Label();
            Point lblkonum = new Point(100, 20);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Merhaba";


            
            for (int i = 1; i <=5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(200, i * 30);
                txt.Location = txtkonum;
                txt.Name = "Textbox" + i;
                this.Controls.Add(txt);
            }
            


            this.Controls.Add(lbl);
            this.Controls.Add(btn);
        }
    }
}