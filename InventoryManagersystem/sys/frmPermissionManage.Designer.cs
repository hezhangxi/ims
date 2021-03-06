﻿namespace InventoryManagersystem.sys
{
    partial class frmPermissionManage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReflash = new System.Windows.Forms.Button();
            this.btnSetRole = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trView = new System.Windows.Forms.TreeView();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRoleUpdate = new System.Windows.Forms.Button();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.btnRoleSure = new System.Windows.Forms.Button();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReflash);
            this.tabPage1.Controls.Add(this.btnSetRole);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.trView);
            this.tabPage1.Controls.Add(this.cmbRole);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "权限设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReflash
            // 
            this.btnReflash.Location = new System.Drawing.Point(495, 457);
            this.btnReflash.Name = "btnReflash";
            this.btnReflash.Size = new System.Drawing.Size(92, 36);
            this.btnReflash.TabIndex = 6;
            this.btnReflash.Text = "刷新";
            this.btnReflash.UseVisualStyleBackColor = true;
            this.btnReflash.Click += new System.EventHandler(this.btnReflash_Click);
            // 
            // btnSetRole
            // 
            this.btnSetRole.Location = new System.Drawing.Point(393, 19);
            this.btnSetRole.Name = "btnSetRole";
            this.btnSetRole.Size = new System.Drawing.Size(111, 23);
            this.btnSetRole.TabIndex = 5;
            this.btnSetRole.Text = "加载所有权限";
            this.btnSetRole.UseVisualStyleBackColor = true;
            this.btnSetRole.Click += new System.EventHandler(this.btnSetRole_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "权限保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trView
            // 
            this.trView.CheckBoxes = true;
            this.trView.Location = new System.Drawing.Point(76, 59);
            this.trView.Name = "trView";
            this.trView.Size = new System.Drawing.Size(294, 434);
            this.trView.TabIndex = 3;
            this.trView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trView_AfterCheck);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(151, 22);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(219, 20);
            this.cmbRole.TabIndex = 2;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "请选择权限:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(698, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "角色管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMain);
            this.groupBox2.Location = new System.Drawing.Point(17, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 427);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据显示";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleID,
            this.RoleName,
            this.Remark});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 17);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(649, 407);
            this.dgvMain.TabIndex = 0;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "角色值";
            this.RoleID.Name = "RoleID";
            this.RoleID.Width = 75;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "角色名称";
            this.RoleName.Name = "RoleName";
            this.RoleName.Width = 200;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.Width = 350;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnRoleUpdate);
            this.groupBox1.Controls.Add(this.btnRoleAdd);
            this.groupBox1.Controls.Add(this.btnRoleSure);
            this.groupBox1.Controls.Add(this.txtRoleID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询操作区";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(556, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRoleUpdate
            // 
            this.btnRoleUpdate.Location = new System.Drawing.Point(455, 24);
            this.btnRoleUpdate.Name = "btnRoleUpdate";
            this.btnRoleUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnRoleUpdate.TabIndex = 4;
            this.btnRoleUpdate.Text = "修改";
            this.btnRoleUpdate.UseVisualStyleBackColor = true;
            this.btnRoleUpdate.Click += new System.EventHandler(this.btnRoleUpdate_Click);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.Location = new System.Drawing.Point(357, 24);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(75, 23);
            this.btnRoleAdd.TabIndex = 3;
            this.btnRoleAdd.Text = "添加";
            this.btnRoleAdd.UseVisualStyleBackColor = true;
            this.btnRoleAdd.Click += new System.EventHandler(this.btnRoleAdd_Click);
            // 
            // btnRoleSure
            // 
            this.btnRoleSure.Location = new System.Drawing.Point(256, 24);
            this.btnRoleSure.Name = "btnRoleSure";
            this.btnRoleSure.Size = new System.Drawing.Size(75, 23);
            this.btnRoleSure.TabIndex = 2;
            this.btnRoleSure.Text = "确定";
            this.btnRoleSure.UseVisualStyleBackColor = true;
            this.btnRoleSure.Click += new System.EventHandler(this.btnRoleSure_Click);
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(90, 27);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(109, 21);
            this.txtRoleID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色名称:";
            // 
            // frmPermissionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPermissionManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "权限管理";
            this.Load += new System.EventHandler(this.frmPermissionManage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRoleUpdate;
        private System.Windows.Forms.Button btnRoleAdd;
        private System.Windows.Forms.Button btnRoleSure;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView trView;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetRole;
        private System.Windows.Forms.Button btnReflash;
    }
}