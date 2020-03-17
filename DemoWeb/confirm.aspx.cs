using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class confirm : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            if (Session["E"] != null)
            {
                EMPDATA E = (EMPDATA)Session["E"];
                lblempno.Text = E.EMPNO.ToString();
                lblename.Text = E.ENAME;
                lbljob.Text = E.JOB;
                lblmgr.Text = E.MGR.ToString();
                lblhiredate.Text = E.HIREDATE.ToString();
                lblsal.Text = E.SAL.ToString();
                lblcomm.Text = E.COMM.ToString();
                lbldeptno.Text = E.DEPTNO.ToString();    
            }
            else 
            {
                Response.Redirect("SessionvarEx.aspx");
            }
        }
        protected void btnconfirm_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_insertEmp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(lblempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@en", lblename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@job", lbljob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse(lblmgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@hr", DateTime.Parse(lblhiredate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse(lblsal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@cmm", int.Parse(lblcomm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(lbldeptno.Text));
            SqlParameter R = new SqlParameter("@R", SqlDbType.NVarChar, 100);
            R.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(R);
            DataSet ds = new DataSet();
            adp.Fill(ds, "D");
            //to delete session variable
            //Session["E"] = null;
            Session.Remove("E");
        }
    }
}