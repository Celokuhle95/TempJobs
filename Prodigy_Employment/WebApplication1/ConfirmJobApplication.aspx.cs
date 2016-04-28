using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ConfirmJobApplication : System.Web.UI.Page
    {
        int jobID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            int jobID = Convert.ToInt32(Request.QueryString["JobID"]);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            localhost.Service1 localhost = new localhost.Service1();
            localhost.ApplyForJob(jobID, true, (int)Session["id"], true);
            Response.Redirect("ViewJobs.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewJobs.aspx");
        }
    }
}