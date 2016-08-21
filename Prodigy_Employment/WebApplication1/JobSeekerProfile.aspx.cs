using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class JobSeekerProfile : System.Web.UI.Page
    {       
        int JobSeekerID = 0;
        int EmployerID = 0;
         
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost1.Service1 lc = new localhost1.Service1();
            //lc.Timeout = 1000000000;
            //System.Net.ServicePointManager servicePoint;
         





            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("Employer"))//get JobSeekerID correctly
                {
                    EmployerID = (int)Session["UserID"];
                    JobSeekerID = Convert.ToInt32(Request.QueryString["JobSeekerID"]);
                }
                else if (((string)Session["UserType"]).Equals("JobSeeker"))
                {
                    JobSeekerID = (int)Session["UserID"];
                }

                
                ClientScript.RegisterStartupScript(this.GetType(), "myAlert", "alert('" + JobSeekerID + "');", true);


                var jobSeeker = lc.SingleJobseeker(JobSeekerID, true);
                string display = "";
                display = "<h2 style='text-align:center'>Job seeker Profile.</h2>";
                display += "<hr style='color:#683A0C'/><br/>";
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p>Here you can  view JobSeeker's full details including their identitification and contact details.";
                    display += "You can also view the informal skills of the Job seeker, including the list of previous jobs completed by the Job seeker and your tools and equipment that you use.</p><br />";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p>View your personal details and contact details here.";
                    display += "You can also view your informal skills, including the list of previous jobs that you have completed.</p><br />";
                }

                display += "<br/><h3>Job seeker details.</h3>";
                display += "<div class='row'>";
                display += "<div class='col-md-4' >";
                string base64ImageRepresentation = jobSeeker.ProfileImage_String;
                display += "<img width='100%' style='max-height: 300px' class='img-thumbnail' alt='image not available' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
                display += "</div>";
                display += "<div class='col-md-4' >";
                display += "<b>First Name:</b>           " + jobSeeker.FirstName + "<br/><br/>";
                display += "<b>Last Name: </b>           " + jobSeeker.LastName + "<br/><br/>";
                display += "<b>Residential Address:</b>  " + jobSeeker.ResidentialAddress + "<br/><br/>";
                display += "</div>";
                display += "</div>";
               
                display += "<br/>";
                           
                if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<br/><h3>Contact Details.</h3>";
                    display += "<p>Employers will use these contact details to cantact you whenever your application is successful.</p>";
                    display += "<br/><b>Contact Number:</b>         " + jobSeeker.ContactNumber + "<br/><br />";
                    display += "<b>Alternative Contact Number:</b>  " + jobSeeker.AlternativeContactNumber + "<br /><br />";
                    display += "<b>Email Address: </b>              " + jobSeeker.EmailAddress + "<br /><br />";
                }

                display += "<br/><h2>Job seeker skills. </h2>";
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p>This section contains the job seeker's informal skills that the job seeker has.";
                    display += "Job seekers may have more than one informal skills, depending on the number of jobs that they have preveous done, and continue to do, in their space </p>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p>This section contains  informal skills that you have.";
                    display += "Job seekers may have more than one informal skills, depending on the number of jobs that they have preveous done, and continue to do, in their space</p> ";
                    display += "<p>Click <a href='Skills.aspx'>here </a> to edit your skills.</p>";
                }
                display += "<br/><br/>";
                int count = 1;
                if((lc.ReadSkills(JobSeekerID, true) == null))
                {
                    display += "<p>NO SKILLS TO DISPLAY AT THE MOMENT.</p>";
                }
                foreach (var skill in lc.ReadSkills(JobSeekerID, true))
                {
                    display += "<b>Informal skill</b> " + count + " <b>: </b><br/>";
                    display += "<b>Skill name</b>:  " + skill.Name + "<br/>";
                    display += "<b>Skill Level </b>(How much the JobSeeker mastered the skill)<b>: </b>" + skill.SkillLevel; //can later change this to rating starts
                    count++;                   
                }
                display += "<br/><br/>";
                //Tools and equipment
                string htmlText = "<h2 style='text-align'>Tools and equipments.</h2>";
                if (Session["UserType"].Equals("Employer"))
                {
                    htmlText += "<p>Tools/Equipment are any resources that jobseeker have and use when doing a job that they have skills in. ";
                    htmlText += "You can, as an employer, provide your own tools or equipment if you prefer. Note that";
                    htmlText += "some jobs may not neccessary require job seeker owned tools or equipment.</p>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    htmlText += "<p>Here you can upload the picture of the tools or equipment that you use when doing the jobs you skilled in. ";
                    htmlText += "This may be a romoval bakkie if you do refuse removal, a grass cutting machine if you do grass cutting, a tree cutting machine if you do tree felling, or any tools that are essential to your job.";
                    htmlText += "You can upload upto 5 tools or any equipment that you use and want Employers to see to better your employment chances.</ p ><br/>";
                    htmlText += "<p>Yo can howover upload less than five images if you don't use that much tools or equipments. It is noted that some informal jobs do not require tools or equipment of your own to complete.";
                    htmlText += "So in this case you can choose not to upload any photos. Also note that some Employers may have their own tools and equipment which you can use aswell.</p>";
                    htmlText += "<p>Click <a href='ToolsAndEquipments.aspx'>here </a> to edit your Tools/Equipments.</p>";
                }
                htmlText += "<br/><br/>";
                htmlText += " <div class='row'>";
                foreach (var toolOrEquipment in lc.GetToolsAndEquipments(JobSeekerID, true))
                {
                    htmlText += " <div class='col-md-3' style='border: groove'>";
                    htmlText += "<img alt='No image to display style='height: 200px; width:100%' src='data:image/jpeg;base64," + toolOrEquipment.Image + "'/>";
                    htmlText += "<br/><p>Name/Short description: </p>" + toolOrEquipment.Name;
                    htmlText += "<br/>";
                    htmlText += "</div>";
                }               
                display += htmlText;

                //Employment history
                display += "<br/><br/><h3>Prevous employment history.</h3>";
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p>View prevous jobs completed by the job seeker including how the the job seeker did on that job based on the ratings provided by prevous Employers.</p>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p>View prevous jobs that you completed including how you did on that job based on the ratings provided by prevous Employers.";
                    display += "Other employers viewing your profile can see your prevous employmeny history, which might be in your favour when Employers are looking for people to hire.";
                    display += "Every time you get employment through InfomalJobFind, that job will be automatically saved in your employment history and your future potential employers can view it.";
                    display += "Simple put, the more Jobs you get the more experienced your profile will look.</p>";
                }
                display += "<br/><br/>";
                //for each loop to read from Employment History from the table and siplay it

                display += "<p><i>No Employment history currently availabel<i></p>";

                DisplayJobSeekerProfile.InnerHtml = display;
                if (Session["UserType"].Equals("Employer"))
                {
                    JobInvite.Visible = true; // if its an imployer they can invite
                }
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }           
        }

        protected void btnInvite_Click(object sender, EventArgs e)
        {
            localhost1.Service1 lc = new localhost1.Service1();
            lc.InviteJobSeeker(EmployerID, true, JobSeekerID, true);
            Response.Redirect("ViewUsers.aspx");
        }
        public void DisplaySuccessMessage()
        {
            if (Session["ScreenNotification"] == null)
            {
                Session.Add("ScreenNotification", "TurnON");
                Session.Add("ScreenNotificationMessage", "<p style='text-align:center'>Job Invite was successfully sent.</p>");
            }
        }
    }
}