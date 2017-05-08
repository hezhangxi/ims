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
    
    public partial class frmProductAdd : Form
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }

        BUCheckResult myBUCheckResult = new BUCheckResult();
        public void SetProductComb()
        {
            DataTable myPudtClass = new DataTable();
            myPudtClass = myBUCheckResult.GetProductList();
            comBoxProductClass.DataSource = myPudtClass;
            comBoxProductClass.ValueMember = "ProductClassID";
            comBoxProductClass.DisplayMember = "ProductClassName";
          
        }

        public void SetUnitComb()
        {
            DataTable myUnitDt = new DataTable();
            myUnitDt = myBUCheckResult.GetProductUnit();
            comBoxUnit.DataSource = myUnitDt;
            comBoxUnit.DisplayMember = "ProductUnitName";
            comBoxUnit.ValueMember = "ProductUnitID";
        }
        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            SetProductComb();
            SetUnitComb();
            this.txtBoxEmployee.Text = this.Tag.ToString();
       }

        /// <summary>
        /// 输入判断 
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            bool ReturnValue=false ;
            if (this.txtBOXproducPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("价格不能为空！");
                txtBOXproducPrice.Focus();
                txtBOXproducPrice.SelectAll();
                ReturnValue = true;
                return ReturnValue;
            }
            if (txtBoxEmployee.Text.Length == 0)
            {
                MessageBox.Show("操作员不能为空！");
                txtBoxEmployee.Focus();
                txtBoxEmployee.SelectAll();
                ReturnValue = true;
                return ReturnValue;
            }
            if (txtBoxProductName.Text.Length == 0)
            {
                MessageBox.Show("产品名称不能为空！");
                txtBoxProductName.Focus();
                txtBoxProductName.SelectAll();
                ReturnValue = true;
                return ReturnValue;
            }
            if (txtBoxSpec.Text.Length == 0)
            {
                MessageBox.Show("规格型号不能为空！！");
                txtBoxSpec.Focus();
                txtBoxSpec.SelectAll();
                ReturnValue = true;
                return ReturnValue;
            }
            try
            {
                 double productPrice =Convert.ToDouble(this.txtBOXproducPrice.Text.Trim());
            }
            catch 
            {
                MessageBox.Show("输入的价格格式有误！");
                txtBOXproducPrice.Focus();
                txtBOXproducPrice.SelectAll();
                ReturnValue = true;
                return ReturnValue;
            }

            return ReturnValue;
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comBoxProductClass.SelectedValue.ToString());
            //输入判读
           if( CheckInput())
           {
               return;
           }
            BUProductManagerResult myBUProductManagerResult = new BUProductManagerResult();

            int userNameID = Convert.ToInt32(myBUProductManagerResult.GetUserID(this.txtBoxEmployee.Text));
            string productName = this.txtBoxProductName.Text.Trim();
            int productClassID = Convert.ToInt32(this.comBoxProductClass.SelectedValue);
            string productSpec = this.txtBoxSpec.Text.Trim();
            int productUnit = Convert.ToInt32(this.comBoxUnit.SelectedValue);

            
            double productPrice =Convert.ToDouble(this.txtBOXproducPrice.Text.Trim());
            string remark = this.txtBoxRemark.Text.Trim();

            bool isTrue = myBUProductManagerResult.CheckProductAddResult(productClassID, productName, productSpec, productUnit, productPrice, userNameID, remark);
          
            if (isTrue)
            {

               MessageBox.Show("数据添加成功！");
               this.DialogResult = DialogResult.OK;

             }
             else
             {
               MessageBox.Show("数据添加失败！");
              this.DialogResult = DialogResult.No;
            }
            

           

          

        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmProductClassAdd MyfrmPCA = new frmProductClassAdd();
            MyfrmPCA.ShowDialog();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (CheckInput())
            {
                return;
            }
            BUProductManagerResult myBUProductManagerResult = new BUProductManagerResult();

            //int productID = Convert.ToInt32(this.txtBoxProductCode.Text.Trim());
            //int userNameID = Convert.ToInt32(this.txtBoxEmployee.Text.Trim());
            int userNameID = Convert.ToInt32(myBUProductManagerResult.GetUserID(this.txtBoxEmployee.Text));
            string productName = this.txtBoxProductName.Text.Trim();
            int productClassID = Convert.ToInt32(this.comBoxProductClass.SelectedValue);
            string productSpec = this.txtBoxSpec.Text.Trim();
            int productUnit = Convert.ToInt32(this.comBoxUnit.SelectedValue);
            double producPrice = Convert.ToDouble(this.txtBOXproducPrice.Text.Trim());
            string remark = this.txtBoxRemark.Text.Trim();

            bool isTrue = myBUProductManagerResult.CheckProductAddResult(productClassID, productName, productSpec, productUnit, producPrice, userNameID, remark);

            if (isTrue)
            {

                MessageBox.Show("数据添加成功！");
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("数据添加失败！");
                this.DialogResult = DialogResult.No;
            }

        }
    }
}
