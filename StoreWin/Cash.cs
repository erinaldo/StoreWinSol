using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace StoreWin
{
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
        }

        private void Cash_Load(object sender, EventArgs e)
        {
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());

            dbConn.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.Connection = dbConn;

            string sSQL = "SELECT sum(amount) from cash WHERE Format(actiondate, 'Short Date')=DATE()";
            dbCommand.CommandText = sSQL;

            OleDbDataReader reader = dbCommand.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
            }

            OleDbCommand dbCommand2 = new OleDbCommand();
            dbCommand2.Connection = dbConn;

            string sSQL2 = "SELECT actiondate from cash WHERE Format(actiondate, 'Short Date')=DATE() ORDER BY actiondate DESC";
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
        }
    }
}
