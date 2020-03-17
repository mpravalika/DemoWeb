using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class MyMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if before login and after login has same master page-AddEmp.apx(MyMaster)
            //string S = Path.GetFileName(Request.Path);
            //if (S != "LoginEx.aspx")
            //{
            //    if (Session["user"] == null)
            //    {
            //        Response.Redirect("LoginEx.aspx");
            //    }
            //    else
            //        Label1.Text = "welcome" + Session["user"].ToString();
            //}
        }
    }
}