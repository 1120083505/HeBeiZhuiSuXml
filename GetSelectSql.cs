using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using DbHelper;
using NewLife.Xml;
using Quartz;
using RomensInterfaceExtension;

namespace Romens.HeBeiZhuiSuXml
{
    public class GetSelectSql : IUpJob
    {
        public string ConnString = ConfigurationManager.AppSettings["conn"];

        public bool ExecJob(JobPara paras, DataSet dsData, out string errorMsg)
        {
            try
            {
                var signture = new SIGNATURE();
                if (string.Equals(paras.jobCode, "10002", StringComparison.Ordinal))
                {
                    //主表
                    var mInflatable = dsData.Tables["Head"];
                    if (mInflatable.Rows.Count <= 0)
                    {
                        errorMsg = "暂无修改数据！";
                        return true;
                    }
                    foreach (DataRow item in mInflatable.Rows)
                    {
                        var executeSql = item["SELECTSQL"].ToString();
                        var oracleHelper = new SqlHelper("Oracle", ConnString);
                        var penelope = oracleHelper.GetDataTable(executeSql);
                        if (item["CODE"].ToString().Equals("HBYPJG_IN_DATAINFO"))
                        {
                            if (penelope.Rows.Count > 0)
                            {
                                for (var i = 0; i < penelope.Rows.Count; i++)
                                {
                                    var rowsInfo = new SIGNATUREOBJECTPACKAGEROWINFO();
                                    var getClass = rowsInfo.GetType().GetProperties();
                                    foreach (var classInfo in getClass)
                                    {
                                        classInfo.SetValue(getClass, penelope.Rows[i][classInfo.Name].ToString(), null);
                                    }
                                    signture.OBJECT.PACKAGE.DATAINFO.Add(rowsInfo);
                                }
                            }
                        }
                        if (!item["CODE"].ToString().Equals("HBYPJG_IN_ENVELOPINFO")) continue;
                        if (penelope.Rows.Count <= 0) continue;
                        var propsInfo = signture.OBJECT.PACKAGE.ENVELOPINFO.GetType().GetProperties();
                        foreach (var variable in propsInfo)
                        {
                            variable.SetValue(propsInfo, penelope.Rows[0][variable.Name].ToString(), null);
                        }
                    }
                    XmlHelper.ToXmlFile(signture, "", Encoding.UTF8);
                }

                errorMsg = "操作成功";
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}