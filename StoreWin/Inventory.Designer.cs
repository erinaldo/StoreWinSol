namespace StoreWin
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid_prods = new System.Windows.Forms.DataGridView();
            this.radio_one = new System.Windows.Forms.RadioButton();
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.combo_prod = new System.Windows.Forms.ComboBox();
            this.inv_prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_prod_pur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_prod_sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_prod_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_prods)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_prods
            // 
            this.Grid_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_prods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inv_prod_id,
            this.inv_prod_name,
            this.inv_prod_pur,
            this.inv_prod_sel,
            this.inv_prod_qty});
            this.Grid_prods.Location = new System.Drawing.Point(12, 129);
            this.Grid_prods.Name = "Grid_prods";
            this.Grid_prods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_prods.Size = new System.Drawing.Size(503, 338);
            this.Grid_prods.TabIndex = 0;
            // 
            // radio_one
            // 
            this.radio_one.AutoSize = true;
            this.radio_one.Location = new System.Drawing.Point(275, 15);
            this.radio_one.Name = "radio_one";
            this.radio_one.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radio_one.Size = new System.Drawing.Size(75, 17);
            this.radio_one.TabIndex = 1;
            this.radio_one.Text = "صنف محدد";
            this.radio_one.UseVisualStyleBackColor = true;
            this.radio_one.CheckedChanged += new System.EventHandler(this.radio_one_CheckedChanged);
            // 
            // radio_all
            // 
            this.radio_all.AutoSize = true;
            this.radio_all.Checked = true;
            this.radio_all.Location = new System.Drawing.Point(367, 15);
            this.radio_all.Name = "radio_all";
            this.radio_all.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radio_all.Size = new System.Drawing.Size(88, 17);
            this.radio_all.TabIndex = 2;
            this.radio_all.TabStop = true;
            this.radio_all.Text = "جميع الاصناف";
            this.radio_all.UseVisualStyleBackColor = true;
            this.radio_all.CheckedChanged += new System.EventHandler(this.radio_all_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "الصنف";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(329, 89);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "عرض";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // combo_prod
            // 
            this.combo_prod.Enabled = false;
            this.combo_prod.FormattingEnabled = true;
            this.combo_prod.Location = new System.Drawing.Point(101, 51);
            this.combo_prod.Name = "combo_prod";
            this.combo_prod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_prod.Size = new System.Drawing.Size(312, 21);
            this.combo_prod.TabIndex = 6;
            // 
            // inv_prod_id
            // 
            this.inv_prod_id.HeaderText = "";
            this.inv_prod_id.Name = "inv_prod_id";
            this.inv_prod_id.Visible = false;
            // 
            // inv_prod_name
            // 
            this.inv_prod_name.HeaderText = "الصنف";
            this.inv_prod_name.Name = "inv_prod_name";
            this.inv_prod_name.Width = 200;
            // 
            // inv_prod_pur
            // 
            this.inv_prod_pur.HeaderText = "مشتريات";
            this.inv_prod_pur.Name = "inv_prod_pur";
            this.inv_prod_pur.Width = 80;
            // 
            // inv_prod_sel
            // 
            this.inv_prod_sel.HeaderText = "مبيعات";
            this.inv_prod_sel.Name = "inv_prod_sel";
            this.inv_prod_sel.Width = 80;
            // 
            // inv_prod_qty
            // 
            this.inv_prod_qty.HeaderText = "الكمية الحالية";
            this.inv_prod_qty.Name = "inv_prod_qty";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(248, 89);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 7;
            this.btn_print.Text = "طباعة";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 487);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.combo_prod);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_all);
            this.Controls.Add(this.radio_one);
            this.Controls.Add(this.Grid_prods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المخزن";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_prods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_prods;
        private System.Windows.Forms.RadioButton radio_one;
        private System.Windows.Forms.RadioButton radio_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ComboBox combo_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_prod_pur;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_prod_sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_prod_qty;
        private System.Windows.Forms.Button btn_print;
    }
}