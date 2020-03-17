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
    public partial class WebForm3Ass1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtstdate.Enabled = false;
                txtenddate.Enabled = false;
                ddldeptno.Enabled = false;
            }
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
        protected void rdbdeptno_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbdeptno.Checked)
            {
                txtstdate.Enabled = false;
                txtenddate.Enabled = false;
                ddldeptno.Enabled = true;
            }
        }
        protected void rdbjoindate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbjoindate.Checked)
            {
                txtstdate.Enabled = true;
                txtenddate.Enabled = true;
                ddldeptno.Enabled = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbjoindate.Checked) 
            {
                adp = new SqlDataAdapter("sp_Joiningdate", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@st", txtstdate.Text);
                adp.SelectCommand.Parameters.AddWithValue("@en", txtenddate.Text);
                DataSet ds = new DataSet();
                adp.Fill(ds, "E");
                gvdata.DataSource = ds.Tables["D"];
                gvdata.DataBind();
            }
            else if (rdbdeptno.Checked)
            {
                adp = new SqlDataAdapter("sp_dept", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@deptno", ddldeptno.SelectedValue);
                DataSet ds = new DataSet();
                adp.Fill(ds, "D");
                gvdata.DataSource = ds.Tables["D"];
                gvdata.DataBind();
            }
        }
    }
}