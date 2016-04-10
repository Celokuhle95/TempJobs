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
        int selectedID = 0; //must change to a correct value
        protected void Page_Load(object sender, EventArgs e)
        {
            lc = new localhost.Service1();
            string htmlText = "";
            foreach (var user in lc.ReadEmployees())
            {
                if (user.Id == selectedID)
                {
                    htmlText += "<div class='row'>";
                    htmlText += "<div class ='col-md-3'>";
                    htmlText += "<img width='100%' height='100px' src='images/cuttinggrass.jpg'>"; //must change image source to the real profile image
                    htmlText += "</div>";
                    htmlText += "<div class='col-md-5'>";
                    htmlText += "<table class='table'>";
                    htmlText += "<tbody>";
                    htmlText += "<tr><td>" + user.firstName + "</td><td>" + user.lastName + "</td></tr><br/>";
                    htmlText += "<tr><td>Email address:</td><td>" + user.Email + "</td></tr><br/>";
                    htmlText += "<tr><td>Residential address:</td><td>" + user.address + "</td></tr><br/>";
                    htmlText += "<tr><td>Contact number:</td><td>" + user.contactNumber + "</td></tr><br/>";
                    htmlText += "<tr><td>Alternative contact number:</td><td>" + user.alternativeNumber + "</td></tr><br/>";
                    htmlText += "</tbody>";
                    htmlText += "</table>";
                    htmlText += "</div>";
                    htmlText += "</div>";
                }
                ProfileInfo.InnerHtml = htmlText;
            }

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