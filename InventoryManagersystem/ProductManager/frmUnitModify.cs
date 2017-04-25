using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;

namespace InventoryManagersystem.ProductManager
{
    public partial class frmUnitModify : Form
    {
        BUProductManagerResult myPMR = new BUProductManagerResult();
        string paramUnitName = string.Empty;
        string paramRemark = string.Empty;
        int paramUnitCode = 0;
     
        bool isSystem = false;
        public frmUnitModify()
        {
            InitializeComponent();
            isSystem = true;
        }
        public frmUnitModify(string paramUnitName,string paramRemark,int paramUnitCode)
        {
            InitializeComponent();
            this.paramUnitName = paramUnitName;
            this.paramRemark = paramRemark;
            this.paramUnitCode = paramUnitCode;
            isSystem = false;
        }

        public void setInfo()
        {
            this.txtBoxProductUnitName.Text = this.paramUnitName;
            this.txtBoxRemark.Text = this.paramRemark;
            this.txtBoxProductUnitCode.Text = this.paramUnitCode.ToString();
        }

        private void frmUnitModify_Load(object sender, EventArgs e)
        {
            if (isSystem)
            {
                this.paramUnitName = this.Tag.ToString();

            }
            setInfo();
        }

        private void btnAddProductUnit_Click(object sender, EventArgs e)
        {
            string paramUnitName = this.txtBoxProductUnitName.Text.Trim();
            string paramRemark = this.txtBoxRemark.Text.Trim();
            string paramUnitCode = this.txtBoxProductUnitCode.Text.Trim();

            bool isModifyUnitOK = myPMR.CheckModifyUnit(paramUnitName,paramRemark,paramUnitCode);
            if (isModifyUnitOK)
            {
                MessageBox.Show("修改成功");
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show("更新失败");
                this.DialogResult = DialogResult.OK;
            }


        }
    }
}
