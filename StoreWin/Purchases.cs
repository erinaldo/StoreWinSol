using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace StoreWin
{
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            try
            {
                Bindinvno();
                Bindproducts();
                txt_invno.Text = GenerateID().ToString();
                lbl_date.Text = DateTime.Now.ToShortDateString();
            }
            catch { }
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

            txt_prod.DataSource = DS.Tables[0];
            txt_prod.DisplayMember = "product_name";
            txt_prod.ValueMember = "product_id";

        }
        private void Bindinvno()
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            DataSet DS = new DataSet();
            dbConn.Open();

            string query = @"SELECT * from purchases_m ORDER BY purchases_id DESC";
            OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
            DBAdapter.SelectCommand = new OleDbCommand(query, dbConn);
            DBAdapter.Fill(DS);
            dbConn.Close();

            combo_invno.DataSource = DS.Tables[0];
            combo_invno.DisplayMember = "purchases_id";
            combo_invno.ValueMember = "purchases_id";

        }

        protected int GenerateID()
        {
            int new_id = 0;
            int last_id = 0;

            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());

            dbConn.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.Connection = dbConn;

            string sSQL = "SELECT TOP 1 purchases_id FROM purchases_m ORDER BY purchases_id DESC";
            dbCommand.CommandText = sSQL;

            OleDbDataReader reader = dbCommand.ExecuteReader();
            if (reader.Read())
            {
                last_id =Convert.ToInt32(reader[0]);
            }
            

            new_id = last_id + 1;
            return new_id;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                grid_invprods.Rows.Add(txt_prod.SelectedValue, txt_prod.Text, txt_price.Text, txt_qty.Text, Convert.ToInt32(txt_qty.Text) * Convert.ToDecimal(txt_price.Text));
                decimal sum = 0;
                foreach (DataGridViewRow R in grid_invprods.Rows)
                {
                    sum += Convert.ToDecimal(R.Cells[4].Value);
                }
                txt_total.Text = sum.ToString();
                txt_recieve.Text = sum.ToString();
                txt_remain.Text = "0";
            }
            catch { }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                txt_invno.Text = GenerateID().ToString();

                txt_prod.SelectedIndex = 0;
                txt_qty.Text = "0";
                txt_price.Text = "0";

                txt_total.Text = "0";
                txt_recieve.Text = "0";
                txt_remain.Text = "0";

                grid_invprods.Rows.Clear();

                btn_save.Visible = true;

                Bindproducts();
                Bindinvno();

                btn_save.Enabled = true;
                txt_prod.Enabled = true;
                txt_qty.Enabled = true;
                txt_price.Enabled = true;
                btn_add.Enabled = true;
                lbl_date.Text = DateTime.Now.ToShortDateString();
            }
            catch { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txt_recieve.Text) < Convert.ToDecimal(txt_total.Text))
            {
                MessageBox.Show("!المبلغ المدفوع اقل من الاجمالي");
            }
            else
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                OleDbTransaction tr;
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }

                tr = dbConn.BeginTransaction();

                try
                {
                    OleDbCommand dbCommand = new OleDbCommand();
                    dbCommand.Connection = dbConn;
                    dbCommand.Transaction = tr;

                    string sSQL = "INSERT INTO purchases_m(purchases_id,purchases_type,amount,recieve,remain)";
                    sSQL += "Values(@id,@type,@amount,@rec,@rem);";
                    dbCommand.CommandText = sSQL;

                    dbCommand.Parameters.AddWithValue("@id", txt_invno.Text);
                    dbCommand.Parameters.AddWithValue("@type", 1);
                    dbCommand.Parameters.AddWithValue("@amount", txt_total.Text);
                    dbCommand.Parameters.AddWithValue("@rec", txt_recieve.Text);
                    dbCommand.Parameters.AddWithValue("@rem", txt_remain.Text);

                    dbCommand.ExecuteNonQuery();

                    foreach (DataGridViewRow R in grid_invprods.Rows)
                    {

                        OleDbCommand dbCommand2 = new OleDbCommand();
                        dbCommand2.Connection = dbConn;

                        string sSQL2 = "INSERT INTO purchases_d(purchases_id,product_id,qty,unitprice,totalprice)";
                        sSQL2 += "Values(@id,@prodid,@qty,@unitprice,@totalprice);";
                        dbCommand2.CommandText = sSQL2;
                        dbCommand2.Transaction = tr;

                        dbCommand2.Parameters.AddWithValue("@id", txt_invno.Text);
                        dbCommand2.Parameters.AddWithValue("@prodid", R.Cells[0].Value);
                        dbCommand2.Parameters.AddWithValue("@qty", R.Cells[3].Value);
                        dbCommand2.Parameters.AddWithValue("@unitprice", R.Cells[2].Value);
                        dbCommand2.Parameters.AddWithValue("@totalprice", R.Cells[4].Value);

                        dbCommand2.ExecuteNonQuery();

                        OleDbCommand dbCommand4 = new OleDbCommand();
                        dbCommand4.Connection = dbConn;
                        dbCommand4.Transaction = tr;
                        string sSQL4 = "INSERT INTO inventory(product_id,qty,relate_to,relate_id)";
                        sSQL4 += "Values(@prodid,@qty,@relto,@relid);";
                        dbCommand4.CommandText = sSQL4;
                        dbCommand4.Parameters.AddWithValue("@prodid", R.Cells[0].Value);
                        dbCommand4.Parameters.AddWithValue("@qty", R.Cells[3].Value);
                        dbCommand4.Parameters.AddWithValue("@relto", "pur");
                        dbCommand4.Parameters.AddWithValue("@relid", txt_invno.Text);
                        dbCommand4.ExecuteNonQuery();

                        OleDbCommand dbCommand55 = new OleDbCommand();
                        dbCommand55.Connection = dbConn;
                        dbCommand55.Transaction = tr;
                        string sSQL55 = "INSERT INTO inventory(product_id,qty,relate_to)";
                        sSQL55 += "Values(@prodid,@qty,@relto);";
                        dbCommand55.CommandText = sSQL55;
                        dbCommand55.Parameters.AddWithValue("@prodid", R.Cells[0].Value);
                        dbCommand55.Parameters.AddWithValue("@qty", 0);
                        dbCommand55.Parameters.AddWithValue("@relto", "sel");
                        dbCommand55.ExecuteNonQuery();
                    }

                    OleDbCommand dbCommand5 = new OleDbCommand();
                    dbCommand5.Connection = dbConn;
                    dbCommand5.Transaction = tr;
                    string sSQL5 = "INSERT INTO cash(amount,relate_to,relate_id)";
                    sSQL5 += "Values(@amount,@relto,@relid);";
                    dbCommand5.CommandText = sSQL5;
                    dbCommand5.Parameters.AddWithValue("@amount", txt_total.Text);
                    dbCommand5.Parameters.AddWithValue("@relto", "pur");
                    dbCommand5.Parameters.AddWithValue("@relid", txt_invno.Text);
                    dbCommand5.ExecuteNonQuery();


                    OleDbCommand dbCommand3 = new OleDbCommand();
                    dbCommand3.Connection = dbConn;
                    dbCommand3.Transaction = tr;

                    string sSQL3 = "INSERT INTO Processes(process_name)";
                    sSQL3 += "Values(@p_name);";
                    dbCommand3.CommandText = sSQL3;

                    string p_name = "عملية شراء - اجمالي مبلغ '" + txt_total.Text + "' - مستلم '" + txt_recieve.Text + "' - متبقي '" + txt_remain.Text + "'";

                    dbCommand3.Parameters.AddWithValue("@p_name", p_name);

                    dbCommand3.ExecuteNonQuery();

                    tr.Commit();
                    dbConn.Close();
                    MessageBox.Show("تم حفظ الفاتورة");
                }
                catch
                {
                    tr.Rollback();
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                //master
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS1 = new DataSet();
                dbConn.Open();

                string query1 = @"SELECT * from purchases_m WHERE purchases_id = " + combo_invno.SelectedValue + "";
                OleDbDataAdapter DBAdapter1 = new OleDbDataAdapter();
                DBAdapter1.SelectCommand = new OleDbCommand(query1, dbConn);
                DBAdapter1.Fill(DS1);

                if (DS1.Tables[0].Rows.Count > 0)
                {
                    txt_invno.Text = DS1.Tables[0].Rows[0][0].ToString();
                    txt_total.Text = DS1.Tables[0].Rows[0][3].ToString();
                    txt_recieve.Text = DS1.Tables[0].Rows[0][4].ToString();
                    txt_remain.Text = DS1.Tables[0].Rows[0][5].ToString();
                    lbl_date.Text = DS1.Tables[0].Rows[0][1].ToString();
                }

                //details
                DataSet DS = new DataSet();

                string query = @"SELECT * from purchases_d_query WHERE purchases_id = " + combo_invno.SelectedValue + "";
                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(query, dbConn);
                DBAdapter.Fill(DS);
                dbConn.Close();

                grid_invprods.Rows.Clear();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        grid_invprods.Rows.Add(DS.Tables[0].Rows[i][1].ToString(), DS.Tables[0].Rows[i][2].ToString(), DS.Tables[0].Rows[i][3].ToString(), DS.Tables[0].Rows[i][4].ToString(), DS.Tables[0].Rows[i][5].ToString());
                    }
                }

                btn_save.Enabled = false;
                txt_prod.Enabled = false;
                txt_qty.Enabled = false;
                txt_price.Enabled = false;
                btn_add.Enabled = false;
            }
            catch { }
        }

        private void txt_recieve_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_recieve.Text != "" && txt_recieve.Text != null && Convert.ToDecimal(txt_recieve.Text) > Convert.ToDecimal(txt_total.Text))
            {
                txt_remain.Text = (Convert.ToDecimal(txt_recieve.Text) - Convert.ToDecimal(txt_total.Text)).ToString();
            }
        }

        private void txt_recieve_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txt_recieve.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txt_price.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Orange, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 10, 5);
            gfx.DrawLine(p, 0, 5, e.ClipRectangle.Width - 80, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }
    }
}
