using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindProcesses()
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            DataSet DS = new DataSet();
            dbConn.Open();

            string query = @"SELECT * from Processes WHERE Format(process_date, 'Short Date')=DATE() ORDER BY process_date DESC";
            OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
            DBAdapter.SelectCommand = new OleDbCommand(query, dbConn);
            DBAdapter.Fill(DS);
            dbConn.Close();

            dataGridView1.Rows.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString());
                }
            }
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            dbConn.Open();
            OleDbCommand dbCommand3 = new OleDbCommand();
            dbCommand3.Connection = dbConn;

            string sSQL3 = "INSERT INTO Processes(process_name)";
            sSQL3 += "Values(@p_name);";
            dbCommand3.CommandText = sSQL3;

            string p_name = "عملية خروج من البرنامج - المستخدم  '" +Login.User + "' ";

            dbCommand3.Parameters.AddWithValue("@p_name", p_name);

            dbCommand3.ExecuteNonQuery();
            dbConn.Close();
            Application.Exit();
        }

        private void الاعداداتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اعداداتالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUsers s = new SetUsers();
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
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            dbConn.Open();
            OleDbCommand dbCommand3 = new OleDbCommand();
            dbCommand3.Connection = dbConn;

            string sSQL3 = "INSERT INTO Processes(process_name)";
            sSQL3 += "Values(@p_name);";
            dbCommand3.CommandText = sSQL3;

            string p_name = "عملية خروج من البرنامج - المستخدم  '" + Login.User + "' ";

            dbCommand3.Parameters.AddWithValue("@p_name", p_name);

            dbCommand3.ExecuteNonQuery();
            dbConn.Close();

            Application.Exit();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            BindProcesses();
        }
    }
}
