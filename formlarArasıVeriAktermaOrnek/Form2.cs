using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlarArasıVeriAktermaOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string ms1;
        public string ms2;
        public string ms3;
        public string ms4;

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(ms1+" "+ms2);
            comboBox1.Items.Add(ms3);
            comboBox1.Items.Add(ms4);
        }
    }
}
