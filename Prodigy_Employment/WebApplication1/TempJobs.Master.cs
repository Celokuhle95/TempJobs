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
        WebApplication1.localhost.Service1 lc = new WebApplication1.localhost.Service1();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["id"] != null)
            {
                int userID = (int)Session["id"];
                string usertype = (string)Session["UserType"];
                if (usertype.Equals("Employer"))
                {
                    lblPostJob.Visible = true;
                    lblViewJobseekers.Visible = true;
                }
                else if (usertype.Equals("JobSeeker"))
                {
                    lblViewJobs.Visible = true;
                }

                lblLogin.Visible = false;
                lblRes.Visible = false;
                lblLogout.Visible = true;
                lblProfile.Visible = true;

                //if (Session["SkillCompleted"] == null)
                //{
                //    CompleteProfile.Visible = true;
                //}

                //if (skillsCompleted(userID).Equals(false))
                //{
                //    CompleteProfile.Visible = true;
                //}
            }


            //string html = "";      
            //foreach (var skill in lc.ReadSkills())
            //{
            //    if(skill.Skill_ID.Equals(0))
            //    {
            //        html += "empty";
            //    }
            //    if (skill.Name.Equals(" "))
            //    {
            //        html += "empty1";
            //    }
            //    if (skill == " ")
            //    {
            //        html += "empty2";
            //    }

            //        html += skill;

            //}

            //Div1.InnerHtml = html;
        }

        public bool skillsCompleted(int userID)
        {
            Boolean skillsAdded = true;
            foreach (var skill in lc.ReadSkills())
            {
                if (userID.Equals(skill.Employee_Id)) //user has filled and saved the skills he has
                {
                    skillsAdded = true;
                }
                else
                {
                    skillsAdded = false;
                }
            }
            return skillsAdded;
        }
    }
}