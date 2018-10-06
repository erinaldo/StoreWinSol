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
    public partial class Purchasesret_rep : Form
    {
        string from = "";
        string to = "";
        string type = "";

        public Purchasesret_rep()
        {
            InitializeComponent();
        }

        private void Purchasesret_rep_Load(object sender, EventArgs e)
        {
            try
            {
                from = Reports.purretfrom;
                to = Reports.purretto;
                type = Reports.purrettype;

                string sSQL = "";
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();

                dbConn.Open();
                if (type == "all")
                {
                    sSQL = @"select * FROM purchases_ret_query ORDER BY ret_date DESC";
                }
                else
                {

                    sSQL = @"select * FROM purchases_ret_query WHERE(((Format(ret_date, 'Short Date')) >= #" + from + "# And (Format(ret_date, 'Short Date')) <= #" + to + "#)) ORDER BY ret_date DESC";
                }

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
                DBAdapter.Fill(DS);

                dbConn.Close();

                Reps.Purchasesretrep c1 = new Reps.Purchasesretrep();
                c1.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = c1;
                crystalReportViewer1.Refresh();
            }
            catch { }
        }
    }
}
