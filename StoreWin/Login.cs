using System;
using System.Configuration;
using System.Data.OleDb;
using System.Drawing;
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

            string sSQL = "SELECT * FROM users WHERE user_name = '"+ textBox_username.Text + "' AND user_pass = '"+ textBox_pass.Text + "'";
            dbCommand.CommandText = sSQL;

            //dbCommand.Parameters.AddWithValue("@username", textBox_username.Text);
            //dbCommand.Parameters.AddWithValue("@pass", textBox_pass.Text);

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

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Orange, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 10, 5);
            gfx.DrawLine(p, 0, 5, e.ClipRectangle.Width - 80, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }
    }
}
