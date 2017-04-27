namespace InventoryManagersystem
{
    partial class frmUserMamager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserDel = new System.Windows.Forms.Button();
            this.btnUserMod = new System.Windows.Forms.Button();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lalPhone = new System.Windows.Forms.Label();
            this.btnReflash = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.telephone,
            this.address,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(811, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(24, 70);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUserAdd.TabIndex = 1;
            this.btnUserAdd.Text = "添加用户";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserDel
            // 
            this.btnUserDel.Location = new System.Drawing.Point(123, 70);
            this.btnUserDel.Name = "btnUserDel";
            this.btnUserDel.Size = new System.Drawing.Size(75, 23);
            this.btnUserDel.TabIndex = 1;
            this.btnUserDel.Text = "删除用户";
            this.btnUserDel.UseVisualStyleBackColor = true;
            this.btnUserDel.Click += new System.EventHandler(this.btnUserDel_Click);
            // 
            // btnUserMod
            // 
            this.btnUserMod.Location = new System.Drawing.Point(214, 70);
            this.btnUserMod.Name = "btnUserMod";
            this.btnUserMod.Size = new System.Drawing.Size(75, 23);
            this.btnUserMod.TabIndex = 1;
            this.btnUserMod.Text = "修改用户";
            this.btnUserMod.UseVisualStyleBackColor = true;
            this.btnUserMod.Click += new System.EventHandler(this.btnUserMod_Click);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(88, 25);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(128, 21);
            this.txtBoxUser.TabIndex = 2;
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(20, 28);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(41, 12);
            this.lblSearchUser.TabIndex = 3;
            this.lblSearchUser.Text = "用户名";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(458, 23);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "搜索";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(311, 25);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(128, 21);
            this.txtBoxPhone.TabIndex = 2;
            // 
            // lalPhone
            // 
            this.lalPhone.AutoSize = true;
            this.lalPhone.Location = new System.Drawing.Point(236, 28);
            this.lalPhone.Name = "lalPhone";
            this.lalPhone.Size = new System.Drawing.Size(41, 12);
            this.lalPhone.TabIndex = 3;
            this.lalPhone.Text = "手机号";
            // 
            // btnReflash
            // 
            this.btnReflash.Location = new System.Drawing.Point(311, 70);
            this.btnReflash.Name = "btnReflash";
            this.btnReflash.Size = new System.Drawing.Size(75, 23);
            this.btnReflash.TabIndex = 1;
            this.btnReflash.Text = "数据刷新";
            this.btnReflash.UseVisualStyleBackColor = true;
            this.btnReflash.Click += new System.EventHandler(this.btnReflash_Click);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "username";
            this.Username.HeaderText = "用户名";
            this.Username.Name = "Username";
            // 
            // telephone
            // 
            this.telephone.DataPropertyName = "telephone";
            this.telephone.HeaderText = "电话";
            this.telephone.Name = "telephone";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "邮件地址";
            this.email.Name = "email";
            // 
            // frmUserMamager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 543);
            this.Controls.Add(this.lalPhone);
            this.Controls.Add(this.lblSearchUser);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.btnReflash);
            this.Controls.Add(this.btnUserMod);
            this.Controls.Add(this.btnUserDel);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnUserAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUserMamager";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserDel;
        private System.Windows.Forms.Button btnUserMod;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lalPhone;
        private System.Windows.Forms.Button btnReflash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}