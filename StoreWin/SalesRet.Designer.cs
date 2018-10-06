namespace StoreWin
{
    partial class SalesRet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_invprods = new System.Windows.Forms.DataGridView();
            this.prodchk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpricetotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.combo_invno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invprods)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_qty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grid_invprods);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.combo_invno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(618, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(462, 290);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(59, 20);
            this.txt_qty.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "الكمية المرتجعة";
            // 
            // grid_invprods
            // 
            this.grid_invprods.AllowUserToAddRows = false;
            this.grid_invprods.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_invprods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_invprods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_invprods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodchk,
            this.prodid,
            this.prodname,
            this.prodprice,
            this.prodqty,
            this.prodpricetotal});
            this.grid_invprods.Location = new System.Drawing.Point(15, 49);
            this.grid_invprods.Name = "grid_invprods";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.grid_invprods.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_invprods.Size = new System.Drawing.Size(588, 232);
            this.grid_invprods.TabIndex = 37;
            // 
            // prodchk
            // 
            this.prodchk.HeaderText = "";
            this.prodchk.Name = "prodchk";
            this.prodchk.Width = 20;
            // 
            // prodid
            // 
            this.prodid.HeaderText = "";
            this.prodid.Name = "prodid";
            this.prodid.ReadOnly = true;
            this.prodid.Visible = false;
            this.prodid.Width = 80;
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
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(419, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(48, 23);
            this.btn_search.TabIndex = 36;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // combo_invno
            // 
            this.combo_invno.FormattingEnabled = true;
            this.combo_invno.Location = new System.Drawing.Point(473, 22);
            this.combo_invno.Name = "combo_invno";
            this.combo_invno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_invno.Size = new System.Drawing.Size(88, 21);
            this.combo_invno.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "الفاتورة";
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(478, 346);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 23);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(539, 345);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(76, 23);
            this.btn_new.TabIndex = 44;
            this.btn_new.Text = "مرتجع جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // SalesRet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 381);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesRet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرتجع بيع";
            this.Load += new System.EventHandler(this.SalesRet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invprods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox combo_invno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grid_invprods;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prodchk;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpricetotal;
    }
}