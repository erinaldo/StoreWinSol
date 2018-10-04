using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StoreWin.Reps
{
    public partial class Inventory_rep : Form
    {
        public Inventory_rep()
        {
            InitializeComponent();
        }

        private void Inventory_rep_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();

                dbConn.Open();
                string sSQL = "select * from inventory_query_rep";
                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
                DBAdapter.Fill(DS);

                dbConn.Close();

                Reps.Inventoryrep c1 = new Reps.Inventoryrep();
                c1.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = c1;
                crystalReportViewer1.Refresh();
            }
            catch { }
        }
    }
}
