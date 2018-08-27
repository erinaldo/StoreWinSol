using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StoreWin.Reps
{
    public partial class Salesinv_rep : Form
    {
        public Salesinv_rep()
        {
            InitializeComponent();
        }

        private void Salesinv_rep_Load(object sender, EventArgs e)
        {
            int id = Sales.salesid;

            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
            DataSet DS = new DataSet();
            dbConn.Open();

            string query = @"SELECT * from sales_inv WHERE sales_id = " + id + "";
            OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
            DBAdapter.SelectCommand = new OleDbCommand(query, dbConn);
            DBAdapter.Fill(DS);
            dbConn.Close();

            
            Reps.Salesinv c1 = new Reps.Salesinv();
            c1.SetDataSource(DS.Tables[0]);
            crystalReportViewer1.ReportSource = c1;
            crystalReportViewer1.Refresh();
        }
    }
}
