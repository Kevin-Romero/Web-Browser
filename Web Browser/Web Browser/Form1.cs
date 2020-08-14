using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        private string url;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            url = txtSearch.Text;
            navegator.Navigate(url);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            navegator.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            navegator.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //navegator.GoHome();

            navegator.Navigate("www.google.com");

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (!navegator.Url.Equals("about:blank"))
            {
                navegator.Refresh();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            url = txtSearch.Text;

            if (e.KeyCode == Keys.Enter)
            {
                navegator.Navigate(url);
            }
        }

        private void navegator_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtSearch.Text = navegator.Url.ToString();
            this.Text = navegator.DocumentTitle;
        }

    }
}
