using System;
using System.Configuration;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Login : Form
    {
        public static bool x1;
        public static string User = "";
        public Login()
        {
            InitializeComponent();
        }


        private void button_login_Click(object sender, EventArgs e)
        {
            //access
            OleDbConnection dbConn = new OleDbConnection(ConfigurationManager.ConnectionStrings["PieStoreV1.Properties.Settings.StoreDBConnectionString"].ToString());

            dbConn.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.Connection = dbConn;

            string sSQL = "SELECT * FROM users WHERE username = @username AND user_pass = @pass";
            dbCommand.CommandText = sSQL;

            dbCommand.Parameters.AddWithValue("@username", textBox_username.Text);
            dbCommand.Parameters.AddWithValue("@pass", textBox_pass.Text);

            OleDbDataReader reader = dbCommand.ExecuteReader();

            if (reader.Read())
            {
                x1 = true;
                this.Hide();
                User = textBox_username.Text;

                OleDbCommand dbCommand3 = new OleDbCommand();
                dbCommand3.Connection = dbConn;

                string sSQL3 = "INSERT INTO Processes(process_name)";
                sSQL3 += "Values(@p_name);";
                dbCommand3.CommandText = sSQL3;

                string p_name = "عملية دخول للبرنامج - المستخدم  '"+ User + "' ";

                dbCommand3.Parameters.AddWithValue("@p_name", p_name);

                dbCommand3.ExecuteNonQuery();
            }
            else
            {

            }
            dbConn.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
