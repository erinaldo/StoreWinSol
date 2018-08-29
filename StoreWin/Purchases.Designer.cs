namespace StoreWin
{
    partial class Purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchases));
            this.grid_invprods = new System.Windows.Forms.DataGridView();
            this.prodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpricetotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_invno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.txt_prod = new System.Windows.Forms.ComboBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_recieve = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_remain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_invno = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invprods)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            this.SuspendLayout();
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
            this.grid_invprods.Location = new System.Drawing.Point(16, 145);
            this.grid_invprods.Name = "grid_invprods";
            this.grid_invprods.ReadOnly = true;
            this.grid_invprods.Size = new System.Drawing.Size(569, 256);
            this.grid_invprods.TabIndex = 0;
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
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(465, 113);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "اضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "سعر الشراء";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "الصنف";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(432, 87);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(88, 20);
            this.txt_price.TabIndex = 9;
            this.txt_price.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "رقم الفاتورة";
            // 
            // txt_invno
            // 
            this.txt_invno.Enabled = false;
            this.txt_invno.Location = new System.Drawing.Point(367, 14);
            this.txt_invno.Name = "txt_invno";
            this.txt_invno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_invno.Size = new System.Drawing.Size(88, 20);
            this.txt_invno.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_qty);
            this.groupBox1.Controls.Add(this.txt_prod);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.grid_invprods);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(603, 420);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الاصناف";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(461, 62);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(59, 20);
            this.txt_qty.TabIndex = 18;
            // 
            // txt_prod
            // 
            this.txt_prod.FormattingEnabled = true;
            this.txt_prod.Location = new System.Drawing.Point(191, 35);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(329, 21);
            this.txt_prod.TabIndex = 14;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(473, 477);
            this.txt_total.Name = "txt_total";
            this.txt_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_total.Size = new System.Drawing.Size(88, 20);
            this.txt_total.TabIndex = 17;
            this.txt_total.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "الاجمالي";
            // 
            // txt_recieve
            // 
            this.txt_recieve.Location = new System.Drawing.Point(246, 477);
            this.txt_recieve.Name = "txt_recieve";
            this.txt_recieve.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_recieve.Size = new System.Drawing.Size(88, 20);
            this.txt_recieve.TabIndex = 19;
            this.txt_recieve.Text = "0";
            this.txt_recieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_recieve_KeyPress);
            this.txt_recieve.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_recieve_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "المدفوع";
            // 
            // txt_remain
            // 
            this.txt_remain.Enabled = false;
            this.txt_remain.Location = new System.Drawing.Point(12, 477);
            this.txt_remain.Name = "txt_remain";
            this.txt_remain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_remain.Size = new System.Drawing.Size(88, 20);
            this.txt_remain.TabIndex = 21;
            this.txt_remain.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "المتبقي";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(526, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(89, 23);
            this.btn_new.TabIndex = 26;
            this.btn_new.Text = "فاتورة جديدة";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(560, 521);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 23);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "بحث عن فاتورة";
            // 
            // combo_invno
            // 
            this.combo_invno.FormattingEnabled = true;
            this.combo_invno.Location = new System.Drawing.Point(66, 14);
            this.combo_invno.Name = "combo_invno";
            this.combo_invno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_invno.Size = new System.Drawing.Size(88, 21);
            this.combo_invno.TabIndex = 29;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(48, 23);
            this.btn_search.TabIndex = 30;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 556);
            this.Controls.Add(this.btn_search);
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
            this.Controls.Add(this.txt_invno);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Purchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المشتريات";
            this.Load += new System.EventHandler(this.Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_invprods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_invprods;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_invno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_recieve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_remain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox txt_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpricetotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_invno;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.NumericUpDown txt_qty;
    }
}