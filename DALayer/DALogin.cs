﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
   public class DALogin
    {
     
       Sqlconn mySqlconn = new Sqlconn();//实例化类
       string SQL = string.Empty;//保持SQL语句


       /// <summary>
       ///   //判断用户是否存在,第一行第一例是否有值
       /// </summary>
       /// <param name="paramUserName"></param>
       /// <returns></returns>
       public string GetUserInfo(string paramUserName)
       {
           string RetuenValue=string .Empty ;
           SQL = "select username from adminuser where username = '" + paramUserName + "'";
           RetuenValue = mySqlconn.ExecuteSql(SQL);
           return RetuenValue;
       }

       /// <summary>
       /// 通过已有的用户 获取用户表信息
       /// </summary>
       /// <param name="paramUserName"></param>
       /// <returns></returns>
       public DataTable GetUserData(string paramUserName) 
       {
           DataTable myDt = new DataTable();
           SQL = "select * from adminuser where username = '" + paramUserName + "'";
           DataSet myDs = new DataSet();
           myDs = mySqlconn.Query(SQL);
           myDt = myDs.Tables[0];
           return myDt;
       }

   
       /// <summary>
       /// 通过角色获取到模块值
       /// </summary>
       /// <param name="paramRoleID"></param>
       /// <returns></returns>
       public DataTable GetModuleList(int paramRoleID)
       {
           DataTable myDt = new DataTable();
           SQL = @" SELECT * FROM T_Module  left join T_Role on  T_Role.MODULEID=T_Module.ID where  ROLEID='" + paramRoleID + "' and  Enable='true' and  parentID=0 ";
           DataSet myDs = new DataSet();
           myDs = mySqlconn.Query(SQL);
           myDt = myDs.Tables[0];
           return myDt;
       }

       /// <summary>
       /// 子节点信息
       /// </summary>
       /// <param name="paramRoleID"></param>
       /// <returns></returns>
       public DataTable GetChildModuleList(int paramRoleID, string paramFatherMID)
       {
           DataTable myDt = new DataTable();
           SQL = @" SELECT * FROM T_Module  left join T_Role on  T_Role.MODULEID=T_Module.ID where  ROLEID='" + paramRoleID + "' and  Enable='true' and   ParentID='" + paramFatherMID + "' ";
           DataSet myDs = new DataSet();
           myDs = mySqlconn.Query(SQL);
           myDt = myDs.Tables[0];
           return myDt;
       }
    }
}
