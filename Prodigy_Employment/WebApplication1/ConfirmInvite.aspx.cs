using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ConfirmInvite : System.Web.UI.Page
    {
        int EmployerID;
        int JobID;
        localhost.Service1 lc = new localhost.Service1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("Employer"))//get empolyerID correctly
                {
                    EmployerID = (int)Session["UserID"];
                    JobID = Convert.ToInt32(Request.QueryString["JobID"]);
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

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            int JobSeekerID = (int)Session["JobSeekerID"];
            lc.InviteJobSeeker(EmployerID, true, JobSeekerID, true, JobID, true);
            DisplaySuccessMessage();
            Session["JobSeekerID"] = null;
            Response.Redirect("ViewUsers.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

        public void DisplaySuccessMessage()
        {
            if (Session["ScreenNotification"] == null)
            {
                Session.Add("ScreenNotification", "TurnON");
                Session.Add("ScreenNotificationMessage", "<p style='text-align:center'>Thank you for sending job invite.The job invite was successfully sent.</p>");
            }
        }
    }
}