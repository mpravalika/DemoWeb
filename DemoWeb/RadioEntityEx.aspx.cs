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
    public partial class RadioEntityEx : System.Web.UI.Page
    {
        DemoEntities1 d = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities1();
            if (!IsPostBack)
            {
                txtstdate.Enabled = false;
                txtenddate.Enabled = false;
                ddldeptno.Enabled = false;
            }
            if (!IsPostBack)
            {
                var D = from D1 in d.DEPTDATAs
                        select D1;
                ddldeptno.DataValueField = "Deptno";
                ddldeptno.DataTextField = "Dname";
                ddldeptno.DataSource = D.ToList();
                DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbjoindate.Checked)
            {
                DateTime st = DateTime.Parse(txtstdate.Text);
                DateTime end = DateTime.Parse(txtenddate.Text);
                var E = from E1 in d.EMPDATAs
                        where E1.HIREDATE >= st && E1.HIREDATE <= end
                        select E1;
                List<EMPDATA> emp = E.ToList();
                gvdata.DataSource = emp;
                gvdata.DataBind();
                if (gvdata.Rows.Count == 0)
                    label.Text = "no data found";
            }
            if (rdbdeptno.Checked)
            {
                int dno = int.Parse(ddldeptno.Text);
                var D = from D1 in d.EMPDATAs
                        where D1.DEPTNO == dno
                        select D1;
                List<EMPDATA> dept = D.ToList();
                gvdata.DataSource = dept;
                gvdata.DataBind();
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
        protected void rdbdeptno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbdeptno.Checked)
            {
                txtstdate.Enabled = false;
                txtenddate.Enabled = false;
                ddldeptno.Enabled = true;
            }
        }
    }
}