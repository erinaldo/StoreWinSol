using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace StoreWin.App_Code
{
    public class Connection
    {  
        public OleDbConnection Cn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public DataSet Select(string sql, string Table)
        {
            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            //ds.Clear() ; 
            da = new OleDbDataAdapter(sql, Cn);
            da.Fill(ds, Table);

            Cn.Close();

            return ds;
        }
        public void Excute(string sql)
        {

            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            OleDbCommand Run = new OleDbCommand(sql, Cn);
            OleDbTransaction tr;
            tr = Cn.BeginTransaction();
            Run.Transaction = tr;
            Run.CommandTimeout = 0;
            try
            {
                Run.ExecuteNonQuery();
                tr.Commit();
            }
            catch
            {
                tr.Rollback();
            }
            Cn.Close();
        }
    }
}
