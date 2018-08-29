using StoreWin.Reps;
using System;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Reports : Form
    {
        public static string cashfrom = "";
        public static string cashto = "";
        public static string cashtype = "";

        public static string invfrom = "";
        public static string invto = "";
        public static string invtype = "";

        public static string purfrom = "";
        public static string purto = "";
        public static string purtype = "";

        public static string salfrom = "";
        public static string salto = "";
        public static string saltype = "";

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void pur_show_Click(object sender, EventArgs e)
        {           
            if (radioButton8.Checked)
            {
                purfrom = pur_from.Value.ToShortDateString();
                purto = pur_to.Value.ToShortDateString();
                purtype = "";

                Purchases_rep rep = new Purchases_rep();
                rep.Show();
            }
            else
            {
                purtype = "all";
                Purchases_rep rep = new Purchases_rep();
                rep.Show();
            }
        }

        private void sal_show_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                salfrom = sal_from.Value.ToShortDateString();
                salto = sal_to.Value.ToShortDateString();
                saltype = "";

                Sales_rep rep = new Sales_rep();
                rep.Show();
            }
            else
            {
                saltype = "all";
                Sales_rep rep = new Sales_rep();
                rep.Show();
            }
            
        }

        private void cash_show_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cashfrom = cash_from.Value.ToShortDateString();
                cashto = cash_to.Value.ToShortDateString();
                cashtype = "";
                CashMov_rep rep = new CashMov_rep();
                rep.Show();
            }
            else
            {
                cashtype = "all";
                CashMov_rep rep = new CashMov_rep();
                rep.Show();
            }
        }

        private void inv_show_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                invfrom = inv_from.Value.ToShortDateString();
                invto = inv_to.Value.ToShortDateString();
                invtype = "";
                InventoryMov_rep rep = new InventoryMov_rep();
                rep.Show();
            }
            else
            {
                invtype = "all";
                InventoryMov_rep rep = new InventoryMov_rep();
                rep.Show();
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cash_from.Enabled = false;
            cash_to.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cash_from.Enabled = true;
            cash_to.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            inv_from.Enabled = true;
            inv_to.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            inv_from.Enabled = false;
            inv_to.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            sal_from.Enabled = true;
            sal_to.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            sal_from.Enabled = false;
            sal_to.Enabled = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pur_from.Enabled = true;
            pur_to.Enabled = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pur_from.Enabled = false;
            pur_to.Enabled = false;
        }
        
    }
}
