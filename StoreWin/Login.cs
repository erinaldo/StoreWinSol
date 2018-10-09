using StoreWin.App_Code;
using System;
using System.Data;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Login : Form
    {
        Connection con = new Connection();

        public static bool x1;
        public static string User = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            DataSet ds = con.Select("SELECT * FROM users WHERE user_name = '" + textBox_username.Text + "' AND user_pass = '" + textBox_pass.Text + "'", "users");

            if (ds.Tables["users"].Rows.Count >0)
            {
                x1 = true;
                this.Hide();
                User = textBox_username.Text;

                string p_name = "عملية دخول للبرنامج - المستخدم  "+ User;

                con.Excute("INSERT INTO Processes(process_name) Values('"+ p_name + "');");
            }
            else
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
