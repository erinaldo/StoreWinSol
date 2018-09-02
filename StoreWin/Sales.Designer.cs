namespace StoreWin
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_remain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_recieve = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.grid_invprods = new System.Windows.Forms.DataGridView();
            this.prodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpricetotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_prod = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_invno = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.combo_invno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invprods)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Location = new System.Drawing.Point(456, 546);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(97, 23);
            this.btn_print.TabIndex = 40;
            this.btn_print.Text = "طباعة فاتورة";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_new
            // 
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(525, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(89, 23);
            this.btn_new.TabIndex = 39;
            this.btn_new.Text = "فاتورة جديدة";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(559, 546);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 23);
            this.btn_save.TabIndex = 37;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_remain
            // 
            this.txt_remain.Enabled = false;
            this.txt_remain.Location = new System.Drawing.Point(11, 502);
            this.txt_remain.Name = "txt_remain";
            this.txt_remain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_remain.Size = new System.Drawing.Size(88, 20);
            this.txt_remain.TabIndex = 35;
            this.txt_remain.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "المتبقي";
            // 
            // txt_recieve
            // 
            this.txt_recieve.Location = new System.Drawing.Point(245, 502);
            this.txt_recieve.Name = "txt_recieve";
            this.txt_recieve.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_recieve.Size = new System.Drawing.Size(88, 20);
            this.txt_recieve.TabIndex = 33;
            this.txt_recieve.Text = "0";
            this.txt_recieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_recieve_KeyPress);
            this.txt_recieve.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_recieve_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "المدفوع";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(472, 502);
            this.txt_total.Name = "txt_total";
            this.txt_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_total.Size = new System.Drawing.Size(88, 20);
            this.txt_total.TabIndex = 31;
            this.txt_total.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "الاجمالي";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_qty);
            this.groupBox1.Controls.Add(this.grid_invprods);
            this.groupBox1.Controls.Add(this.txt_prod);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(603, 420);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الاصناف";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(461, 62);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(59, 20);
            this.txt_qty.TabIndex = 17;
            // 
            // grid_invprods
            // 
            this.grid_invprods.AllowUserToAddRows = false;
            this.grid_invprods.AllowUserToDeleteRows = false;
            this.grid_invprods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_invprods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodid,
            this.prodname,
            this.prodprice,
            this.prodqty,
            this.prodpricetotal});
            this.grid_invprods.Location = new System.Drawing.Point(16, 142);
            this.grid_invprods.Name = "grid_invprods";
            this.grid_invprods.ReadOnly = true;
            this.grid_invprods.Size = new System.Drawing.Size(569, 256);
            this.grid_invprods.TabIndex = 16;
            // 
            // prodid
            // 
            this.prodid.HeaderText = "";
            this.prodid.Name = "prodid";
            this.prodid.ReadOnly = true;
            this.prodid.Visible = false;
            // 
            // prodname
            // 
            this.prodname.HeaderText = "الصنف";
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            this.prodname.Width = 240;
            // 
            // prodprice
            // 
            this.prodprice.HeaderText = "السعر";
            this.prodprice.Name = "prodprice";
            this.prodprice.ReadOnly = true;
            // 
            // prodqty
            // 
            this.prodqty.HeaderText = "الكمية";
            this.prodqty.Name = "prodqty";
            this.prodqty.ReadOnly = true;
            this.prodqty.Width = 85;
            // 
            // prodpricetotal
            // 
            this.prodpricetotal.HeaderText = "الاجمالي";
            this.prodpricetotal.Name = "prodpricetotal";
            this.prodpricetotal.ReadOnly = true;
            // 
            // txt_prod
            // 
            this.txt_prod.FormattingEnabled = true;
            this.txt_prod.Location = new System.Drawing.Point(191, 35);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(329, 21);
            this.txt_prod.TabIndex = 15;
            this.txt_prod.SelectedIndexChanged += new System.EventHandler(this.txt_prod_SelectedIndexChanged);
            // 
            // txt_price
            // 
            this.txt_price.Enabled = false;
            this.txt_price.Location = new System.Drawing.Point(432, 87);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(88, 20);
            this.txt_price.TabIndex = 9;
            this.txt_price.Text = "0";
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(465, 113);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "اضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "الصنف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "سعر البيع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "رقم الفاتورة";
            // 
            // txt_invno
            // 
            this.txt_invno.Enabled = false;
            this.txt_invno.Location = new System.Drawing.Point(366, 14);
            this.txt_invno.Name = "txt_invno";
            this.txt_invno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_invno.Size = new System.Drawing.Size(88, 20);
            this.txt_invno.TabIndex = 29;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(12, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(48, 23);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // combo_invno
            // 
            this.combo_invno.FormattingEnabled = true;
            this.combo_invno.Location = new System.Drawing.Point(66, 14);
            this.combo_invno.Name = "combo_invno";
            this.combo_invno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_invno.Size = new System.Drawing.Size(88, 21);
            this.combo_invno.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "بحث عن فاتورة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "تاريخ الفاتورة";
            // 
            // lbl_date
            // 
            this.lbl_date.Enabled = false;
            this.lbl_date.Location = new System.Drawing.Point(311, 40);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_date.Size = new System.Drawing.Size(143, 20);
            this.lbl_date.TabIndex = 41;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 588);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.combo_invno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_remain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_recieve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_invno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invprods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_remain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_recieve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_invno;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox combo_invno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txt_prod;
        private System.Windows.Forms.DataGridView grid_invprods;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpricetotal;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lbl_date;
    }
}