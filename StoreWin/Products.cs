using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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

        private void Products_Load(object sender, EventArgs e)
        {

        }
        private void DisplayData()
        {
            try
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());

                dbConn.Open();
                //DataTable dt = new DataTable();
                DataSet DS = new DataSet();
                adapt = new OleDbDataAdapter("SELECT product_id,product_name,pur_price, sal_price FROM products", dbConn);
                adapt.Fill(DS);
                //grid_products.DataSource = dt;
                dbConn.Close();

                grid_products.Rows.Clear();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        grid_products.Rows.Add(DS.Tables[0].Rows[i][0].ToString(), DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString(), DS.Tables[0].Rows[i][3].ToString());
                    }
                }
            }
            catch { }
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
            try
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
            catch { }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_prodname.Text != "" && txt_purprice.Text != "" && txt_saleprice.Text != "")
                {
                    OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                    dbConn.Open();
                    OleDbCommand dbCommand = new OleDbCommand();
                    dbCommand.Connection = dbConn;

                    string sSQL = "UPDATE products SET product_name='" + txt_prodname.Text + "',pur_price='" + txt_purprice.Text + "',sal_price='" + txt_saleprice.Text + "' WHERE product_id=" + ID + "";

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
            catch { }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    bool valid = true;

                    OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                    dbConn.Open();
                    OleDbCommand dbCommand = new OleDbCommand();
                    DataSet DS1 = new DataSet();
                    DataSet DS2 = new DataSet();
                    dbCommand.Connection = dbConn;

                    string sSQL1 = "SELECT * FROM purchases_d WHERE product_id=" + ID + "";
                    OleDbDataAdapter DBAdapter1 = new OleDbDataAdapter();
                    DBAdapter1.SelectCommand = new OleDbCommand(sSQL1, dbConn);
                    DBAdapter1.Fill(DS1);

                    if (DS1.Tables[0].Rows.Count > 0)
                    {
                        valid = false;
                    }

                    string sSQL2 = "SELECT * FROM sales_d WHERE product_id=" + ID + "";
                    OleDbDataAdapter DBAdapter2 = new OleDbDataAdapter();
                    DBAdapter2.SelectCommand = new OleDbCommand(sSQL2, dbConn);
                    DBAdapter2.Fill(DS2);
                    if (DS1.Tables[0].Rows.Count > 0)
                    {
                        valid = false;
                    }

                    if (valid)
                    {
                        string sSQL = "DELETE FROM products WHERE product_id=@id";

                        dbCommand.CommandText = sSQL;

                        dbCommand.Parameters.AddWithValue("@id", ID);

                        dbCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("!لا يمكنك حذف هذا الصنف");
                    }

                    dbConn.Close();
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("اختر الصنف المراد حذفه");
                }
            }
            catch { }
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
            try
            {
                ID = Convert.ToInt32(grid_products.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_prodname.Text = grid_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_purprice.Text = grid_products.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_saleprice.Text = grid_products.Rows[e.RowIndex].Cells[3].Value.ToString();

                btn_update.Enabled = true;
                btn_del.Enabled = true;
                btn_save.Enabled = false;
            }
            catch { }
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

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Orange, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }
    }
}
