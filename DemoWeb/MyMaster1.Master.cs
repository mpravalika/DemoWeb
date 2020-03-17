using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class MyMaster1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.Cookies["Username"] == null)//checking cookie is created,if not goto login page
            //    Response.Redirect("Login.aspx");
            //else
            //    Label1.Text = "welcome " + Request.Cookies["Username"].Value;
            if (Session["user"] == null)
            {
                Response.Redirect("LoginEx.aspx");
            }
            else
                Label1.Text = " Welcome " + Session["user"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ////if(Request.Cookies["Username"]!=null)
            ////{
            ////    HttpCookie H = HttpContext.Current.Request.Cookies["Username"];
            ////    H.Expires= DateTime.Now.AddSeconds(10);
            ////    H.Value = " ";
            ////    HttpContext.Current.Response.Cookies.Add(H);
            ////    Response.Redirect("Login.aspx");
            ////}
            //to remove all session variables after logout

            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("LoginEx.aspx");
            
        }
    }
}