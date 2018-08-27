namespace StoreWin
{
    partial class Reports
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pur_show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pur_to = new System.Windows.Forms.DateTimePicker();
            this.pur_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sal_show = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sal_to = new System.Windows.Forms.DateTimePicker();
            this.sal_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cash_show = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cash_to = new System.Windows.Forms.DateTimePicker();
            this.cash_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inv_show = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inv_to = new System.Windows.Forms.DateTimePicker();
            this.inv_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pur_show);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pur_to);
            this.groupBox1.Controls.Add(this.pur_from);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(389, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المشتريات";
            // 
            // pur_show
            // 
            this.pur_show.Location = new System.Drawing.Point(29, 28);
            this.pur_show.Name = "pur_show";
            this.pur_show.Size = new System.Drawing.Size(54, 23);
            this.pur_show.TabIndex = 4;
            this.pur_show.Text = "عرض";
            this.pur_show.UseVisualStyleBackColor = true;
            this.pur_show.Click += new System.EventHandler(this.pur_show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "من";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "إلي";
            // 
            // pur_to
            // 
            this.pur_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pur_to.Location = new System.Drawing.Point(96, 30);
            this.pur_to.Name = "pur_to";
            this.pur_to.RightToLeftLayout = true;
            this.pur_to.Size = new System.Drawing.Size(98, 20);
            this.pur_to.TabIndex = 1;
            // 
            // pur_from
            // 
            this.pur_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pur_from.Location = new System.Drawing.Point(242, 30);
            this.pur_from.Name = "pur_from";
            this.pur_from.RightToLeftLayout = true;
            this.pur_from.Size = new System.Drawing.Size(98, 20);
            this.pur_from.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sal_show);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sal_to);
            this.groupBox2.Controls.Add(this.sal_from);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(389, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المبيعات";
            // 
            // sal_show
            // 
            this.sal_show.Location = new System.Drawing.Point(29, 28);
            this.sal_show.Name = "sal_show";
            this.sal_show.Size = new System.Drawing.Size(54, 23);
            this.sal_show.TabIndex = 4;
            this.sal_show.Text = "عرض";
            this.sal_show.UseVisualStyleBackColor = true;
            this.sal_show.Click += new System.EventHandler(this.sal_show_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "من";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "إلي";
            // 
            // sal_to
            // 
            this.sal_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sal_to.Location = new System.Drawing.Point(96, 30);
            this.sal_to.Name = "sal_to";
            this.sal_to.RightToLeftLayout = true;
            this.sal_to.Size = new System.Drawing.Size(98, 20);
            this.sal_to.TabIndex = 1;
            // 
            // sal_from
            // 
            this.sal_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sal_from.Location = new System.Drawing.Point(242, 30);
            this.sal_from.Name = "sal_from";
            this.sal_from.RightToLeftLayout = true;
            this.sal_from.Size = new System.Drawing.Size(98, 20);
            this.sal_from.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cash_show);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cash_to);
            this.groupBox3.Controls.Add(this.cash_from);
            this.groupBox3.Location = new System.Drawing.Point(12, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(389, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "حركات الخزينة";
            // 
            // cash_show
            // 
            this.cash_show.Location = new System.Drawing.Point(29, 28);
            this.cash_show.Name = "cash_show";
            this.cash_show.Size = new System.Drawing.Size(54, 23);
            this.cash_show.TabIndex = 4;
            this.cash_show.Text = "عرض";
            this.cash_show.UseVisualStyleBackColor = true;
            this.cash_show.Click += new System.EventHandler(this.retpur_show_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "من";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "إلي";
            // 
            // cash_to
            // 
            this.cash_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cash_to.Location = new System.Drawing.Point(96, 30);
            this.cash_to.Name = "cash_to";
            this.cash_to.RightToLeftLayout = true;
            this.cash_to.Size = new System.Drawing.Size(98, 20);
            this.cash_to.TabIndex = 1;
            // 
            // cash_from
            // 
            this.cash_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cash_from.Location = new System.Drawing.Point(242, 30);
            this.cash_from.Name = "cash_from";
            this.cash_from.RightToLeftLayout = true;
            this.cash_from.Size = new System.Drawing.Size(98, 20);
            this.cash_from.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inv_show);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.inv_to);
            this.groupBox4.Controls.Add(this.inv_from);
            this.groupBox4.Location = new System.Drawing.Point(12, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(389, 75);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "حركات المخزن";
            // 
            // inv_show
            // 
            this.inv_show.Location = new System.Drawing.Point(29, 28);
            this.inv_show.Name = "inv_show";
            this.inv_show.Size = new System.Drawing.Size(54, 23);
            this.inv_show.TabIndex = 4;
            this.inv_show.Text = "عرض";
            this.inv_show.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "من";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "إلي";
            // 
            // inv_to
            // 
            this.inv_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inv_to.Location = new System.Drawing.Point(96, 30);
            this.inv_to.Name = "inv_to";
            this.inv_to.RightToLeftLayout = true;
            this.inv_to.Size = new System.Drawing.Size(98, 20);
            this.inv_to.TabIndex = 1;
            // 
            // inv_from
            // 
            this.inv_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inv_from.Location = new System.Drawing.Point(242, 30);
            this.inv_from.Name = "inv_from";
            this.inv_from.RightToLeftLayout = true;
            this.inv_from.Size = new System.Drawing.Size(98, 20);
            this.inv_from.TabIndex = 0;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 341);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pur_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pur_to;
        private System.Windows.Forms.DateTimePicker pur_from;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sal_show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker sal_to;
        private System.Windows.Forms.DateTimePicker sal_from;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cash_show;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker cash_to;
        private System.Windows.Forms.DateTimePicker cash_from;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button inv_show;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker inv_to;
        private System.Windows.Forms.DateTimePicker inv_from;
    }
}