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
        localhost.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {
            lc = new localhost.Service1();
         
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
                //ClientScript.RegisterStartupScript(this.GetType(), "myAlert", "alert('" + JobSeekerID + "');", true);

                var jobSeeker = lc.SingleJobseeker(JobSeekerID, true);
                string display = "";
                display += "<div class='page-header'>";
                     display += "<h1>Jobseeker profile</h1>";
                       
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p class='text-muted'>Here you can  view JobSeeker's full details including their identitification and contact details.";
                    display += "You can also view the informal skills of the Job seeker, including the list of previous jobs completed by the Job seeker and your tools and equipment that you use.</p>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p class='text-muted'>View your personal details and contact details here.";
                    display += "You can also view your informal skills, including the list of previous jobs that you have completed.</p>";
                }
                display += "</div>";
                display += "<div class='row'>";
                display += "<div class='col-md-5'>";
                display += "<div class='card'>";
                display += "<h3 class='card-header'>Job seeker details</h3>";
                string base64ImageRepresentation = jobSeeker.ProfileImage_String;
                display += "<img class='img-responsive img-fluid' alt='image not available' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";                
                display += "<ul class='list-group list-group-flush'>";
                display += "<li class='list-group-item'> <b class='text-muted'>First name</b>     : " + jobSeeker.FirstName + "</li>";
                display += "<li class='list-group-item'> <b class='text-muted'>Last name</b>     : " + jobSeeker.LastName + "</li>";
                display += "<li class='list-group-item'> <b class='text-muted'>Residential address</b>     : " + jobSeeker.ResidentialAddress + "</li>";
                display += "</ul>";
                display += "</div>";

                if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<div class='card card-primary'>";
                    display += "<div class='card-block'>";
                    display += "<h3 class='card-title'>Contact Details</h3>";
                    display += "<p class='card-subtitle text-muted'>Employers will use these contact details to cantact you whenever your application is successful.</p>";
                    display += "</div>";
                    display += "<ul class='list-group list-group-flush'>";
                    display += "<li class='list-group-item'> <b class='text-muted'>Contact number:</b>     : " + jobSeeker.ContactNumber + "</li>";
                    display += "<li class='list-group-item'> <b class='text-muted'>Alternative contact number:</b>     : " + jobSeeker.AlternativeContactNumber + "</li>";
                    display += "<li class='list-group-item'> <b class='text-muted'>Email Address:</b>     : " + jobSeeker.EmailAddress + "</li>";
                    display += "</ul>";
                    display += "</div>";
                }

                display += "<div style='border:thin; padding: 2px'>";
                display += "<h3> Job seeker skills. </h3>";
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p class='text-muted'>This section contains the job seeker's informal skills that the job seeker has.";
                    display += "Job seekers may have more than one informal skills, depending on the number of jobs that they have preveous done, and continue to do, in their space. </p>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p class='text-muted'>This section contains  informal skills that you have.";
                    display += "Job seekers may have more than one informal skills, depending on the number of jobs that they have preveous done, and continue to do, in their space. ";
                    display += "Click <a href='Skills.aspx'>here </a> to edit your skills.</p>";
                }
                ////if ((lc.ReadSkills(JobSeekerID, true) == null))
                ////{
                //    display += "<p>NO SKILLS TO DISPLAY AT THE MOMENT.</p>";
                //}  
                //display += "<div class='card-deck'>";
                display += "<div class='card-group'>";
                foreach (var skill in lc.ReadSkills(JobSeekerID, true))
                {
                    
                    display += "<div class='card'>";                   
                    display += "<h5 class='card-header'>" + skill.Name +"</h5>";
                    display += "<div class='card-block'>";
                    display += "<p class='card-text'><b class='text-muted'>Level:</b>" + skill.SkillLevel+ "</p>";
                    display += "</div>";
                    display += "</div>";                  
                }
                //display += "</div>";
                display += "</div>";
                display += "</div>";
                display += "</div>";

                display += "<div class='col-md-7'>";
                //Tools and equipment    
                display += "<div style='border:thin; padding: 2px'>";
                display += "<h3 text-center> Tools/equipments. </h3>";               
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p class='text-muted '>Tools/Equipment are any resources that jobseeker have and use when doing a job that they have skills in. ";
                    display += "You can, as an employer, provide your own tools or equipment if you prefer. Note that";
                    display += "some jobs may not neccessary require job seeker owned tools or equipment.</p>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p class=' text-muted'>Here you can upload the picture of the tools or equipment that you use when doing the jobs you skilled in. ";
                    display += "This may be a romoval bakkie if you do refuse removal, a grass cutting machine if you do grass cutting, a tree cutting machine if you do tree felling, or any tools that are essential to your job.";
                    display += "You can upload upto 5 tools or any equipment that you use and want Employers to see to better your employment chances.";
                    display += "Yo can howover upload less than five images if you don't use that much tools or equipments. It is noted that some informal jobs do not require tools or equipment of your own to complete.";
                    display += "So in this case you can choose not to upload any photos. Also note that some Employers may have their own tools and equipment which you can use aswell.";
                    display += "Click <a href='ToolsAndEquipments.aspx'>here </a> to edit your Tools/Equipments.</p>";
                }
                display += "<div class='card-group'>";
                //display += "<div class='card-deck'>";
                foreach (var toolOrEquipment in lc.GetToolsAndEquipments(JobSeekerID, true))
                {
                    display += "<div class='card text-xs-center'>";
                    display += "<img alt='No image to display' style='max-height:200px; max-wudth: 210px;' class='img-responsive img-fluid card-img-top' src='data:image/jpeg;base64," + toolOrEquipment.Image + "'/><br/>";
                    display += "<div class='card-block'>";
                    display += "<h4 class='card-title'>" + toolOrEquipment.Name+ "</h4>";
                    display += "</div>";
                    display += "</div>";
                }
                //display += "</div>";
                display += "</div>";
                display += "</div>";
                display += "<br/>";
                //Employment history
                display += "<div class='card card-warning'>";
                display += "<div class='card-block'>";
                display += "<h3 class='card-title'>Previous employment history.</h3>";
                if (Session["UserType"].Equals("Employer"))
                {
                    display += "<p class='card-text text-muted'>View previous jobs completed by the job seeker including how the the job seeker did on that job based on the ratings provided by prevous Employers.</p>";
                }
                else if (Session["UserType"].Equals("JobSeeker"))
                {
                    display += "<p class='card-text text-muted'>View prevous jobs that you completed including how you did on that job based on the ratings provided by prevous Employers.";
                    display += "Other employers viewing your profile can see your prevous employmeny history, which might be in your favour when Employers are looking for people to hire.";
                    display += "Every time you get employment through InfomalJobFind, that job will be automatically saved in your employment history and your future potential employers can view it.";
                    display += "Simple put, the more Jobs you get the more experienced your profile will look.</p>";
                }
                display += "</div>";
                //for each loop to read from Employment History from the table and siplay it
                display += "<div class='card-block'>";
                display += "<p class='card-text'>No employment history currently available.</p>";
                display += "</div>";
                display += "</div>";
                display += "</div>";
                display += "</div>";

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
            Session.Add("JobSeekerID", JobSeekerID);
            Response.Redirect("JobToInviteFor.aspx");            
        }    
    }
}