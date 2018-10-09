using StoreWin.App_Code;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class SetUsers : Form
    {
        Connection con = new Connection();
        public SetUsers()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            DataSet DS = new DataSet();
            grid_users.Rows.Clear();

            DS = con.Select("SELECT * FROM users", "users");
            
            if (DS.Tables["users"].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables["users"].Rows.Count; i++)
                {
                    grid_users.Rows.Add(DS.Tables["users"].Rows[i][0].ToString(), DS.Tables["users"].Rows[i][1].ToString());
                }
            }
            DS.Clear();
        }

        private void SetUsers_Load(object sender, EventArgs e)
        {
            DisplayData();
            btn_update.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
        }
        private void ClearData()
        {
            txt_user.Text = "";
            txt_pass.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text != "" && txt_pass.Text != "")
                {
                    con.Excute("INSERT INTO users Values('"+ txt_user.Text + "','"+ txt_pass.Text + "')");
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
                if (txt_user.Text != "" && txt_pass.Text != "")
                {
                    con.Excute("UPDATE users SET user_pass='" + txt_pass.Text + "' WHERE user_name='" + txt_user.Text + "'");

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
                if (txt_user.Text != "" && txt_user.Text != "admin")
                {
                    con.Excute("DELETE FROM users WHERE user_name='"+ txt_user.Text + "'");

                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("! خطأ في الحذف");
                }
            }
            catch { }
        }

        private void grid_users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txt_user.Text = grid_users.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_pass.Text = grid_users.Rows[e.RowIndex].Cells[1].Value.ToString();

                txt_user.Enabled = false;
                btn_update.Enabled = true;
                btn_del.Enabled = true;
                btn_save.Enabled = false;
            }
            catch { }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearData();

            txt_user.Enabled = true;
            btn_update.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = true;
        }
    }
}
