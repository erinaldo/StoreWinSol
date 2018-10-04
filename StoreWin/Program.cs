﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace StoreWin
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static Mutex m;
        [STAThread]
        static void Main()
        {
            bool first = false;
            m = new Mutex(true, Application.ProductName.ToString(), out first);

            if ((first))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SalesRet());
            }
            else
            {
                MessageBox.Show("!البرنامج مفتوح بالفعل");
            }
        }
    }
}
