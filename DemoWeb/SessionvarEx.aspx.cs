﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class SessionvarEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            EMPDATA E = new EMPDATA();
            E.EMPNO = int.Parse(txtemp.Text);
            E.ENAME = txtename.Text;
            E.JOB = txtjob.Text;
            E.MGR = int.Parse(txtmgr.Text);
            E.HIREDATE = DateTime.Parse(txthiredate.Text);
            E.SAL = int.Parse(txtsal.Text);
            E.COMM = int.Parse(txtcomm.Text);
            E.DEPTNO = int.Parse(txtdept.Text);
            Session["E"] = E;
            Response.Redirect("confirm.aspx");
        }
    }
}