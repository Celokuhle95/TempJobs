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
            if (!IsPostBack)
            {
                if (Session["Employee_ID"] == null)
                {
                    Response.Redirect("EmploymentProfilePage.aspx");
                }
                else
                {
                    selectedID = Convert.ToInt32(Session["Employee_ID"]);
                    foreach (var skill in lc.ReadSkills())
                    {
                        if (skill.Employee_Id == Convert.ToInt32(Session["Employee_ID"]))
                        {
                            insertIntoDropdownlist(drpSkill1, skill.Name);
                            insertIntoDropdownlist(drpSkill2, skill.Name);
                            insertIntoDropdownlist(drpSkill3, skill.Name);
                            insertIntoDropdownlist(drpSkill4, skill.Name);
                            insertIntoDropdownlist(drpSkill5, skill.Name);
                        }

                    }
                }
            }

        }
        public void insertIntoDropdownlist(DropDownList drp, string item)
        {
            if (item.Equals("Plumber"))
                drp.SelectedValue = "1";
            if (item.Equals("Gardner"))
                drp.SelectedValue = "2";
            if (item.Equals("Grasscutter"))
                drp.SelectedValue = "3";
            if (item.Equals("Tree Cutting"))
                drp.SelectedValue = "4";
            if (item.Equals("Garbage disposal"))
                drp.SelectedValue = "5";
            if (item.Equals("Painter"))
                drp.SelectedValue = "6";
            if (item.Equals("Ironing"))
                drp.SelectedValue = "7";
            if (item.Equals("Washing"))
                drp.SelectedValue = "8";
            if (item.Equals("Cooking"))
                drp.SelectedValue = "9";
            else
                drp.SelectedValue = "0";

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

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmploymentProfilePage.aspx");
        }
    }
}