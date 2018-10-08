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
    public partial class SalesItems_rep : Form
    {
        string from = "";
        string to = "";
        string type = "";

        public SalesItems_rep()
        {
            InitializeComponent();
        }

        private void SalesItems_rep_Load(object sender, EventArgs e)
        {
            try
            {
                from = Reports.salitemsfrom;
                to = Reports.salitemsto;
                type = Reports.salitemstype;

                string sSQL = "";
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();

                dbConn.Open();
                if (type == "all")
                {
                    sSQL = @"select * FROM sales_inv ORDER BY sales_date DESC";
                }
                else
                {

                    sSQL = @"select * FROM sales_inv WHERE(((Format(sales_date, 'Short Date')) >= #" + from + "# And (Format(sales_date, 'Short Date')) <= #" + to + "#)) ORDER BY sales_date DESC";
                }

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
                DBAdapter.Fill(DS);

                dbConn.Close();

                Reps.Salesitemsrep c1 = new Reps.Salesitemsrep();
                c1.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = c1;
                crystalReportViewer1.Refresh();
            }
            catch { }
        }
    }
}
