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

namespace StoreWin.Reps
{
    public partial class PurchasesItems_rep : Form
    {
        string from = "";
        string to = "";
        string type = "";

        public PurchasesItems_rep()
        {
            InitializeComponent();
        }

        private void PurchasesItems_rep_Load(object sender, EventArgs e)
        {
            try
            {
                from = Reports.puritemsfrom;
                to = Reports.puritemsto;
                type = Reports.puritemstype;

                string sSQL = "";
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();

                dbConn.Open();
                if (type == "all")
                {
                    sSQL = @"select * FROM purchases_inv ORDER BY purchases_date DESC";
                }
                else
                {

                    sSQL = @"select * FROM purchases_inv WHERE(((Format(purchases_date, 'Short Date')) >= #" + from + "# And (Format(purchases_date, 'Short Date')) <= #" + to + "#)) ORDER BY purchases_date DESC";
                }

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
                DBAdapter.Fill(DS);

                dbConn.Close();

                Reps.Purchasesitemsrep c1 = new Reps.Purchasesitemsrep();
                c1.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = c1;
                crystalReportViewer1.Refresh();
            }
            catch { }
        }
    }
}
