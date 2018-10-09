using StoreWin.App_Code;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Cash : Form
    {
        Connection con = new Connection();

        public Cash()
        {
            InitializeComponent();
        }

        private decimal Cash_out()
        {
            decimal cashout = 0;

            DataSet ds = con.Select("SELECT sum(amount) from cash WHERE((Format(actiondate, 'Short Date')=DATE()) AND relate_to='pur')", "cashout");
            if (ds.Tables["cashout"].Rows.Count > 0 && ds.Tables["cashout"].Rows[0][0].ToString() !="")
            {
                cashout = Convert.ToDecimal(ds.Tables["cashout"].Rows[0][0].ToString());
            }
            else
            {
                cashout = 0;
            }
            return cashout;
        }

        private decimal Cash_in()
        {
            decimal cashin = 0;

            DataSet ds = con.Select("SELECT sum(amount) from cash WHERE Format(actiondate, 'Short Date')=DATE() AND relate_to <> 'pur'", "cashin");
            if (ds.Tables["cashin"].Rows.Count > 0 && ds.Tables["cashin"].Rows[0][0].ToString() != "")
            {
                cashin = Convert.ToDecimal(ds.Tables["cashin"].Rows[0][0].ToString());
            }
            else
            {
                cashin = 0;
            }
            return cashin;
        }

        private void BindCash()
        {
            textBox4.Text = Cash_out().ToString();

            textBox1.Text = Cash_in().ToString();

            DataSet ds = con.Select("SELECT ID,actiondate from cash WHERE Format(actiondate, 'Short Date')=DATE() ORDER BY ID DESC", "cash");

            if (ds.Tables["cash"].Rows.Count > 0)
            {
                textBox2.Text = ds.Tables["cash"].Rows[0][1].ToString();
            }
        }
        private void Cash_Load(object sender, EventArgs e)
        {
            try
            {
                BindCash();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Excute("INSERT INTO cash(amount,relate_to,relate_id) Values('" + textBox3.Text + "','add',0);");               

                BindCash();
            }
            catch { }
        }
    }
}
