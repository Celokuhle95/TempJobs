using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prodigy_Employment
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["UserID"] != null && Session["UserType"] != null)
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
                    lblViewApplicants.Visible = true;

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
                    lblJobInvite.Visible = true;
   
                    //Show notification message
                    if (Session["ScreenNotificationMessage"] != null)
                    {
                        string notifyMessage = (string)Session["ScreenNotificationMessage"];
                        TurnNotificatiOn(notifyMessage);
                    }
                }
                else if (usertype.Equals("Admin"))
                {
                    lblViewJobs.Visible = true;
                    lblAllApplications.Visible = true;
                    lblJobInvites.Visible = true;
                    lblEmployers.Visible = true;
                    lblLogin.Visible = false;
                    lblRes.Visible = false;
                    lblLogout.Visible = true;
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
            if(notify != null)
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