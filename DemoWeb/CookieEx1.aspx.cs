using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class CookieEx1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length!=0)
            {
                Response.Cookies["U"].Value= TextBox1.Text;//create cookie variable
                //second type to create cookie
                HttpCookie H = new HttpCookie("User1");
                H.Value = TextBox1.Text;
                Response.Cookies.Add(H);
                Response.Cookies["U"].Expires = DateTime.Now.AddSeconds(15);//declare expiry time for cookie
                Response.Redirect("CookieEx2.aspx");
            }
        }
    }
}