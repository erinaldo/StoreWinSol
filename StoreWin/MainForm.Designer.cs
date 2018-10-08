namespace StoreWin
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_purchases = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اعداداتالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعداداتالمستخدمينToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.تعليماتالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حولالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_cash = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_salesret = new System.Windows.Forms.Button();
            this.btn_purchasesret = new System.Windows.Forms.Button();
            this.p_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sales
            // 
            this.btn_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sales.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_sales.Location = new System.Drawing.Point(15, 214);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(153, 53);
            this.btn_sales.TabIndex = 0;
            this.btn_sales.Text = "بيع";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_purchases
            // 
            this.btn_purchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchases.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_purchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchases.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_purchases.Location = new System.Drawing.Point(15, 96);
            this.btn_purchases.Name = "btn_purchases";
            this.btn_purchases.Size = new System.Drawing.Size(153, 53);
            this.btn_purchases.TabIndex = 1;
            this.btn_purchases.Text = "شراء";
            this.btn_purchases.UseVisualStyleBackColor = true;
            this.btn_purchases.Click += new System.EventHandler(this.btn_purchases_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventory.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_inventory.Location = new System.Drawing.Point(15, 332);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(153, 53);
            this.btn_inventory.TabIndex = 4;
            this.btn_inventory.Text = "المخزون";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_products
            // 
            this.btn_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_products.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_products.Location = new System.Drawing.Point(15, 37);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(153, 53);
            this.btn_products.TabIndex = 5;
            this.btn_products.Text = "الاصناف";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reports.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_reports.Location = new System.Drawing.Point(15, 450);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(153, 53);
            this.btn_reports.TabIndex = 6;
            this.btn_reports.Text = "التقارير";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اعداداتالمستخدمينToolStripMenuItem,
            this.اعداداتالمستخدمينToolStripMenuItem1,
            this.تعليماتالبرنامجToolStripMenuItem,
            this.حولالبرنامجToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اعداداتالمستخدمينToolStripMenuItem
            // 
            this.اعداداتالمستخدمينToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.اعداداتالمستخدمينToolStripMenuItem.Image = global::StoreWin.Properties.Resources.tools;
            this.اعداداتالمستخدمينToolStripMenuItem.Name = "اعداداتالمستخدمينToolStripMenuItem";
            this.اعداداتالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.اعداداتالمستخدمينToolStripMenuItem.Text = "اعدادات البرنامج";
            this.اعداداتالمستخدمينToolStripMenuItem.Click += new System.EventHandler(this.اعداداتالمستخدمينToolStripMenuItem_Click);
            // 
            // اعداداتالمستخدمينToolStripMenuItem1
            // 
            this.اعداداتالمستخدمينToolStripMenuItem1.Image = global::StoreWin.Properties.Resources.users;
            this.اعداداتالمستخدمينToolStripMenuItem1.Name = "اعداداتالمستخدمينToolStripMenuItem1";
            this.اعداداتالمستخدمينToolStripMenuItem1.Size = new System.Drawing.Size(137, 20);
            this.اعداداتالمستخدمينToolStripMenuItem1.Text = "اعدادات المستخدمين";
            this.اعداداتالمستخدمينToolStripMenuItem1.Click += new System.EventHandler(this.اعداداتالمستخدمينToolStripMenuItem1_Click);
            // 
            // تعليماتالبرنامجToolStripMenuItem
            // 
            this.تعليماتالبرنامجToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.تعليماتالبرنامجToolStripMenuItem.Image = global::StoreWin.Properties.Resources.help;
            this.تعليماتالبرنامجToolStripMenuItem.Name = "تعليماتالبرنامجToolStripMenuItem";
            this.تعليماتالبرنامجToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.تعليماتالبرنامجToolStripMenuItem.Text = "تعليمات البرنامج";
            this.تعليماتالبرنامجToolStripMenuItem.Click += new System.EventHandler(this.تعليماتالبرنامجToolStripMenuItem_Click);
            // 
            // حولالبرنامجToolStripMenuItem
            // 
            this.حولالبرنامجToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.حولالبرنامجToolStripMenuItem.Image = global::StoreWin.Properties.Resources.pie_chart;
            this.حولالبرنامجToolStripMenuItem.Name = "حولالبرنامجToolStripMenuItem";
            this.حولالبرنامجToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.حولالبرنامجToolStripMenuItem.Text = "حول البرنامج";
            this.حولالبرنامجToolStripMenuItem.Click += new System.EventHandler(this.حولالبرنامجToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.خروجToolStripMenuItem.Image = global::StoreWin.Properties.Resources.if_sign_out_48726;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(735, 537);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنبيهات";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Location = new System.Drawing.Point(596, 37);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(124, 23);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "تحديث";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_name,
            this.p_date});
            this.dataGridView1.Location = new System.Drawing.Point(16, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(704, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_cash
            // 
            this.btn_cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cash.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cash.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_cash.Location = new System.Drawing.Point(15, 391);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(153, 53);
            this.btn_cash.TabIndex = 11;
            this.btn_cash.Text = "الخزينة";
            this.btn_cash.UseVisualStyleBackColor = true;
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_salesret);
            this.groupBox2.Controls.Add(this.btn_purchasesret);
            this.groupBox2.Controls.Add(this.btn_products);
            this.groupBox2.Controls.Add(this.btn_cash);
            this.groupBox2.Controls.Add(this.btn_purchases);
            this.groupBox2.Controls.Add(this.btn_sales);
            this.groupBox2.Controls.Add(this.btn_reports);
            this.groupBox2.Controls.Add(this.btn_inventory);
            this.groupBox2.Location = new System.Drawing.Point(764, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(184, 537);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "القائمة الرئيسية";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // btn_salesret
            // 
            this.btn_salesret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salesret.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_salesret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salesret.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_salesret.Location = new System.Drawing.Point(15, 273);
            this.btn_salesret.Name = "btn_salesret";
            this.btn_salesret.Size = new System.Drawing.Size(153, 53);
            this.btn_salesret.TabIndex = 13;
            this.btn_salesret.Text = "مرتجع بيع";
            this.btn_salesret.UseVisualStyleBackColor = true;
            this.btn_salesret.Click += new System.EventHandler(this.btn_salesret_Click);
            // 
            // btn_purchasesret
            // 
            this.btn_purchasesret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purchasesret.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_purchasesret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchasesret.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_purchasesret.Location = new System.Drawing.Point(15, 155);
            this.btn_purchasesret.Name = "btn_purchasesret";
            this.btn_purchasesret.Size = new System.Drawing.Size(153, 53);
            this.btn_purchasesret.TabIndex = 14;
            this.btn_purchasesret.Text = "مرتجع شراء";
            this.btn_purchasesret.UseVisualStyleBackColor = true;
            this.btn_purchasesret.Click += new System.EventHandler(this.btn_purchasesret_Click);
            // 
            // p_date
            // 
            this.p_date.HeaderText = "وقت العملية";
            this.p_date.Name = "p_date";
            this.p_date.ReadOnly = true;
            this.p_date.Width = 160;
            // 
            // p_name
            // 
            this.p_name.HeaderText = "العملية";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            this.p_name.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PieStore v1.1 برنامج إدارة المحلات";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_purchases;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cash;
        private System.Windows.Forms.ToolStripMenuItem اعداداتالمستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعليماتالبرنامجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حولالبرنامجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_salesret;
        private System.Windows.Forms.Button btn_purchasesret;
        private System.Windows.Forms.ToolStripMenuItem اعداداتالمستخدمينToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_date;
    }
}

