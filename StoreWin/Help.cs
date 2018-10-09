using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

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
            try
            {
                string filename = "PieStore v1.2_UserGuide.pdf";
                Process.Start(filename);
            }
            catch { }
        }
    }
}
