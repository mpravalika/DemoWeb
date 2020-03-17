using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoWeb
{
    public partial class LoginEx : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_ValidateLogin", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@u", txtusername.Text);
            adp.SelectCommand.Parameters.AddWithValue("@p", txtpwd.Text);
            SqlParameter R = new SqlParameter("@cnt", SqlDbType.Int);
            R.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(R);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
            if (R.Value.ToString()=="1")
            {
                Session["user"] = txtusername.Text;
                Response.Redirect("EFexample.aspx");
            }
            else
            {
                lblmsg.Text = "Invalid Credentials";
                txtusername.Focus();
            }
        }
    }
}