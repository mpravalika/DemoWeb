using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace DemoWeb
{
    public partial class Extract : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            if (!IsPostBack)
            {
                adp = new SqlDataAdapter("sp_ExtractDept", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adp.Fill(ds, "D");
                ddldeptno.DataSource = ds.Tables["D"];
                ddldeptno.DataTextField = "DNAME";
                ddldeptno.DataValueField = "DEPTNO";
                ddldeptno.DataBind();//to bind data to control when page is refreshed
            }
        }

        protected void ddldeptno_SelectedIndexChanged(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_GetDeptdetails", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@deptno", ddldeptno.SelectedValue);
            DataSet ds = new DataSet();
            adp.Fill(ds, "D");
            gvdata.DataSource = ds.Tables["D"];
            gvdata.DataBind();
        }

        protected void gvdata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}