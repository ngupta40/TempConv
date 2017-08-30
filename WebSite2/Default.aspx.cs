using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{

    protected void C2F_Click(object sender, EventArgs e)
    {
        TempConvSvc.Service1Client tmpsvc = new TempConvSvc.Service1Client();

        int tmp = Convert.ToInt32(TextBox1.Text);
        int f = tmpsvc.c2f(tmp);
        TextBox1.Text = f.ToString();
    }

    protected void F2C_Click(object sender, EventArgs e)
    {
        TempConvSvc.Service1Client tmpsvc = new TempConvSvc.Service1Client();
        int tmp = Convert.ToInt32(TextBox1.Text);
        int c = tmpsvc.f2c(tmp);
        TextBox1.Text = c.ToString();
    }
}