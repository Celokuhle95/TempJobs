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
        public localhost.Service1 localhost;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("Employer"))//get JobSeekerID correctly
                {
                    localhost = new localhost.Service1();
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
            string name = txtName.Text;
            string description = txtDescription.Text;
            int numDays = Convert.ToInt32(NumberOfDays.Value);
            string duedate = GetDate(DueDate.Value);
            string startdate = GetDate(StartDate.Value);
            string startTime = StartTime.Value;
            string endTime = EndTime.Value;
            string location = txtLocation.Text;
            double amount = Convert.ToDouble(PayAmount.Value);
            int EmployerID = (int)Session["UserID"];
            string skill = drpSkill.SelectedItem.Text;
            int JobID;                                  //get the job ID
            bool a;                                     //get the job ID
            localhost.PostJob(name, description, numDays, true, duedate, startdate, startTime, endTime, location, amount, true, skill, EmployerID, true, out JobID, out a);
            //display some message to let employer know that posting was successful.
            Session.Add("ScreenNotification", "TurnON");          
            Session.Add("ScreenNotificationMessage", "<div class='alert alert-success fade-in'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a><p>Thank you for posting the job, your post was successful. Check applications later.</p></div>");

            Session.Add("RequiredSkill", skill); //add skill for use earlier
            Response.Redirect(String.Format("JobSeekersWithRequiredSkill.aspx?JobID={0}", JobID));
        }
        public string GetDate(string stringDate)
        {          
            DateTime loadedDate = Convert.ToDateTime(stringDate);
            string DateInCorrectFormat = loadedDate.ToString("dd MMMM yyyy");
            return DateInCorrectFormat;
        }
    }
}