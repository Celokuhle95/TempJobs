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
        public localhost1.Service1 lc;
        int selectedID;
        protected void Page_Load(object sender, EventArgs e)
        {
            lc = new localhost1.Service1();
            
            if (Session["UserID"] == null || (string)Session["UserType"] != "JobSeeker")
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                selectedID = (int)Session["UserID"];
                int count = 0;
                foreach( var skill in lc.ReadSkills(selectedID, true))
                {
                    if (count.Equals(0))
                    {
                        if (skill == null)
                        {
                            drpSkill1.Text = "Select skill";

                        }
                        else
                        {
                            drpSkill1.Text = skill.Name;
                        }
                    }
                    else if(count.Equals(1))
                    {
                        if (skill == null)
                        {
                            drpSkill2.Text = "Select skill";

                        }
                        else
                        {
                            drpSkill2.Text = skill.Name;
                        }
                    }
                    else if (count.Equals(2))
                    {
                        if (skill == null)
                        {
                            drpSkill3.Text = "Select skill";

                        }
                        else
                        {
                            drpSkill3.Text = skill.Name;
                        }
                    }
                    else if (count.Equals(3))
                    {
                        if (skill == null)
                        {
                            drpSkill4.Text = "Select skill";

                        }
                        else
                        {
                            drpSkill4.Text = skill.Name;
                        }
                    }
                    else if (count.Equals(4))
                    {
                        if (skill == null)
                        {
                            drpSkill5.Text = "Select skill";

                        }
                        else
                        {
                            drpSkill5.Text = skill.Name;
                        }
                    }
                }
            }           
        }

        protected void btnStoreDetails_Click(object sender, EventArgs e)
        {
            if (drpSkill1.SelectedValue != null)
            {
                string skill1Name = drpSkill1.SelectedValue;
                lc.StoreSkills(skill1Name, 0, true, selectedID, true);
            }

            if (drpSkill2.SelectedValue != null)
            {
                string skill2Name = drpSkill2.SelectedValue;
                lc.StoreSkills(skill2Name, 0, true, selectedID, true);
            }
            if (drpSkill3.SelectedValue != null)
            {
                string skill3Name = drpSkill3.SelectedValue;
                lc.StoreSkills(skill3Name, 0, true, selectedID, true);
            }
            if (drpSkill4.SelectedValue != null)
            {
                string skill4Name = drpSkill4.SelectedValue;
                lc.StoreSkills(skill4Name, 0, true, selectedID, true);
            }
            if (drpSkill5.SelectedValue != null)
            {
                string skill5Name = drpSkill5.SelectedValue;
                lc.StoreSkills(skill5Name, 0, true, selectedID, true);
            }              
        }
        
        //public bool AlreadySaved(string skillName) //jobseeker cannot register a skill that has already been added
        //{
        //    bool skillAlreadySaved = false;
        //    foreach (var skill in lc.ReadSkills()) //check name and id to check this skill is saved once only
        //    {
        //        if (selectedID == skill.Skill_ID && skill.Name == skillName)
        //        {
        //            skillAlreadySaved = true;
        //        }
        //    }
        //    return skillAlreadySaved;
        //}
    }
}