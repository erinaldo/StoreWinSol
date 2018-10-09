using StoreWin.App_Code;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class SetGeneral : Form
    {
        Connection con = new Connection();
        public SetGeneral()
        {
            InitializeComponent();
        }

        private void SetGeneral_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            try
            {
                DataSet DS = new DataSet();

                DS = con.Select("SELECT * FROM Generalset", "gset");

                if (DS.Tables["gset"].Rows.Count > 0)
                {
                    txt_name.Text = DS.Tables[0].Rows[0][1].ToString();
                    txt_phone.Text = DS.Tables[0].Rows[0][2].ToString();
                    txt_mobile.Text = DS.Tables[0].Rows[0][3].ToString();
                }
            }
            catch { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();

                DS = con.Select("SELECT * FROM Generalset", "generalset");

                if (DS.Tables["generalset"].Rows.Count > 0)
                {
                    con.Excute("UPDATE Generalset SET store_name='" + txt_name.Text + "',store_phone='" + txt_phone.Text + "',store_mobile='" + txt_mobile.Text + "'");
                    DisplayData();
                }
                else
                {
                    con.Excute("INSERT INTO Generalset(store_name,store_phone,store_mobile) VALUES('" + txt_name.Text + "','" + txt_phone.Text + "','" + txt_mobile.Text + "')");
                    DisplayData();
                }
            }
            catch { }
        }      
    }
}
