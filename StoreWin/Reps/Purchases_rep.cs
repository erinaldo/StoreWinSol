using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StoreWin.Reps
{
    public partial class Purchases_rep : Form
    {
        string from = "";
        string to = "";
        string type = "";

        public Purchases_rep()
        {
            InitializeComponent();
        }

        private void Purchases_rep_Load(object sender, EventArgs e)
        {
            try
            {
                from = Reports.purfrom;
                to = Reports.purto;
                type = Reports.purtype;

                string sSQL = "";
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();

                dbConn.Open();
                if (type == "all")
                {
                    sSQL = @"select * FROM purchases_m ORDER BY purchases_date DESC";
                }
                else
                {

                    sSQL = @"select * FROM purchases_m WHERE(((Format(purchases_date, 'Short Date')) >= #" + from + "# And (Format(purchases_date, 'Short Date')) <= #" + to + "#)) ORDER BY purchases_date DESC";
                }

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
                DBAdapter.Fill(DS);

                dbConn.Close();

                Reps.Purchasesrep c1 = new Reps.Purchasesrep();
                c1.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = c1;
                crystalReportViewer1.Refresh();
            }
            catch { }
        }
    }
}
