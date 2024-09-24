using System;
using System.Windows.Forms;

namespace CookieClickerApp
{
    public partial class Form1 : Form
    {
        private int cookieCount = 0;

        public Form1()
        {
            InitializeComponent(); // Make sure this line is present to call the designer method
        }

        private void button_Click(object sender, EventArgs e)
        {
            cookieCount++;
            labelCookies.Text = "Cookies: " + cookieCount;
        }
    }
}
