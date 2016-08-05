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
        localhost1.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"] != null)
            {
                lc = new localhost1.Service1();
                int JobSeekerID = Convert.ToInt32(Request.QueryString["JobSeekrID"]);
                var jobSeeker = lc.SingleJobseeker(JobSeekerID, true);
                string display = "";
                display = "<h2>Job seeker Profile.</h2>";
                display += "<hr id='Hr1' style='color: #808080, #C2C2C2'/>";
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p>Here you can  view Job seeker's full details including their identitification and contact details.</p>";
                    display += "<p>You can also view the informal skills of the Job seeker, including the list of previous jobs completed by the Job seeker.<br />";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p>View your personal details and contact details here.</p>";
                    display += "<p>You can also view your informal skills, including the list of previous jobs that you have completed.<br />";
                }

                display += "<h3>Job seeker details</h3>";
                display += "First Name: " + jobSeeker.FirstName + "<br/>";
                display += "Last Name: " + jobSeeker.LastName + "<br/>";
                display += "Residential Address: " + jobSeeker.ResidentialAddress + "<br/>";
                display += "<br/>";
                display += "<h3>Contact Details.</h3>: ";
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p>You can use these contact details to contact the seeker if you wish to apporve their application and employ them.</p><br/>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "Employers will use these contact details to cantact you whenever application is successful.<br />";
                }
                display += "Contact Number: " + jobSeeker.ContactNumber + "<br/>";
                display += "Alternative Contact Number: " + jobSeeker.AlternativeContactNumber + "<br />";
                display += "Email Address: " + jobSeeker.EmailAddress + "<br />";
                display += "<h3>Job seeker skills: </h3>";

                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p>This section contains the job seeker's informal skills that the job seeker has.</p>";
                    display += "<p>Job seekers may have more than one informal skills, depending on the number of jobs that they have preveous done, and continue to do, in their space </p><br/>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p>This section contains  informal skills that you have.</p>";
                    display += "<p>Job seekers may have more than one informal skills, depending on the number of jobs that they have preveous done, and continue to do, in their space </p><br/>";
                }
                int count = 1;
                foreach(var skill in lc.ReadSkills(JobSeekerID, true))
                {
                    display += "<b>Informal skill " + count + ":<b>";
                    display += "Skill name: " + skill.Name + "<br/>";
                    display += "Skill Level(How much the JobSeeker mastered the skill): " + skill.SkillLevel + "<br/>"; //can later change this to rating starts
                    count++;
                }
                if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "click <a href='Skills.aspx'>here </a> to edit your skills.<br/><br/>";
                }
                             
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
                    htmlText += "<br/><p>Here you can upload the picture of the tools or equipment that you use when doing the jobs you skilled in. ";
                    htmlText += "This may be a romoval bakkie if you do refuse removal, a grass cutting machine if you do grass cutting, a tree cutting machine if you do tree felling, or any tools that are essential to your job.";
                    htmlText += "You can upload upto 5 tools or any equipment that you use and want Employers to see to better your employment chances.</ p ><br/>";
                    htmlText += "<p>Yo can howover upload less than five images if you don't use that much tools or equipments. It is noted that some informal jobs do not require tools or equipment of your own to complete.";
                    htmlText += "So in this case you can choose not to upload any photos. Also note that some Employers may have their own tools and equipment which you can use aswell.</ p ><br/> ";
                    htmlText += " <div class='row'>";
                }

                foreach (var toolOrEquipment in lc.GetToolsAndEquipments(JobSeekerID, true))
                {
                    htmlText += " <div class='col-md-3' style='border: groove'>";
                    htmlText += "<img alt='No image to display style='height: 200px; width:100%' src='data:image/jpeg;base64," + toolOrEquipment.Image + "'/>";
                    htmlText += "<br/>Name/Short description: " + toolOrEquipment.Name;
                    htmlText += "<br/>";
                    htmlText += "</div>";
                }
                htmlText += "<br/>";
               
                
                if (Session["UserType"].Equals("JobSeeker"))
                {
                    htmlText += "</div><div class='row'>";
                    htmlText += "click <a href='ToolsAndEquipments.aspx'>here </a> to edit your Tools/Equipments.<br/><br/>";
                    htmlText += "</div><br/>";
                }
                display += htmlText;

                //Employment history
                display += "<h3>Prevous employment history</h3>";
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p>View prevous jobs completed by the job seeker including how the the job seeker did on that job based on the ratings provided by prevous Employers.</p><br/>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p>View prevous jobs that you completed including how you did on that job based on the ratings provided by prevous Employers.</p>";
                    display += "<p>Other employers viewing your profile can see your prevous employmeny history, which might be in your favour when Employers are looking for people to hire.</p>";
                    display += "<p>Every time you get employment through InfomalJobFind, that job will be automatically saved in your employment history and your future potential employers can view it.</p>";
                    display += "<p>Simple put, the more Jobs you get the more experienced your profile will look..</p><br/>";
                }
                //for each loop to read from Employment History from the table and siplay it

                DisplayJobSeekerProfile.InnerHtml = display;
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }           
        }
    }
}