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
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("JobSeeker"))
                {
                    int jobID = Convert.ToInt32(Request.QueryString["JobID"]);
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
            localhost.ApplyForJob(jobID, true, (int)Session["UserID"], true);
           
            //show success message
            Session.Add("ScreenNotification", "TurnON");
            Session.Add("ScreenNotificationMessage", "< p >Your application was successful, thank you for applying.We will be intouch.</ p >");

            Response.Redirect("ViewJobs.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewJobs.aspx");
        }
    }
}