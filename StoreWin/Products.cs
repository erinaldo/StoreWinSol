﻿using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Products : Form
    {
        OleDbDataAdapter adapt;
        int ID = 0;

        public Products()
        {
            InitializeComponent();
            DisplayData();
            btn_update.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
        }

        private void DisplayData()
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());

            dbConn.Open();
            DataTable dt = new DataTable();
            adapt = new OleDbDataAdapter("SELECT product_id AS رقم ,product_name AS الصنف ,pur_price AS شراء , sal_price AS بيع  FROM products", dbConn);
            adapt.Fill(dt);
            grid_products.DataSource = dt;
            dbConn.Close();
        }

        private void ClearData()
        {
            txt_prodname.Text = "";
            txt_purprice.Text = "";
            txt_saleprice.Text = "";
            ID = 0;
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_prodname.Text != "" && txt_purprice.Text != "" && txt_saleprice.Text != "")
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                dbConn.Open();
                OleDbCommand dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConn;

                string sSQL = "INSERT INTO products(product_name,pur_price,sal_price)";
                sSQL += "Values(@prodname,@pur,@sal);";
                dbCommand.CommandText = sSQL;

                dbCommand.Parameters.AddWithValue("@prodname", txt_prodname.Text);
                dbCommand.Parameters.AddWithValue("@pur", txt_purprice.Text);
                dbCommand.Parameters.AddWithValue("@sal", txt_saleprice.Text);

                dbCommand.ExecuteNonQuery();

                dbConn.Close();

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("ادخل بيانات الصنف");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_prodname.Text != "" && txt_purprice.Text != "" && txt_saleprice.Text != "")
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                dbConn.Open();
                OleDbCommand dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConn;

                string sSQL = "UPDATE products SET product_name='"+ txt_prodname.Text + "',pur_price='"+ txt_purprice.Text + "',sal_price='"+ txt_saleprice.Text + "' WHERE product_id="+ ID+"";

                dbCommand.CommandText = sSQL;

                dbCommand.ExecuteNonQuery();

                dbConn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("ادخل بيانات الصنف");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                dbConn.Open();
                OleDbCommand dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConn;

                string sSQL = "DELETE FROM products WHERE product_id=@id";

                dbCommand.CommandText = sSQL;

                dbCommand.Parameters.AddWithValue("@id", ID);

                dbCommand.ExecuteNonQuery();

                dbConn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("اختر الصنف المراد حذفه");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearData();
            btn_update.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
        }

        private void grid_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(grid_products.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_prodname.Text = grid_products.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_purprice.Text = grid_products.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_saleprice.Text = grid_products.Rows[e.RowIndex].Cells[3].Value.ToString();

            btn_update.Enabled = true;
            btn_del.Enabled = true;
            btn_save.Enabled = false;
        }

        private void txt_purprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txt_purprice.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txt_saleprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txt_saleprice.Text + ch, out x))
            {
                e.Handled = true;
            }
        }
    }
}
