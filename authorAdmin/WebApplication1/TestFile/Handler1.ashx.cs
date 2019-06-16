using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace WebApplication1.TestFile
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //Page_Load(context);
            string fk;
            int code = 1; //默认状态为1
            String fileNameList = "{}";
            string dateString = "";
            try
            {
                HttpFileCollection files = context.Request.Files;
                string filePath = context.Server.MapPath(@"./UploadFiles");
                if (files.Count > 0)
                {
                    fileNameList = "";
                    for (int i = 0; i < files.Count; i++)
                    {
                        DateTime date = DateTime.Now;
                        dateString = date.ToString(@"yyyy\-MM\-dd HH\:mm\:ss\:ff");
                        //转换文件名前缀用时间
                        string time = dateString.Replace("-", "");
                        time = time.Replace(":", "");
                        time = time.Replace(" ", "");
                        dateString = dateString.Substring(0, dateString.Length - 3);
                        string fileName = time + "-" + files[0].FileName;
                        fileNameList += ",'" + fileName + "'";
                        files[i].SaveAs(Path.Combine(filePath, fileName));
                    }
                    fileNameList = fileNameList.Substring(1, fileNameList.Length - 1);
                    fileNameList = "[" + fileNameList + "]";
                }
                fk = "success";
                code = 0;  //0表示上传成功
            }
            catch (Exception ex)
            {
                fk = "failure-" + ex.ToString();

            }
            string res = "{'code':" + code + ",'msg':'" + fk + "','data':{'fileNameList':" + fileNameList + ",'dateString':'" + dateString + "'}}";
            res = res.Replace("\'", "\"");
            context.Response.ContentType = "text/plain";
            context.Response.Write(res);
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}