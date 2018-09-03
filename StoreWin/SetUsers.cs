using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class SetUsers : Form
    {
        OleDbDataAdapter adapt;

        public SetUsers()
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
            //DataTable dt = new DataTable();
            DataSet DS = new DataSet();
            adapt = new OleDbDataAdapter("SELECT * FROM users", dbConn);
            adapt.Fill(DS);
            //grid_users.DataSource = dt;
            dbConn.Close();

            grid_users.Rows.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    grid_users.Rows.Add(DS.Tables[0].Rows[i][0].ToString(), DS.Tables[0].Rows[i][1].ToString());
                }
            }
        }

        private void SetUsers_Load(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            txt_user.Text = "";
            txt_pass.Text = "";

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && txt_pass.Text != "")
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                dbConn.Open();
                OleDbCommand dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConn;

                string sSQL = "INSERT INTO users Values(@user,@pass)";
                dbCommand.CommandText = sSQL;

                dbCommand.Parameters.AddWithValue("@user", txt_user.Text);
                dbCommand.Parameters.AddWithValue("@pass", txt_pass.Text);

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
            if (txt_user.Text != "" && txt_pass.Text != "")
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                dbConn.Open();
                OleDbCommand dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConn;

                string sSQL = "UPDATE users SET user_pass='"+ txt_pass.Text + "' WHERE user_name='"+ txt_user.Text + "'";

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
            if (txt_user.Text != "" && txt_user.Text !="admin")
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                dbConn.Open();
                OleDbCommand dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConn;

                string sSQL = "DELETE FROM users WHERE user_name=@user";

                dbCommand.CommandText = sSQL;

                dbCommand.Parameters.AddWithValue("@user", txt_user.Text);

                dbCommand.ExecuteNonQuery();

                dbConn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("! خطأ في الحذف");
            }
        }

        private void grid_users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {         
            txt_user.Text = grid_users.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_pass.Text = grid_users.Rows[e.RowIndex].Cells[1].Value.ToString();

            txt_user.Enabled = false;
            btn_update.Enabled = true;
            btn_del.Enabled = true;
            btn_save.Enabled = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearData();

            txt_user.Enabled = true;
            btn_update.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
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
