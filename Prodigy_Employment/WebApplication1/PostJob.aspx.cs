using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PostJob : System.Web.UI.Page
    {
        public localhost1.Service1 localhost;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("Employer"))//get JobSeekerID correctly
                {
                    localhost = new localhost1.Service1();
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

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string name = drpSkillName.SelectedValue;
            string description = txtDescription.Text;
            string location = txtLocation.Text;
            int numberOfDays = Convert.ToInt32(txtNumDays.Text);
            int startTime = Convert.ToInt32(txtStartTime.Text);
            double payPerDay = Convert.ToDouble(txtReward.Text);
            double pay = payPerDay * numberOfDays; // pay per day
            int endTime = Convert.ToInt32(txtEndTime.Text);
            int EmployerID = (int)Session["UserID"];
            localhost.PostJob(name, description, numberOfDays, true, startTime, true, endTime, true, location, pay, true, EmployerID, true);
            //display some message to let employer know that posting was successful.
            Session.Add("ScreenNotification", "TurnON");
            Session.Add("ScreenNotificationMessage", "<p>Thank you for posting the job, your post was successful. Check applications later</p>");
            Response.Redirect("Home.aspx");
        }
    }
}