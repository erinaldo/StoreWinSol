using System;
using System.Windows.Forms;
using System.Diagnostics;
namespace StoreWin
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = "PieStore v1.0_UserGuide.pdf";
            Process.Start(filename);
        }
    }
}
