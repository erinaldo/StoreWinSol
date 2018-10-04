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
    public partial class SalesRet : Form
    {
        public SalesRet()
        {
            InitializeComponent();
        }

        private void SalesRet_Load(object sender, EventArgs e)
        {
            Bindinvno();
        }

        private void Bindinvno()
        {
            try
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();
                dbConn.Open();

                string query = @"SELECT * from sales_m ORDER BY sales_id DESC";
                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(query, dbConn);
                DBAdapter.Fill(DS);
                dbConn.Close();

                combo_invno.DataSource = DS.Tables[0];
                combo_invno.DisplayMember = "sales_id";
                combo_invno.ValueMember = "sales_id";
            }
            catch
            {

            }

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Orange, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                dbConn.Open();

                //details
                DataSet DS = new DataSet();

                string query = @"SELECT * from sales_d_query WHERE sales_id = " + combo_invno.SelectedValue + "";
                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(query, dbConn);
                DBAdapter.Fill(DS);
                dbConn.Close();

                grid_invprods.Rows.Clear();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        grid_invprods.Rows.Add(0, DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString(), DS.Tables[0].Rows[i][4].ToString(), DS.Tables[0].Rows[i][3].ToString(), DS.Tables[0].Rows[i][5].ToString());
                    }
                }
            }
            catch { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());

                int prodid = 0;
                int currqty = 0;
                int j = 0;
                for (int i = 0; i < grid_invprods.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(grid_invprods.Rows[i].Cells[0].Value) == true)
                    {
                        j++;
                    }
                }

                if (j == 0)
                {
                    MessageBox.Show("اختر الصنف المرتجع");
                }
                else if (j > 1)
                {
                    MessageBox.Show("اختر صنف واحد");
                }
                else
                {
                    if (txt_qty.Value > 0)
                    {
                        for (int i = 0; i < grid_invprods.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(grid_invprods.Rows[i].Cells[0].Value) == true)
                            {
                                prodid = Convert.ToInt32(grid_invprods.Rows[i].Cells[1].Value);
                                currqty = Convert.ToInt32(grid_invprods.Rows[i].Cells[4].Value);
                            }
                        }
                        if (txt_qty.Value > currqty)
                        {
                            MessageBox.Show("الكمية المرتجعة اكبر من الكمية في الفاتورة");
                        }
                        else
                        {
                            dbConn.Open();

                            OleDbCommand dbCommand = new OleDbCommand();
                            dbCommand.Connection = dbConn;

                            string sSQL = "INSERT INTO retsales(product_id,qty,sales_id)";
                            sSQL += "Values(@product_id,@qty,@sales_id);";
                            dbCommand.CommandText = sSQL;

                            dbCommand.Parameters.AddWithValue("@product_id", prodid);
                            dbCommand.Parameters.AddWithValue("@qty", txt_qty.Text);
                            dbCommand.Parameters.AddWithValue("@sales_id", combo_invno.SelectedValue);

                            dbCommand.ExecuteNonQuery();

                            dbConn.Close();
                            MessageBox.Show("تم حفظ مرتجع");
                        }
                    }
                    else
                    {
                        MessageBox.Show("اختر الكمية المرتجعة");
                    }
                }
            }
            catch
            {

            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            grid_invprods.Rows.Clear();
            Bindinvno();
            txt_qty.Value = 0;
        }
    }
}
