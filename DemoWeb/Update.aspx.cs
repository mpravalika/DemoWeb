using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class Update : System.Web.UI.Page
    {
        DemoEntities1 d = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities1();
        }
        protected void txtemp_TextChanged(object sender, EventArgs e)
        {
            int eno = int.Parse(txtemp.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO==eno
                    select E1;
            //List<EMPDATA> emp = E.ToList();//if result E has multiple objects,we assign to list
            EMPDATA emp = E.First();//if result is 1 obj,assign to var
            txtename.Text = emp.ENAME;
            txtjob.Text = emp.JOB;
            txtmgr.Text = emp.MGR.ToString();
            string hd = DateTime.Parse(emp.HIREDATE.ToString()).ToString("yyyy-MM-dd");
            txthiredate.Text = hd;
            txtsal.Text = emp.SAL.ToString();
            txtcomm.Text = emp.COMM.ToString();
            txtdept.Text = emp.DEPTNO.ToString();
        }
        protected void Btnupdate_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtemp.Text);
            var Emp = from E1 in d.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA E = Emp.First();
            E.JOB = txtjob.Text;
            E.MGR = int.Parse(txtmgr.Text);
            E.SAL = int.Parse(txtsal.Text);
            int c = 0;
            bool b = int.TryParse(txtcomm.Text, out c);//converts null to 0
            if (c != 0)//to show null if comm not chnaged
            { E.COMM = c; }
            E.DEPTNO = int.Parse(txtdept.Text);
            d.SaveChanges();
        }

        protected void btncdelete_Click(object sender, EventArgs e)
        {
        }

        protected void Btndelete_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtemp.Text);
            var Emp = from E1 in d.EMPDATAs
                      where E1.EMPNO == eno
                      select E1;
            EMPDATA E = Emp.First();
            d.EMPDATAs.Remove(E);
            d.SaveChanges();

        }
    }
}