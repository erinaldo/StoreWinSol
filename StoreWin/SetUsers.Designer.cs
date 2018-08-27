namespace StoreWin
{
    partial class SetUsers
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
            this.grid_users = new System.Windows.Forms.DataGridView();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_users
            // 
            this.grid_users.AllowUserToAddRows = false;
            this.grid_users.AllowUserToDeleteRows = false;
            this.grid_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_users.Location = new System.Drawing.Point(12, 95);
            this.grid_users.Name = "grid_users";
            this.grid_users.ReadOnly = true;
            this.grid_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grid_users.Size = new System.Drawing.Size(238, 207);
            this.grid_users.TabIndex = 19;
            this.grid_users.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_users_RowHeaderMouseClick);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(12, 66);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(55, 23);
            this.btn_del.TabIndex = 18;
            this.btn_del.Text = "حذف";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(73, 66);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(55, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(134, 66);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "اسم المستخدم";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(12, 40);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(238, 20);
            this.txt_pass.TabIndex = 11;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(12, 14);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(238, 20);
            this.txt_user.TabIndex = 10;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(195, 66);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(55, 23);
            this.btn_new.TabIndex = 20;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // SetUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 315);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.grid_users);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SetUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات المستخدمين";
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_users;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_new;
    }
}