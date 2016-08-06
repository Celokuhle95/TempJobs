using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        localhost1.Service1 lc = new localhost1.Service1();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] != null)
            {
                TurnNotificationSectionOFF();
                int userID = (int)Session["UserID"];
                string usertype = (string)Session["UserType"];
                if (usertype.Equals("Employer"))
                {
                    lblPostJob.Visible = true;
                    lblViewJobseekers.Visible = true;
                    lblLogin.Visible = false;
                    lblRes.Visible = false;
                    lblLogout.Visible = true;

                    //Show notification message to employer
                    if (Session["ScreenNotificationMessage"] != null)
                    {
                        string notifyMessage = (string)Session["ScreenNotificationMessage"];
                        TurnNotificatiOn(notifyMessage);
                    }
                }
                else if (usertype.Equals("JobSeeker"))
                {
                    lblViewJobs.Visible = true;
                    lblProfile.Visible = true;
                    lblLogin.Visible = false;
                    lblRes.Visible = false;
                    lblLogout.Visible = true;

                    //Show notification message to employer
                    if (Session["ScreenNotificationMessage"] != null)
                    {
                        string notifyMessage = (string)Session["ScreenNotificationMessage"];
                        TurnNotificatiOn(notifyMessage);
                    }
                }
            }
        }
        public void TurnNotificationSectionOFF()
        {
            if (((string)Session["ScreenNotification"]) != null)
            {
                if (((string)Session["ScreenNotification"]).Equals("TurnOFF")) //switch the notification tab off, when you move to the next page
                {
                    NotificationSection.Visible = false;
                    Session["ScreenNotification"] = null;
                    Session["ScreenNotificationMessage"] = null;
                }
            }
        }

        public void TurnNotificatiOn(string displayMessage)
        {
            string notify = (string)Session["ScreenNotification"];
            if (notify != null)
            {
                if (notify.Equals("TurnON"))
                {
                    NotificationSection.InnerHtml = displayMessage;
                    NotificationSection.Visible = true;
                    Session["ScreenNotification"] = "TurnOFF";
                }//run a timer to ensure that you set session variable off
            }
        }
    }
}