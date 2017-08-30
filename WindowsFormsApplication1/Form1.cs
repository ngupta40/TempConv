using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(urlString.Text);
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            EncryptionSvc.ServiceClient decsvc = new EncryptionSvc.ServiceClient();
            label2.Text = decsvc.Decrypt(label2.Text);
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            EncryptionSvc.ServiceClient ensvc = new EncryptionSvc.ServiceClient();
            label2.Text = ensvc.Encrypt(EncryptTxt.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void StockSvc_Click(object sender, EventArgs e)
        {
            StockQuoteSvc.ServiceClient stocksvc = new StockQuoteSvc.ServiceClient();
            stocksvc.Open();
            stocksvc.GetHashCode();
            stocksvc.DisplayInitializationUI();
            stocksvc.GetType();
            lblStockInfo.Text = stocksvc.getStockquote(CmpnyTxt.Text);
        }
    }
}


