namespace StoreWin
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.txt_prodname = new System.Windows.Forms.TextBox();
            this.txt_purprice = new System.Windows.Forms.TextBox();
            this.txt_saleprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.grid_products = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_pur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_sel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_prodname
            // 
            this.txt_prodname.Location = new System.Drawing.Point(18, 30);
            this.txt_prodname.Name = "txt_prodname";
            this.txt_prodname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prodname.Size = new System.Drawing.Size(366, 20);
            this.txt_prodname.TabIndex = 0;
            // 
            // txt_purprice
            // 
            this.txt_purprice.Location = new System.Drawing.Point(296, 56);
            this.txt_purprice.Name = "txt_purprice";
            this.txt_purprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_purprice.Size = new System.Drawing.Size(88, 20);
            this.txt_purprice.TabIndex = 1;
            this.txt_purprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_purprice_KeyPress);
            // 
            // txt_saleprice
            // 
            this.txt_saleprice.Location = new System.Drawing.Point(296, 82);
            this.txt_saleprice.Name = "txt_saleprice";
            this.txt_saleprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_saleprice.Size = new System.Drawing.Size(88, 20);
            this.txt_saleprice.TabIndex = 2;
            this.txt_saleprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_saleprice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "سعر الشراء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "سعر البيع";
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(269, 108);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(208, 108);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(55, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(147, 108);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(55, 23);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "حذف";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // grid_products
            // 
            this.grid_products.AllowUserToAddRows = false;
            this.grid_products.AllowUserToDeleteRows = false;
            this.grid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_id,
            this.prod_name,
            this.prod_pur,
            this.prod_sel});
            this.grid_products.Location = new System.Drawing.Point(18, 137);
            this.grid_products.Name = "grid_products";
            this.grid_products.ReadOnly = true;
            this.grid_products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grid_products.Size = new System.Drawing.Size(452, 183);
            this.grid_products.TabIndex = 9;
            this.grid_products.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_products_RowHeaderMouseClick);
            // 
            // prod_id
            // 
            this.prod_id.HeaderText = "";
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            this.prod_id.Visible = false;
            // 
            // prod_name
            // 
            this.prod_name.HeaderText = "الصنف";
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            this.prod_name.Width = 212;
            // 
            // prod_pur
            // 
            this.prod_pur.HeaderText = "شراء";
            this.prod_pur.Name = "prod_pur";
            this.prod_pur.ReadOnly = true;
            this.prod_pur.Width = 98;
            // 
            // prod_sel
            // 
            this.prod_sel.HeaderText = "بيع";
            this.prod_sel.Name = "prod_sel";
            this.prod_sel.ReadOnly = true;
            this.prod_sel.Width = 98;
            // 
            // btn_new
            // 
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(330, 108);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(55, 23);
            this.btn_new.TabIndex = 11;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_products);
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Controls.Add(this.txt_prodname);
            this.groupBox1.Controls.Add(this.txt_purprice);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.txt_saleprice);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(488, 341);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 372);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاصناف";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_prodname;
        private System.Windows.Forms.TextBox txt_purprice;
        private System.Windows.Forms.TextBox txt_saleprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView grid_products;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_pur;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_sel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}