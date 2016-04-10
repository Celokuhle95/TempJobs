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
                int userID = Convert.ToInt32(Request.QueryString["id"]);
                lblLogin.Visible = false;
                lblRes.Visible = false;
                lblLogout.Visible = true;
                lblProfile.Visible = true;

               
                if (skillsCompleted(userID).Equals(false))
                {
                    CompleteProfile.Visible = true;
                }
            }
        }

         public bool skillsCompleted(int userID)
         {
             Boolean skillsAdded = true;
             foreach (var skill in lc.ReadSkills())
             {
                 if (userID.Equals(skill.UserData_ID)) //user has filled and saved the skills he has
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