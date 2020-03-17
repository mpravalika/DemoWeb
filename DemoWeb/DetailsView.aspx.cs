using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class DetailsView : System.Web.UI.Page
    {
        DemoEntities1 D = null;

        private void bind()
        {
            D = new DemoEntities1();
            var v = from T in D.Total1
                    select T;
            GridView1.DataSource = v.ToList();
            GridView1.DataBind();
            DView.DataSource = v.ToList();
            DView.DataBind();
            FormView1.DataSource = v.ToList();
            FormView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            bind();    
        }

        protected void DView_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DView.PageIndex = e.NewPageIndex;
            bind();
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex = e.NewPageIndex;
            bind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }
    }
}