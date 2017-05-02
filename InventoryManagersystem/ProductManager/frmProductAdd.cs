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

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comBoxProductClass.SelectedValue.ToString());
            //输入判读

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
               
            }
            else
            {
                MessageBox.Show("数据添加失败！");
            }

          

        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmProductClassAdd MyfrmPCA = new frmProductClassAdd();
            MyfrmPCA.ShowDialog();

        }
    }
}
