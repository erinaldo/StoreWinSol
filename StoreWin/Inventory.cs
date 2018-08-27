using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using StoreWin.Reps;

namespace StoreWin
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Bindproducts()
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            DataSet DS = new DataSet();
            dbConn.Open();

            string query = @"SELECT * from products";
            OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
            DBAdapter.SelectCommand = new OleDbCommand(query, dbConn);
            DBAdapter.Fill(DS);
            dbConn.Close();


            combo_prod.DisplayMember = "product_name";
            combo_prod.ValueMember = "product_id";
            combo_prod.DataSource = DS.Tables[0];

        }

        private void BindQty()
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            DataSet DS = new DataSet();

            dbConn.Open();
            string sSQL = "select * from inventory_query_rep where product_id ="+combo_prod.SelectedValue+"";
            OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
            DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
            DBAdapter.Fill(DS);

            dbConn.Close();

            Grid_prods.Rows.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                Grid_prods.Rows.Add(DS.Tables[0].Rows[0][0].ToString(), DS.Tables[0].Rows[0][1].ToString(), DS.Tables[0].Rows[0][2].ToString(), DS.Tables[0].Rows[0][3].ToString(), DS.Tables[0].Rows[0][4].ToString());
            }
        }

        private void BindAllQty()
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            DataSet DS = new DataSet();

            dbConn.Open();
            string sSQL = "select * from inventory_query_rep";
            OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
            DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
            DBAdapter.Fill(DS);

            dbConn.Close();

            Grid_prods.Rows.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    Grid_prods.Rows.Add(DS.Tables[0].Rows[i][0].ToString(), DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString(), DS.Tables[0].Rows[i][3].ToString(), DS.Tables[0].Rows[i][4].ToString());
                }
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Bindproducts();
        }

        private void radio_all_CheckedChanged(object sender, EventArgs e)
        {
            combo_prod.Enabled = false;
            btn_print.Enabled = true;
        }

        private void radio_one_CheckedChanged(object sender, EventArgs e)
        {
            combo_prod.Enabled = true;
            btn_print.Enabled = false;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if(radio_all.Checked)
            {
                BindAllQty();
            }
            else if(radio_one.Checked)
            {
                BindQty();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Inventory_rep invrep = new Inventory_rep();
            invrep.Show();
        }
    }
}
