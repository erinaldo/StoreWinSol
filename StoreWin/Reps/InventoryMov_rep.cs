using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StoreWin.Reps
{
    public partial class InventoryMov_rep : Form
    {
        string from = "";
        string to = "";
        string type = "";

        public InventoryMov_rep()
        {
            InitializeComponent();
        }

        private void InventoryMov_rep_Load(object sender, EventArgs e)
        {
            try
            {
                from = Reports.invfrom;
                to = Reports.invto;
                type = Reports.invtype;

                string sSQL = "";
                OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
                DataSet DS = new DataSet();

                dbConn.Open();
                if (type == "all")
                {
                    sSQL = @"select product_id,product_name,qty,
                            IIf(relate_to='pur','عملية شراء بفاتورة مشتريات'
                           ,IIf(relate_to='sel','عملية بيع بفاتورة مبيعات'))
                              AS relate_to
                           ,relate_id,action_date 
                            FROM inventory_query WHERE relate_id <> 0 ORDER BY action_date DESC";
                }
                else
                {
                    sSQL = @"select product_id,product_name,qty,
                            IIf(relate_to='pur','عملية شراء بفاتورة مشتريات'
                           ,IIf(relate_to='sel','عملية بيع بفاتورة مبيعات'))
                              AS relate_to
                           ,relate_id,action_date 
                            FROM inventory_query 
                            WHERE(((Format(action_date, 'Short Date')) Between #" + from + "# And #" + to + "#) AND relate_id <> 0) ORDER BY action_date DESC";
                }


                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = new OleDbCommand(sSQL, dbConn);
                DBAdapter.Fill(DS);

                dbConn.Close();

                Reps.InventoryMovrep c1 = new Reps.InventoryMovrep();
                c1.SetDataSource(DS.Tables[0]);
                crystalReportViewer1.ReportSource = c1;
                crystalReportViewer1.Refresh();
            }
            catch { }
        }
    }
}
