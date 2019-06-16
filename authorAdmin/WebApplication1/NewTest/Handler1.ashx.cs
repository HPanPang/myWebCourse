using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;


namespace WebApplication1.NewTest
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "Json";
            int djId = Convert.ToInt32(context.Request.QueryString["danjuId"].ToString());
            string djName = context.Request.QueryString["danjuName"].ToString();
            string djContent = context.Request.QueryString["djContent"].ToString();
            string fun = context.Request.QueryString["fun"].ToString();

            context.Response.Write(fun);
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
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