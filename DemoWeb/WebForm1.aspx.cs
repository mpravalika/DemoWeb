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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = new SqlDataAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        } 

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from EmpData", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow R = ds.Tables["E"].NewRow();
            R[0] =int.Parse( txtempno.Text);
            R[1] = txtename.Text;
            R[2] = txtjob.Text;
            R[3] = txtmgr.Text;
            R[4] = DateTime.Parse(txthiredate.Text);
            R[5] = int.Parse(txtsal.Text);
            R[6] = int.Parse(txtcomm.Text);
            R[7] = int.Parse(txtdept.Text);
            ds.Tables["E"].Rows.Add(R);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
            adp.InsertCommand=cmd.GetInsertCommand();
            adp.Update(ds,"E");
            Response.Write("<script> alert('1 row inserted')</script>");
            Console.Read();

        }
    }
}