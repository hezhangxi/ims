using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagersystem
{
    public partial class Frmmain : Form
    {
        public string paramUserName = string.Empty;
        public Frmmain()
        {
            InitializeComponent();
        }
        public Frmmain(string paramUserName)
        {
            InitializeComponent();
            this.paramUserName = paramUserName;
        }

        #region public void SetTag(string paramFromName, string paramFromPath) 通过窗体名称以及窗体路径打开窗体
        /// <summary>
        /// 通过窗体名称以及窗体路径打开窗体
        /// </summary>
        /// <param name="paramFromName"></param>
        /// <param name="paramFromPath"></param>
        public void SetTag(string paramFromName, string paramFromPath)
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
                frm.Tag = this.paramUserName;//存储用户信息

                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                this.MainTabControl.SelectedTab = myTabPage;

            }
        }
        #endregion


        #region public void SetStatusStrip() 状态栏信息加载
        /// <summary>
        /// 状态栏红信息加载
        /// </summary>
        public void SetStatusStrip()
        {
            tSlUsername.Text = paramUserName;//状态栏
        }
        #endregion

      

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {

            string paramFromName = string.Empty;
            string paramFromPath = string.Empty;
            paramFromName = treeView1.SelectedNode.Text;

            switch (paramFromName)
            {
                case "人员管理":

                    paramFromPath = "InventoryManagersystem.frmUserMamager";
                    SetTag(paramFromName, paramFromPath);
                    break;

                case "更改密码":

                    paramFromPath = "InventoryManagersystem.frmChangeMyPassword";
                    SetTag(paramFromName, paramFromPath);
                    break;

                case "商品维护":
                    paramFromPath = "InventoryManagersystem.ProductManager.frmProductList";
                    SetTag(paramFromName, paramFromPath);
                    break;

                case "商品分类":
                    paramFromPath = "InventoryManagersystem.ProductManager.frmProductClassManager";
                    SetTag(paramFromName, paramFromPath);
                    break;

                case "商品单位":
                    paramFromPath = "InventoryManagersystem.ProductManager.frmProductUnit";
                    SetTag(paramFromName, paramFromPath);
                    break;

                case "修改我的资料":

                    paramFromPath = "InventoryManagersystem.frmModifyUser";
                    SetTag(paramFromName, paramFromPath);
                    break;

       

                default:
                    break;
            }
            
            //if (treeView1.SelectedNode.Text == "人员管理")
            //{
            //    QueryGrid myQueryGrid = new QueryGrid();
            //    myQueryGrid.ShowDialog();
            //}

        }
  
        private void Frmmain_Load(object sender, EventArgs e)
        {
            string paramFromName = string.Empty;
            string paramFromPath = string.Empty;
            // begin 
            #region 首页默认页
           // paramFromPath = "InventoryManagersystem.QueryGrid";
           // SetTag("首页2", paramFromPath);
            #endregion
           //end

            treeView1.ExpandAll();//树节点展开
            SetStatusStrip();

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

        private void Frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsMMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void TsMMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TsmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tlmHome_Click(object sender, EventArgs e)
        {
            if (this.tsPanal.Width == 185)
                this.tsPanal.Width = 0;
            else
                this.tsPanal.Width = 185;
        }

        private void tsmChangeUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmLogin myfrmLogin = new FrmLogin();
            myfrmLogin.ShowDialog();
        }

    }
}
