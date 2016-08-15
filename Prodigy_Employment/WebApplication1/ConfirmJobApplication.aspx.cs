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
        private int jobID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            jobID = Convert.ToInt32(Request.QueryString["JobID"]);
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("JobSeeker"))
                {
                    
                }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            localhost1.Service1 localhost = new localhost1.Service1();
           
            //ClientScript.RegisterStartupScript(this.GetType(), "myAlert", "alert('" + jobID + "');", true);
            localhost.ApplyForJob(jobID, true, (int)Session["UserID"], true);
            //show success message
            Session.Add("ScreenNotification", "TurnON");
            Session.Add("ScreenNotificationMessage", "<p style='text-align:center'>Your application was successful, thank you for applying.We will be intouch.</p>");

            Response.Redirect("ViewJobs.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewJobs.aspx");
        }
    }
}