﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;

namespace InventoryManagersystem
{
    public partial class frmModifyUser : Form
    {

        public string paramUserName = string.Empty;
        public string paramAddress = string.Empty;
        public string paramTelephone = string.Empty;
        public string paramEmail = string.Empty;
        public string paramRoleName = string.Empty;
        BUUserManager MyUserManager = new BUUserManager();
        bool IsSystem = false;
        public frmModifyUser()
        {
            InitializeComponent();
            IsSystem = true;
         
        }
        public frmModifyUser(string paramUserName,string paramAddress,string paramTelephone,string paramEmail,string paramRoleName)
        {
            InitializeComponent();
            this.paramUserName = paramUserName;
            this.paramAddress = paramAddress;
            this.paramTelephone = paramTelephone;
            this.paramEmail = paramEmail;
            this.paramRoleName = paramRoleName;
            IsSystem = false;
        }


        /// <summary>
        ///将传递过来的参数赋值给文本框
        /// </summary>
        public void SetInfo()
        {
            this.txtBoxUser.Text = this.paramUserName;
            this.txtBoxAddress.Text = this.paramAddress;
            this.txtBoxPhone.Text = this.paramTelephone;
            this.txtBoxEmail.Text = this.paramEmail;
            this.comboBoxRoles.Text = this.paramRoleName;

        }

        private void frmModifyUser_Load(object sender, EventArgs e)
        {
            if(IsSystem)
            {
             this.paramUserName = this.Tag.ToString();
            }

            SetRolesComb();
            SetInfo();
          
        }
        public void SetRolesComb()
        {
            BUUserManager MyUserManager = new BUUserManager();
            DataTable rolesList = MyUserManager.GetRolesList();
            comboBoxRoles.DataSource = rolesList;
            comboBoxRoles.DisplayMember = "RoleName";
            comboBoxRoles.ValueMember = "RoleID";

            
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {


                string userName = this.txtBoxUser.Text.Trim();
                string passWord = this.txtBoxPwd.Text.Trim();
                string telePhone = this.txtBoxPhone.Text.Trim();
                string email = this.txtBoxEmail.Text.Trim();
                string address = this.txtBoxAddress.Text.Trim();
                string RoleName = this.comboBoxRoles.Text.Trim();
                int RoleID = MyUserManager.GetRoleID(RoleName);
                
                BUCheckResult myBUCheckResult = new BUCheckResult();
                int checkValue = myBUCheckResult.CheckUserModify(userName, telePhone, email, address, RoleID,passWord);
                if (checkValue > 0)
                {
                    MessageBox.Show("用户修改成功");
                    this.DialogResult = DialogResult.OK;
                    //this.Hide();

                }

            }
            catch
            {
                MessageBox.Show("操作错误");
                this.DialogResult = DialogResult.No;
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
