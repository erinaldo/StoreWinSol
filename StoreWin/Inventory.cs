using StoreWin.App_Code;
using StoreWin.Reps;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace StoreWin
{
    public partial class Inventory : Form
    {
        Connection con = new Connection();
        public Inventory()
        {
            InitializeComponent();           
        }

        private void Bindproducts()
        {
            try
            {
                DataSet DS = new DataSet();

                DS = con.Select("SELECT * from products", "prods");

                combo_prod.DisplayMember = "product_name";
                combo_prod.ValueMember = "product_id";
                combo_prod.DataSource = DS.Tables["prods"];
            }
            catch { }
        }

        private void BindQty()
        {
            try
            {
                DataSet DS = new DataSet();

                DS = con.Select("select * from inventory_query_rep where product_id =" + combo_prod.SelectedValue + "", "inventory");

                Grid_prods.Rows.Clear();

                if (DS.Tables["inventory"].Rows.Count > 0)
                {
                    Grid_prods.Rows.Add(DS.Tables["inventory"].Rows[0][0].ToString(), DS.Tables["inventory"].Rows[0][1].ToString(), DS.Tables["inventory"].Rows[0][2].ToString(), DS.Tables["inventory"].Rows[0][3].ToString(), DS.Tables["inventory"].Rows[0][4].ToString());
                }
            }
            catch { }
        }

        private void BindAllQty()
        {
            try
            {
                DataSet DS = new DataSet();

                DS = con.Select("select * from inventory_query_rep", "invqty");

                Grid_prods.Rows.Clear();

                if (DS.Tables["invqty"].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables["invqty"].Rows.Count; i++)
                    {
                        Grid_prods.Rows.Add(DS.Tables["invqty"].Rows[i][0].ToString(), DS.Tables["invqty"].Rows[i][1].ToString(), DS.Tables["invqty"].Rows[i][2].ToString(), DS.Tables["invqty"].Rows[i][3].ToString(), DS.Tables["invqty"].Rows[i][4].ToString());
                    }
                }
            }
            catch { }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Bindproducts();
        }

        private void radio_all_CheckedChanged(object sender, EventArgs e)
        {
            combo_prod.Enabled = false;
            btn_print.Enabled = true;
        }

        private void radio_one_CheckedChanged(object sender, EventArgs e)
        {
            combo_prod.Enabled = true;
            btn_print.Enabled = false;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if(radio_all.Checked)
            {
                BindAllQty();
            }
            else if(radio_one.Checked)
            {
                BindQty();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Inventory_rep invrep = new Inventory_rep();
            invrep.Show();
        }
    }
}
