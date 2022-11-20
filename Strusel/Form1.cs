using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strusel
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Browser.Navigate("google.com");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Browser.Navigate(textBox1.Text);
        }

        private void Fwd_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
