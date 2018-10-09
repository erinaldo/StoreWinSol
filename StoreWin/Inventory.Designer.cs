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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.Grid_prods = new System.Windows.Forms.DataGridView();
            this.inv_prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_prod_pur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_prod_sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_prod_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radio_one = new System.Windows.Forms.RadioButton();
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.combo_prod = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_prods)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_prods
            // 
            this.Grid_prods.AllowUserToAddRows = false;
            this.Grid_prods.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Grid_prods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_prods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inv_prod_id,
            this.inv_prod_name,
            this.inv_prod_pur,
            this.inv_prod_sel,
            this.inv_prod_qty});
            this.Grid_prods.Location = new System.Drawing.Point(18, 121);
            this.Grid_prods.Name = "Grid_prods";
            this.Grid_prods.ReadOnly = true;
            this.Grid_prods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.Grid_prods.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_prods.Size = new System.Drawing.Size(503, 338);
            this.Grid_prods.TabIndex = 0;
            // 
            // inv_prod_id
            // 
            this.inv_prod_id.HeaderText = "";
            this.inv_prod_id.Name = "inv_prod_id";
            this.inv_prod_id.ReadOnly = true;
            this.inv_prod_id.Visible = false;
            // 
            // inv_prod_name
            // 
            this.inv_prod_name.HeaderText = "الصنف";
            this.inv_prod_name.Name = "inv_prod_name";
            this.inv_prod_name.ReadOnly = true;
            this.inv_prod_name.Width = 200;
            // 
            // inv_prod_pur
            // 
            this.inv_prod_pur.HeaderText = "مشتريات";
            this.inv_prod_pur.Name = "inv_prod_pur";
            this.inv_prod_pur.ReadOnly = true;
            this.inv_prod_pur.Width = 80;
            // 
            // inv_prod_sel
            // 
            this.inv_prod_sel.HeaderText = "مبيعات";
            this.inv_prod_sel.Name = "inv_prod_sel";
            this.inv_prod_sel.ReadOnly = true;
            this.inv_prod_sel.Width = 80;
            // 
            // inv_prod_qty
            // 
            this.inv_prod_qty.HeaderText = "الكمية الحالية";
            this.inv_prod_qty.Name = "inv_prod_qty";
            this.inv_prod_qty.ReadOnly = true;
            // 
            // radio_one
            // 
            this.radio_one.AutoSize = true;
            this.radio_one.Location = new System.Drawing.Point(341, 18);
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
            this.radio_all.Location = new System.Drawing.Point(433, 18);
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
            this.label1.Location = new System.Drawing.Point(485, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "الصنف";
            // 
            // btn_show
            // 
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Location = new System.Drawing.Point(395, 92);
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
            this.combo_prod.Location = new System.Drawing.Point(167, 54);
            this.combo_prod.Name = "combo_prod";
            this.combo_prod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_prod.Size = new System.Drawing.Size(312, 21);
            this.combo_prod.TabIndex = 6;
            // 
            // btn_print
            // 
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Location = new System.Drawing.Point(314, 92);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 7;
            this.btn_print.Text = "طباعة";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_one);
            this.groupBox1.Controls.Add(this.Grid_prods);
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.radio_all);
            this.groupBox1.Controls.Add(this.combo_prod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_show);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(543, 479);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 506);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المخزون";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_prods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}