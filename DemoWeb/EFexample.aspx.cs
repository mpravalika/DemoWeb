using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class EFexample : System.Web.UI.Page
    {
        
        DemoEntities d = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities();
            //Response.Write(Session["user"].ToString());
        }

        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            try
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
                d.EMPDATAs.Add(E);
                d.SaveChanges();
            }
            catch(DbUpdateException E)//exception thrown by entity framework not from sql
            {
                SqlException Ex = E.GetBaseException() as SqlException;
                if (Ex.Message.Contains("EMP_PK"))
                    lblmsg.Text = "No duplicate empno";
                else if (Ex.Message.Contains("FK__EMPDATA__DEPTNO__3587F3E0"))
                    lblmsg.Text = "No deptno exists";
                else
                    lblmsg.Text = Ex.Message;
                txtemp.Text = " ";
                txtename.Text = " ";
                txtjob.Text = " ";
                txtmgr.Text = " ";
                txthiredate.Text = " ";
                txtsal.Text = " ";
                txtcomm.Text = " ";
                txtdept.Text = " ";
            }
        }
        protected void btninsert_Click(object sender, EventArgs e)
        {
            ObjectParameter ob = new ObjectParameter("R", typeof(string));
            d.sp_insertEmp(int.Parse(txtemp.Text),
                txtename.Text, txtjob.Text,
                int.Parse(txtmgr.Text),
                DateTime.Parse(txthiredate.Text),
                int.Parse(txtsal.Text),
                int.Parse(txtcomm.Text),
                int.Parse(txtdept.Text), ob);
            lblmsg.Text = ob.Value.ToString();
            txtemp.Text = " ";
            txtename.Text = " ";
            txtjob.Text = " ";
            txtmgr.Text = " ";
            txthiredate.Text = " ";
            txtsal.Text = " ";
            txtcomm.Text = " ";
            txtdept.Text=" ";
        }
    }
}