using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StoreWin.Reps
{
    public partial class CashMov_rep : Form
    {
        string from = "";
        string to = "";
        string type = "";

        public CashMov_rep()
        {
            InitializeComponent();
        }

        private void CashMov_rep_Load(object sender, EventArgs e)
        {
            try
            {
                from = Reports.cashfrom;
                to = Reports.cashto;
                type = Reports.cashtype;

                string sSQL = "";
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();

                dbConn.Open();
                if (type == "all")
                {
                    sSQL = @"select amount,
                            IIf(relate_to='pur','عملية دفع بفاتورة مشتريات'
                           ,IIf(relate_to='sel','عملية إدخال بفاتورة مبيعات'))
                              AS relate_to
                           ,relate_id,actiondate 
                            FROM cash WHERE relate_id <> 0 ORDER BY actiondate DESC";
                }
                else
                {
                    sSQL = @"select amount,
                            IIf(relate_to='pur','عملية دفع بفاتورة مشتريات'
                           ,IIf(relate_to='sel','عملية إدخال بفاتورة مبيعات'))
                              AS relate_to
                           ,relate_id,actiondate 
                            FROM cash WHERE(((Format(actiondate, 'Short Date')) Between #" + from + "# And #" + to + "#) AND ((cash.relate_id)<> 0)) ORDER BY actiondate DESC";
                }


                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
                DBAdapter.Fill(DS);

                dbConn.Close();

                Reps.CashMovrep c1 = new Reps.CashMovrep();
                c1.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = c1;
                crystalReportViewer1.Refresh();
            }
            catch { }
        }
    }
}
