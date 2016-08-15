using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DeleteJob : System.Web.UI.Page
    {
        int jobID;
        localhost1.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost1.Service1 lc = new localhost1.Service1();
            jobID = Convert.ToInt32(Request.QueryString["JobID"]);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            lc.DeleteJob(jobID, true);
            Response.Redirect("ViewJobs.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewJobs.aspx");
        }
    }
}