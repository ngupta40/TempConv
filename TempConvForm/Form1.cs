using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempConvSvc.Service1Client tmpsvc = new TempConvSvc.Service1Client();
            double tmp = Convert.ToDouble(textBox1.Text);
            int temperature = Convert.ToInt32(tmp);
            int f = tmpsvc.c2f(temperature);
            textBox1.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TempConvSvc.Service1Client tmpsvc = new TempConvSvc.Service1Client();
            double tmp = Convert.ToDouble(textBox1.Text);
            int temperature = Convert.ToInt32(tmp);
            int c = tmpsvc.f2c(temperature);
            textBox1.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
