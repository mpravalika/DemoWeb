using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class QueryStrEx3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["a"];
            string s1 = Request.QueryString["b"];
            string s2 = Request.QueryString["c"];
            Response.Write(s + " " + s1 + " " + s2);
        }
    }
}