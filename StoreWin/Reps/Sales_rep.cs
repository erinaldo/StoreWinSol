using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StoreWin.Reps
{   
    public partial class Sales_rep : Form
    {
        string from = "";
        string to = "";
        string type = "";

        public Sales_rep()
        {
            InitializeComponent();
        }

        private void Sales_rep_Load(object sender, EventArgs e)
        {
            try
            {
                from = Reports.salfrom;
                to = Reports.salto;
                type = Reports.saltype;

                string sSQL = "";
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();

                dbConn.Open();
                if (type == "all")
                {
                    sSQL = @"select * FROM sales_m ORDER BY sales_date DESC";
                }
                else
                {

                    sSQL = @"select * FROM sales_m WHERE(((Format(sales_date, 'Short Date')) Between #" + from + "# And #" + to + "#)) ORDER BY sales_date DESC";
                }

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
                DBAdapter.Fill(DS);

                dbConn.Close();

                Reps.Salesrep c1 = new Reps.Salesrep();
                c1.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = c1;
                crystalReportViewer1.Refresh();
            }
            catch { }
        }
    }
}
