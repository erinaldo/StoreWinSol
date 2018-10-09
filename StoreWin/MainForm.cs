using StoreWin.App_Code;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class MainForm : Form
    {
        Connection con = new Connection();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BindProcesses()
        {
            try
            {
                DataSet DS = new DataSet();

                dataGridView1.Rows.Clear();

                DS = con.Select("SELECT * from Processes WHERE Format(process_date, 'Short Date')=DATE() ORDER BY process_date DESC", "proccesses");
                if (DS.Tables["proccesses"].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString());
                    }
                }
                DS.Clear();
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();

            Login login = new Login();
            login.ShowDialog();

            if (Login.x1 == false)
            {
                Application.Exit();
                return;
            }

            if (Login.x1 == true)
            {
                BindProcesses();
                this.toolStripStatusLabel1.Text = "إسم المستخدم :" +" "+ Login.User +" .. "+ "وقت الدخول :" +" "+ DateTime.Now.ToShortTimeString();
                this.toolStripStatusLabel1.ForeColor = Color.White;
            }
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            Sales sal = new Sales();
            sal.Show();
        }

        private void btn_purchases_Click(object sender, EventArgs e)
        {
            Purchases pur = new Purchases();
            pur.Show();
        }
      
        private void btn_inventory_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            Cash Cash = new Cash();
            Cash.Show();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports();
            rep.Show();
        }

        private void اعداداتالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetGeneral s = new SetGeneral();
            s.Show();
        }

        private void تعليماتالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void حولالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string p_name = "عملية خروج من البرنامج - المستخدم  " + Login.User;

            con.Excute("INSERT INTO Processes(process_name) Values('"+ p_name + "');");
            Application.Exit();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            BindProcesses();
        }

        private void btn_purchasesret_Click(object sender, EventArgs e)
        {
            PurchasesRet s = new PurchasesRet();
            s.Show();
        }

        private void btn_salesret_Click(object sender, EventArgs e)
        {
            SalesRet s = new SalesRet();
            s.Show();
        }

        private void اعداداتالمستخدمينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetUsers s = new SetUsers();
            s.Show();
        }
    }
}
