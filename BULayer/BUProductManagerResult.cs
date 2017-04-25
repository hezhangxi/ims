using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DALayer;



namespace BULayer
{
    public class BUProductManagerResult
    {

        DAProductManagerResult dal = new DAProductManagerResult(); 


        public DataTable GetMyDt(string productUnitName)
        {
                return dal.GetMyDt(productUnitName);
        }
        public bool CheckUnitName(string paramUnitName)
        {
            return dal.CheckUnitName(paramUnitName);
        }
         public bool DelData(string ProductUnitID)
        {
            return dal.DelData(ProductUnitID);
        }

        public bool CheckModifyUnit(string paramUnitName,string paramRemark,string paramUnitCode)
         {
             bool returnValue = false;

             int intValue = dal.UpdateUnitReturnRowCount(paramUnitName,paramRemark,paramUnitCode);
             if (intValue >0)
             {
                 returnValue = true;
                 return returnValue;
             }

             return returnValue;

         }

    }
}
