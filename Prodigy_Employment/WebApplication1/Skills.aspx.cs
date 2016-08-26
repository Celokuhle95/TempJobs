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
        localhost.Service1 lc;
        int selectedID;
        protected void Page_Load(object sender, EventArgs e)
        {
            lc = new localhost.Service1();

            if (Session["UserID"] == null || (string)Session["UserType"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                if (((string)Session["UserType"]).Equals("JobSeeker"))
                {
                    selectedID = (int)Session["UserID"];
                    int count = 0;
                    bool a = true;
                    foreach (var skill in lc.ReadSkills(selectedID,  a))
                    {
                        if (count.Equals(0))
                        {
                            if (skill != null)
                            {
                                drpSkill1.Text = skill.Name;
                            }
                        }
                        else if (count.Equals(1))
                        {
                            if (skill != null)
                            {
                                drpSkill2.Text = skill.Name;
                            }
                        }
                        else if (count.Equals(2))
                        {
                            if (skill != null)
                            {
                                drpSkill3.Text = skill.Name;
                            }
                        }
                        else if (count.Equals(3))
                        {
                            if (skill != null)
                            {
                                drpSkill4.Text = skill.Name;
                            }
                        }
                        else if (count.Equals(4))
                        {
                            if (skill != null)
                            {
                                drpSkill5.Text = skill.Name;
                            }
                        }
                        count++;
                    }                
            
                }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
        }

        protected void btnStoreDetails_Click(object sender, EventArgs e)
        {
            if (!drpSkill1.SelectedValue.Equals(0))
            {
                string skill1Name = drpSkill1.Text;
                lc.StoreSkills(skill1Name, 0, true, selectedID, true);              
                //show success message
                DisplaySuccessMessage();            
            }

            if (!drpSkill2.SelectedValue.Equals(0))
            {
                string skill2Name = drpSkill2.Text;
                lc.StoreSkills(skill2Name, 0, true, selectedID, true);
                DisplaySuccessMessage();
            }
            if (!drpSkill3.SelectedValue.Equals(0))
            {
                string skill3Name = drpSkill3.Text;
                lc.StoreSkills(skill3Name, 0, true, selectedID, true);
                DisplaySuccessMessage();
            }
            if (!drpSkill4.SelectedValue.Equals(0))
            {
                string skill4Name = drpSkill4.Text;
                lc.StoreSkills(skill4Name, 0, true, selectedID, true);
                DisplaySuccessMessage();
            }
            if (!drpSkill5.SelectedValue.Equals(0))
            {
                string skill5Name = drpSkill5.Text;
                lc.StoreSkills(skill5Name, 0, true, selectedID, true);
                DisplaySuccessMessage();
            }

            Response.Redirect("JobSeekerProfile.aspx");
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

        public void DisplaySuccessMessage()
        {
            if (Session["ScreenNotification"] == null)
            {
                Session.Add("ScreenNotification", "TurnON");
                Session.Add("ScreenNotificationMessage", "<p>Changes to your skills were successfully saved.</p>");
            }
        }
    }
}