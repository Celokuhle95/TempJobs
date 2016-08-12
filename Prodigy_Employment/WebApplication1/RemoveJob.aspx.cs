using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class RemoveJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int jobID = Convert.ToInt32(Request.QueryString["JobID"]);
            localhost1.Service1 localhost = new localhost1.Service1();
            foreach (var jb in localhost.AllJobs())
            {
                if (jb.JobID == jobID)
                {
                    localhost.DeleteJob(jobID, true);
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" +"Job Successfully removed" + "');", true);
                    Response.Redirect("viewReportedJobs.aspx");
                }
            }
        }
    }
}