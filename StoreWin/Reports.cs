using StoreWin.Reps;
using System;
using System.Drawing;
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

        public static string purretfrom = "";
        public static string purretto = "";
        public static string purrettype = "";

        public static string puritemsfrom = "";
        public static string puritemsto = "";
        public static string puritemstype = "";

        public static string salfrom = "";
        public static string salto = "";
        public static string saltype = "";

        public static string salretfrom = "";
        public static string salretto = "";
        public static string salrettype = "";

        public static string salitemsfrom = "";
        public static string salitemsto = "";
        public static string salitemstype = "";

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

        private void purret_show_Click(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                purretfrom = purret_from.Value.ToShortDateString();
                purretto = purret_to.Value.ToShortDateString();
                purrettype = "";

                Purchasesret_rep rep = new Purchasesret_rep();
                rep.Show();
            }
            else
            {
                purrettype = "all";
                Purchasesret_rep rep = new Purchasesret_rep();
                rep.Show();
            }
        }

        private void salret_show_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                salretfrom = salret_from.Value.ToShortDateString();
                salretto = salret_to.Value.ToShortDateString();
                salrettype = "";

                Salesret_rep rep = new Salesret_rep();
                rep.Show();
            }
            else
            {
                salrettype = "all";
                Salesret_rep rep = new Salesret_rep();
                rep.Show();
            }
        }

        private void puritems_show_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                puritemsfrom = puritems_from.Value.ToShortDateString();
                puritemsto = puritems_to.Value.ToShortDateString();
                puritemstype = "";

                PurchasesItems_rep rep = new PurchasesItems_rep();
                rep.Show();
            }
            else
            {
                puritemstype = "all";
                PurchasesItems_rep rep = new PurchasesItems_rep();
                rep.Show();
            }
        }

        private void salitems_show_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                salitemsfrom = salitems_from.Value.ToShortDateString();
                salitemsto = salitems_to.Value.ToShortDateString();
                salitemstype = "";

                SalesItems_rep rep = new SalesItems_rep();
                rep.Show();
            }
            else
            {
                salitemstype = "all";
                SalesItems_rep rep = new SalesItems_rep();
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

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            purret_from.Enabled = true;
            purret_to.Enabled = true;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            purret_from.Enabled = false;
            purret_to.Enabled = false;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            salret_from.Enabled = true;
            salret_to.Enabled = true;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            salret_from.Enabled = false;
            salret_to.Enabled = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            puritems_from.Enabled = true;
            puritems_to.Enabled = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            puritems_from.Enabled = false;
            puritems_to.Enabled = false;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            salitems_from.Enabled = true;
            salitems_to.Enabled = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            salitems_from.Enabled = false;
            salitems_to.Enabled = false;
        }     
    }
}
