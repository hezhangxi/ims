using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data;

namespace BULayer
{
    public class BUUserManager
    {
        DAManagerUser dal = new DAManagerUser();
        public bool checkOldPassword (string paramUserName,string txtBoxPassword)
        {
            bool returnValue = false;
            
            DAManagerUser myDAManager = new DAManagerUser();
            string myPassword = myDAManager.GetUserPassword(paramUserName).Trim();
            if (myPassword == txtBoxPassword)
            {
                returnValue = true;
                return returnValue;
            }

            return returnValue;

        }


        public int ModifyPassword(string paramUsename,string paramPassword)
        {
            Sqlconn mySqlconn = new Sqlconn();
            int ReturnValue = 0;
            string strSQL = " update adminuser set passwd = '" + paramPassword + "' where username = '" + paramUsename + "' ";
            ReturnValue = mySqlconn.ReturnRowsLine(strSQL);
            return ReturnValue;

        }

        public DataTable GetRolesList()
        {
            return dal.GetRolesList();
        }

        public string GetRole(string paramUsername)
        {
            string  returnValue = string.Empty;
               returnValue = dal.GetRole(paramUsername).Rows[0][0].ToString();
            return returnValue;

        }
        public int GetRoleID(string paramRoleName)
        {
            int returnValue = dal.GetRoleID(paramRoleName);
            return returnValue;

        }


    }
}
