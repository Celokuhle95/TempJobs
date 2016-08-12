using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ReportJob : System.Web.UI.Page
    {
        localhost1.Service1 localhost;
        int EmployerID;
        int JobSeekerID;
        int jobID;

        protected void Page_Load(object sender, EventArgs e)
        {
            JobSeekerID = Convert.ToInt32(Session["UserID"]);
            jobID = Convert.ToInt32(Request.QueryString["JobID"]);
            localhost = new localhost1.Service1();
            if (Session["UserID"] != null)
            {
                   
                   JobSeekerID= Convert.ToInt32(Session["UserID"]);
                   foreach (var job in localhost.AllJobs())
                    {
                        if (job.JobID == jobID)
                        {
                            txtJobName.Text = job.Name;
                            EmployerID = Convert.ToInt32(job.EmployerID);
                           // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + EmployerID + "');", true);
                           ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + jobID+ "');", true);
                            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + JobSeekerID + "');", true);
                            txtJobName.Enabled = false;
                        }
                    }
            }
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            localhost.ReportJob(1, true, JobSeekerID, true, jobID, true, txtComment.Text);
            Response.Redirect("ViewJobs.aspx");
        }
    }
}