using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EditProfile : System.Web.UI.Page
    {
        public localhost.Service1 lc;
        int selectedID;
        protected void Page_Load(object sender, EventArgs e)
        {
            lc = new localhost.Service1();
            string htmlText = "";
            selectedID = (int)Session["id"];
           
            
            var user = lc.SingleUserDetails(selectedID, true);
           
            htmlText += "<div class='row'>";
            htmlText += "<div class ='col-md-3'>";

            string base64ImageRepresentation = user.ProfileImage_String;
            htmlText += "<img width='100%' height='250px'class='img-thumbnail' alt='image not available' src='data:image/jpeg;base64," + base64ImageRepresentation + "'/>";
            htmlText += "</div>";
            htmlText += "<div class='col-md-6'>";
            htmlText += "<table class='table'>";
            htmlText += "<tbody>";
            htmlText += "<tr><td><b>First name:</b></td><td>" + user.firstName + "</td></tr>";
            htmlText += "<tr><td><b>Last name:</b></td><td>" + user.lastName + "</td></tr>";
            htmlText += "<tr><td><b>Email address:</b></td><td>" + user.Email + "</td></tr>";
            htmlText += "<tr><td><b>Residential address:</b></td><td>" + user.address + "</td></tr>";
            htmlText += "<tr><td><b>Contact number:</b></td><td>" + user.contactNumber + "</td></tr>";
            htmlText += "<tr><td><b>Alternative contact number:</b></td><td>" + user.alternativeNumber + "</td></tr>";
            htmlText += "<tr><td><b>Skills:</b></td><td>plumber, grass cutting, watering the garden, painter</td></tr>";
            htmlText += "<tr><td><b>Employment profile:</b></td><td><a href='EmploymentProfilePage.aspx.?UserID=" + user.Id + "'><b style='color:olive'>View</b></a>" + "</td></tr>";
            htmlText += "<tr><td><b>Have a Job to be done?:</b></td><td><a href='EmploymentProfilePage.aspx'><b style='color:olive'>Employ</b></a></td></tr>";
            htmlText += "</tbody>";
            htmlText += "</table>";
            htmlText += "</div>";
            htmlText += "</div>";
           // ProfileInfo.InnerHtml = htmlText;
        }

        protected void btnStoreDetails_Click(object sender, EventArgs e)
        {
            string skill1Name = drpSkill1.SelectedValue;
            if(!AlreadySaved(skill1Name))
            {
                lc.StoreSkills(skill1Name, selectedID, true);
            }

            string skill2Name = drpSkill2.SelectedValue;
            if (!AlreadySaved(skill2Name))
            {
                lc.StoreSkills(skill2Name, selectedID, true);
            }

            string skill3Name = drpSkill3.SelectedValue;
            if (!AlreadySaved(skill3Name))
            {
                lc.StoreSkills(skill3Name, selectedID, true);
            }

            string skill4Name = drpSkill4.SelectedValue;
            if (!AlreadySaved(skill4Name))
            {
                lc.StoreSkills(skill4Name, selectedID, true);
            }

            string skill5Name = drpSkill5.SelectedValue;
            if (!AlreadySaved(skill5Name))
            {
                lc.StoreSkills(skill5Name, selectedID, true);
            }
        }
      
        public bool AlreadySaved(string skillName) //employee cannot register a skill that has already been added
        {
            bool skillAlreadySaved = false;
            foreach (var skill in lc.ReadSkills()) //check name and id to check this skill is saved once only
            {
                if (selectedID == skill.Skill_ID && skill.Name == skillName)
                {
                    skillAlreadySaved = true;
                }
            }
            return skillAlreadySaved;
        }
    }
}