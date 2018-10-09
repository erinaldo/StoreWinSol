using StoreWin.App_Code;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Products : Form
    {
        Connection con = new Connection();
        int ID = 0;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            DisplayData();
            btn_update.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
        }
        private void DisplayData()
        {
            try
            {
                DataSet DS = new DataSet();

                DS = con.Select("SELECT product_id,product_name,pur_price, sal_price FROM products", "prods");

                grid_products.Rows.Clear();

                if (DS.Tables["prods"].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        grid_products.Rows.Add(DS.Tables[0].Rows[i][0].ToString(), DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString(), DS.Tables[0].Rows[i][3].ToString());
                    }
                }
                DS.Clear();
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
                    con.Excute("INSERT INTO products(product_name,pur_price,sal_price) Values('"+ txt_prodname.Text + "','"+ txt_purprice.Text + "','"+ txt_saleprice.Text + "');");

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
                    con.Excute("UPDATE products SET product_name='" + txt_prodname.Text + "',pur_price='" + txt_purprice.Text + "',sal_price='" + txt_saleprice.Text + "' WHERE product_id=" + ID + ";");

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
                    DataSet DS1 = new DataSet();
                    DataSet DS2 = new DataSet();

                    DS1 = con.Select("SELECT * FROM purchases_d WHERE product_id=" + ID + "","pur_d");

                    if (DS1.Tables["pur_d"].Rows.Count > 0)
                    {
                        valid = false;
                    }

                    DS1 = con.Select("SELECT * FROM sales_d WHERE product_id=" + ID + "", "sal_d");
                   
                    if (DS1.Tables["sal_d"].Rows.Count > 0)
                    {
                        valid = false;
                    }

                    if (valid)
                    {
                        con.Excute("DELETE FROM products WHERE product_id="+ ID + ";");                      
                    }
                    else
                    {
                        MessageBox.Show("!لا يمكنك حذف هذا الصنف");
                    }
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
    }
}
