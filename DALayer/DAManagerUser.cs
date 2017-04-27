using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DALayer
{
   public class DAManagerUser
    {
       Sqlconn MySqlconn = new Sqlconn();
       public string GetUserPassword(string paramUserName)
       {
           Sqlconn mySqlconn = new Sqlconn();
           DataSet myDs = new DataSet();
           string returnValue = string.Empty;
           string strSql = "select passwd from adminuser where 1=1";
           if (paramUserName.Length >0)
           {
               strSql +=" and  userName ='" + paramUserName + "'";
               myDs = mySqlconn.Query(strSql);

               if (myDs.Tables.Count > 0 && myDs.Tables[0].Rows.Count > 0)
               {
                   returnValue = mySqlconn.ExecuteSql(strSql);
                   return returnValue;
                  
               }

               return returnValue;
           }



           return returnValue;
       }
       public DataTable GetRolesList()
       {
           string strSql = "select RoleID,RoleName from T_RoleInfo";
           DataTable returnValue = MySqlconn.Query(strSql).Tables[0];

           return returnValue;
       }

       public DataTable GetRole(string paramUserName)
       {
           DataTable myDt = new DataTable();
           string strSql = "select T_RoleInfo.RoleName from T_RoleInfo,adminuser where T_RoleInfo.RoleID = adminuser.RoleID and adminuser.username='"+paramUserName+"'";
           myDt = MySqlconn.Query(strSql).Tables[0];
           return myDt;
       }

       public int GetRoleID(string paramRoleName)
       { 
           DataTable myDt = new DataTable();
           string strSql = "select RoleID from T_RoleInfo where RoleName = '"+paramRoleName+"'";
           myDt = MySqlconn.Query(strSql).Tables[0];
           int returnValue = Convert.ToInt32(myDt.Rows[0][0]);
           return returnValue;
       }

    }
}


