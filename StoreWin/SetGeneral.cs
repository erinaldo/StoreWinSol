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
    public partial class SetGeneral : Form
    {
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
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                OleDbDataAdapter adapt;
                dbConn.Open();
                DataSet DS = new DataSet();
                adapt = new OleDbDataAdapter("SELECT * FROM Generalset", dbConn);
                adapt.Fill(DS);
                dbConn.Close();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    txt_name.Text = DS.Tables[0].Rows[0][1].ToString();
                    txt_phone.Text = DS.Tables[0].Rows[0][2].ToString();
                    txt_mobile.Text = DS.Tables[0].Rows[0][3].ToString();
                }
            }
            catch { }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Orange, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 10, 5);
            gfx.DrawLine(p, 0, 5, e.ClipRectangle.Width - 70, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            try
            {
                OleDbDataAdapter adapt;
                dbConn.Open();
                DataSet DS = new DataSet();
                adapt = new OleDbDataAdapter("SELECT * FROM Generalset", dbConn);
                adapt.Fill(DS);
                dbConn.Close();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    dbConn.Open();
                    OleDbCommand dbCommand = new OleDbCommand();
                    dbCommand.Connection = dbConn;

                    string sSQL = "UPDATE Generalset SET store_name='" + txt_name.Text + "',store_phone='" + txt_phone.Text + "',store_mobile='" + txt_mobile.Text + "'";

                    dbCommand.CommandText = sSQL;

                    dbCommand.ExecuteNonQuery();

                    dbConn.Close();
                    DisplayData();
                }
                else
                {
                    dbConn.Open();
                    OleDbCommand dbCommand = new OleDbCommand();
                    dbCommand.Connection = dbConn;

                    string sSQL = "INSERT INTO Generalset(store_name,store_phone,store_mobile) VALUES('" + txt_name.Text + "','" + txt_phone.Text + "','" + txt_mobile.Text + "')";

                    dbCommand.CommandText = sSQL;

                    dbCommand.ExecuteNonQuery();

                    dbConn.Close();
                    DisplayData();
                }
            }
            catch { }
        }      
    }
}
