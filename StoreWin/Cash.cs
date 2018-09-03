using System;
using System.Configuration;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Cash : Form
    {
        OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());

        public Cash()
        {
            InitializeComponent();
        }

        private decimal Cash_out()
        {
            decimal cashout = 0;

            dbConn.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.Connection = dbConn;

            string sSQL = "SELECT sum(amount) from cash WHERE((Format(actiondate, 'Short Date')=DATE()) AND relate_to='pur')";
            //string sSQL = "SELECT sum(amount) from cash WHERE relate_to = 'pur'";
            dbCommand.CommandText = sSQL;

            OleDbDataReader reader = dbCommand.ExecuteReader();
            if (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    cashout = 0;
                    
                }
                else
                {
                    cashout = Convert.ToDecimal(reader[0]);
                }
            }
            dbConn.Close();
            return cashout;
        }

        private decimal Cash_in()
        {
            decimal cashin = 0;

            dbConn.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.Connection = dbConn;

            string sSQL = "SELECT sum(amount) from cash WHERE Format(actiondate, 'Short Date')=DATE() AND relate_to <> 'pur'";
            //string sSQL = "SELECT sum(amount) from cash WHERE relate_to <> 'pur'";
            dbCommand.CommandText = sSQL;

            OleDbDataReader reader = dbCommand.ExecuteReader();
            if (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    cashin = 0;                 
                }
                else
                {
                    cashin = Convert.ToDecimal(reader[0]);
                }
                
            }
            dbConn.Close();
            return cashin;
        }
        private void Cash_Load(object sender, EventArgs e)
        {
            textBox4.Text = Cash_out().ToString();

            textBox1.Text = Cash_in().ToString();

            dbConn.Open();

            OleDbCommand dbCommand2 = new OleDbCommand();
            dbCommand2.Connection = dbConn;

            string sSQL2 = "SELECT actiondate from cash WHERE Format(actiondate, 'Short Date')=DATE() ORDER BY actiondate DESC";
            //string sSQL2 = "SELECT actiondate from cash ORDER BY actiondate DESC";

            dbCommand2.CommandText = sSQL2;

            OleDbDataReader reader2 = dbCommand2.ExecuteReader();
            if (reader2.Read())
            {
                textBox2.Text = reader2[0].ToString();
            }
            dbConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            dbConn.Open();

            OleDbCommand dbCommand5 = new OleDbCommand();
            dbCommand5.Connection = dbConn;
            string sSQL5 = "INSERT INTO cash(amount,relate_to,relate_id)";
            sSQL5 += "Values(@amount,@relto,@relid);";
            dbCommand5.CommandText = sSQL5;
            dbCommand5.Parameters.AddWithValue("@amount", textBox3.Text);
            dbCommand5.Parameters.AddWithValue("@relto", "add");
            dbCommand5.Parameters.AddWithValue("@relid", 0);
            dbCommand5.ExecuteNonQuery();

            dbConn.Close();

            textBox1.Text = Cash_in().ToString();
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
