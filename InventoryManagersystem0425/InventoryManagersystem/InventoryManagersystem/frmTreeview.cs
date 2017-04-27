using System;
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
    public partial class frmTreeview : Form
    {
        public frmTreeview()
        {
            InitializeComponent();
        }
        BUSysInfo myBUSysInfo = new BUSysInfo();
        private void frmTreeview_Load(object sender, EventArgs e)
        {
            Bind_TreeView(treeView1, "Dname");
        }
        /// <summary>
        /// TreeView的数据绑定父节点函数
        /// </summary>
        /// <param name="treeview">TreeView控件ID名称</param>
        /// <param name="text">树控件要显示的文本的字段名称</param>
        public void Bind_TreeView(TreeView treeview, string text)
        {
            DataTable mtDt = new DataTable();
          
            mtDt = myBUSysInfo.GetSysInfo();
            treeview.Nodes.Clear();
            for (int i = 0; i < mtDt.Rows.Count; i++)
            {
                TreeNode rootnode = new TreeNode();//创建根节点
                rootnode.Text = mtDt.Rows[i]["SysName"].ToString();
                string paramSysID = mtDt.Rows[i]["SysNameID"].ToString();
                treeview.Nodes.Add(rootnode);//在添加完节点的内容之后，当然要添加根节点，
                CreateChildNodes(rootnode, text, paramSysID, rootnode.Text);//
            }
        }
        /// <summary>
        /// TreeView的数据绑定子节点函数
        /// </summary>
        /// <param name="treenode">上一级节点</param>
        /// <param name="parentName">数据表中字段名</param>
        /// <param name="text">树控件要显示的文本的字段名称</param>
        /// <param name="index">查询语句关键字</param>
        public void CreateChildNodes(TreeNode treenode, string parentSysID, string text, string index) 
        {
          
         
            DataTable myCNode = myBUSysInfo.GetSysModuleInfo(parentSysID);
            for (int i = 0; i < myCNode.Rows.Count; i++)
            {
                TreeNode childnode = new TreeNode();
                childnode.Text = myCNode.Rows[i]["SysModeName"].ToString();
                string paramSysModelID = myCNode.Rows[i]["SysModelID"].ToString();
                treenode.Nodes.Add(childnode);
                CreateGrandsonNodes(childnode, text, paramSysModelID, childnode.Text);
            }
        }
        /// <summary>
        /// TreeView的数据绑定三级节点函数
        /// </summary>
        /// <param name="treenode">上一级节点</param>
        /// <param name="parentName">数据表中字段名</param>
        /// <param name="text">树控件要显示的文本的字段名称</param>
        /// <param name="index">查询语句关键字</param>
        public void CreateGrandsonNodes(TreeNode treenode, string paramSysModelID, string text, string index) 
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
