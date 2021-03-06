﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data;
using System.Data.SqlClient;



namespace BULayer
{
    public class BUCheckResult
    {
        Sqlconn mySqlconn = new Sqlconn();
        
       
        
        public int CheckInput(string paramUsename,string paramPasswd,string paramTelephone,string paramEmail,string paramAddress)
        {
            int ReturnValue = 0;
            string strSQL = @" insert into adminuser  (username,passwd,telephone,email,address)
values('"+paramUsename+" ','"+paramPasswd+"','"+paramTelephone+"','"+paramEmail+"','"+paramAddress+"')";
            ReturnValue = mySqlconn.ReturnRowsLine(strSQL);
            return ReturnValue;

        }
        public int CheckUserModify(string paramUsename,string paramTelephone,string paramEmail,string paramAddress,int paramRoles,string paramPassword)
        {
            string strSQL = string.Empty;
            if (paramPassword.Length != 0)
            {
               strSQL = " update adminuser set telephone = '" + paramTelephone + "' ,[address] = '" + paramAddress + "',email = '" + paramEmail + "',RoleID = '" + paramRoles + "',passwd = '" + paramPassword + "' where username = '" + paramUsename + "'";
            }
            else
            {
                strSQL = " update adminuser set telephone = '" + paramTelephone + "' ,[address] = '" + paramAddress + "',email = '" + paramEmail + "',RoleID = '" + paramRoles + "' where username = '" + paramUsename + "'";
            }
            int ReturnValue = 0;
            ReturnValue = mySqlconn.ReturnRowsLine(strSQL);
            return ReturnValue;

        }

        public DataTable GetCustomerDt(string paramUserName)
        {
            DataSet myDs = new DataSet();
            DataTable myDt = new DataTable();
            Sqlconn mySqlconn = new Sqlconn();

            string SQL = "SELECT adminuser.username,adminuser.telephone,adminuser.email,adminuser.[address],T_RoleInfo.RoleName FROM adminuser,T_RoleInfo WHERE adminuser.RoleID = T_RoleInfo.RoleID ";

            if (paramUserName.Length > 0)
            {
                SQL += " and  UserID='" + paramUserName + "'";
            }
            myDs = mySqlconn.Query(SQL);
            if (myDs.Tables.Count == 0 || myDs.Tables[0].Rows.Count == 0)
            {
                //MessageBox.Show("暂无数据");
                return myDt;
            }
            myDt = myDs.Tables[0];
            return myDt;
        }

        public DataTable GetProductList()
        {
            DataSet myDs = new DataSet();
            DataTable myDt = new DataTable();
            Sqlconn mySqlConn = new Sqlconn();
            string strSql = "select ProductClassID , RTRIM(ProductClassName ) as ProductClassName  from  ProductClass";
            myDs = mySqlconn.Query(strSql);
            myDt = myDs.Tables[0];
            return myDt;
        }

        public DataTable GetProductUnit()
        {
            DataTable mydt = new DataTable();
            DataSet myds = new DataSet();
            string strSql = "select ProductUnitID,ProductUnitName from ProductUnit"; 
            myds = mySqlconn.Query(strSql);
            mydt = myds.Tables[0];
            return mydt;
        }
        public bool DelData(string userName)
        {
            int ReturnValue = 0;
            string strSql = "delete  from adminuser where username = '" + userName + "'";

            ReturnValue = mySqlconn.ExeNonQuery(strSql); ;

            if (ReturnValue > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }




    }
}
