﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InventoryManagersystem.ClassAssist;
using InventoryManagersystem.sys;
using BULayer;

namespace InventoryManagersystem
{
    public partial class Frmmain : Form
    {

        BUSysInfo myBUSysInfo = new BUSysInfo();
        BULogin myBULogin = new BULogin();
        string paramUserName = string.Empty;//当前用户
        int paramRole = 0;                  //当前用户的角色
        string paramRoleName = string.Empty; //当前用户的角色名称
        public Frmmain()
        {
            InitializeComponent();
        }

        public Frmmain(string paramUSerName)
        {
            InitializeComponent();
            this.paramUserName = paramUSerName;
            GetUserInfo();
        }
        private void Frmmain_Load(object sender, EventArgs e)
        {
            string paramFromName = string.Empty;
            string paramFromPath = string.Empty;
            
            Bind_TreeView(treeView1);
            treeView1.ExpandAll();//树节点展开

        }

        public void GetUserInfo()
        {
            DataTable myDt = new DataTable();
            myDt = myBULogin.GetUserData(paramUserName);
            paramRole = Convert.ToInt32( myDt.Rows[0]["RoleID"]);
        }

        #region public void SetTag(string paramFromName, string paramFromPath) 通过窗体名称以及窗体路径打开窗体
        /// <summary>
        /// 通过窗体名称以及窗体路径打开窗体
        /// </summary>
        /// <param name="paramFromName"></param>
        /// <param name="paramFromPath"></param>
        public void SetTag(string paramFromName, string paramFromPath)
        {
            try
            {
            bool have = false;
            foreach (TabPage a in MainTabControl.TabPages)
            {
                if (a.Tag != null)
                {
                    if (a.Tag.ToString() == paramFromName)  //检查是否存在
                    {
                        have = true;
                        this.MainTabControl.SelectedTab = a;
                    }
                }
            }
            if (!have)
            {
                TabPage myTabPage = new TabPage(paramFromName);
                myTabPage.Text = paramFromName;
                myTabPage.Tag = paramFromName;
                //myTabPage.ImageIndex = 2;
                this.MainTabControl.TabPages.Add(myTabPage);
                System.Reflection.Assembly tempAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                // 根据sysModule表的FormName 创建窗体
                Form frm = (Form)tempAssembly.CreateInstance(paramFromPath);
                frm.TopLevel = false;
                myTabPage.Controls.Add(frm);
                frm.ControlBox = false;
                //string paramRoleID, string paramModuleID, string paramModuleName
                // frm.Tag = j

                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                this.MainTabControl.SelectedTab = myTabPage;

              }
            }
            catch 
            {          
            }
        }
        #endregion

        #region   TreeView的数据绑定父\子、孙节点函数
        /// <summary>
        /// TreeView的数据绑定父节点函数
        /// </summary>
        /// <param name="treeview">TreeView控件ID名称</param>
        /// <param name="text">树控件要显示的文本的字段名称</param>
        public void Bind_TreeView(TreeView treeview)
        {
            DataTable mtDt = new DataTable();

            // mtDt = myBUSysInfo.GetSysInfo();  //测试注销
            mtDt = myBULogin.GetModuleList(paramRole);
            treeview.Nodes.Clear();
            for (int i = 0; i < mtDt.Rows.Count; i++)
            {
                TreeNode rootnode = new TreeNode();//创建根节点
                //rootnode.Text = mtDt.Rows[i]["SysName"].ToString(); //测试注销
                //string paramSysID = mtDt.Rows[i]["SysNameID"].ToString();
                rootnode.Text = mtDt.Rows[i]["ModuleName"].ToString();
                string paramSysID = mtDt.Rows[i]["ID"].ToString();
                treeview.Nodes.Add(rootnode);//在添加完节点的内容之后，当然要添加根节点，
                CreateChildNodes(rootnode, paramSysID, rootnode.Text);//
            }
        }
        /// <summary>
        /// TreeView的数据绑定子节点函数
        /// </summary>
        /// <param name="treenode">上一级节点</param>
        /// <param name="parentName">数据表中字段名</param>
        /// <param name="text">树控件要显示的文本的字段名称</param>
        /// <param name="index">查询语句关键字</param>
        public void CreateChildNodes(TreeNode treenode, string parentSysID, string text)
        {


            //DataTable myCNode = myBUSysInfo.GetSysModuleInfo(parentSysID);
            DataTable myCNode = myBULogin.GetChildModuleList(paramRole, parentSysID);
            
            for (int i = 0; i < myCNode.Rows.Count; i++)
            {
                TreeNode childnode = new TreeNode();
                childnode.Text = myCNode.Rows[i]["ModuleName"].ToString();
                childnode.Tag = myCNode.Rows[i]["FormName"].ToString();
           
                treenode.Nodes.Add(childnode);
                //  string paramSysModelID = myCNode.Rows[i]["SysModelID"].ToString();
               // CreateGrandsonNodes(childnode, paramSysModelID, childnode.Text);
            }
        }
        /// <summary>
        /// TreeView的数据绑定三级节点函数
        /// </summary>
        /// <param name="treenode">上一级节点</param>
        /// <param name="parentName">数据表中字段名</param>
        /// <param name="text">树控件要显示的文本的字段名称</param>
        /// <param name="index">查询语句关键字</param>
        public void CreateGrandsonNodes(TreeNode treenode, string paramSysModelID, string text)
        {
            DataTable myDt = myBUSysInfo.Get_SysChildNode(paramSysModelID);
            for (int i = 0; i < myDt.Rows.Count; i++)
            {
                TreeNode childnode = new TreeNode();
                childnode.Text = myDt.Rows[i]["SysChildNodeName"].ToString();
                childnode.Tag = myDt.Rows[i]["SysChildNodePath"].ToString();
                treenode.Nodes.Add(childnode);
            }
        }
        #endregion

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {

            string paramFromName = string.Empty;
            string paramFromPath = string.Empty;
            paramFromName = treeView1.SelectedNode.Text;
            paramFromPath = treeView1.SelectedNode.Tag.ToString();
            if (paramFromPath.Length > 0)
            {
                if (paramFromName == "权限设置")
                {
                    frmPermissionManage myfrmPermissionManage = new frmPermissionManage();
                    myfrmPermissionManage.ShowDialog();
                    return;
                }
                SetTag(paramFromName, paramFromPath);
            }
            
        }

     

        private void MainTabControl_DoubleClick(object sender, EventArgs e)
        {
            if (this.MainTabControl.SelectedTab.Tag != null)
            {
                int tapindex = this.MainTabControl.SelectedIndex;
                this.MainTabControl.TabPages.Remove(this.MainTabControl.SelectedTab);
                if (this.MainTabControl.TabCount - 1 > tapindex)
                {
                    this.MainTabControl.SelectedIndex = tapindex;
                }
                else
                {
                    this.MainTabControl.SelectedIndex = this.MainTabControl.TabCount - 1;
                }
            }
        }

        private void tsMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Show();
                this.Activate();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void tsHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsHome_Click(object sender, EventArgs e)
        {
            if (this.tsPanal.Width == 185)
                this.tsPanal.Width = 0;
            else
                this.tsPanal.Width = 185;
        }

        private void tsChangeUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmLogin myfrmLogin = new FrmLogin();
            myfrmLogin.ShowDialog();
        }

    }
}
