using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DemoWeb
{
    public partial class AddEmp : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }

        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_insertEmp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtemp.Text));
            adp.SelectCommand.Parameters.AddWithValue("@en", txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@job", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse(txtmgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@hr", DateTime.Parse(txthiredate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse(txtsal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@cmm", int.Parse(txtcomm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdept.Text));
            SqlParameter R = new SqlParameter("@R", SqlDbType.NVarChar, 100);
            R.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(R);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
           
        }
    }
}