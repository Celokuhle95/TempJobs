using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserID"] = null;
            Session["UserType"] = null;
            if(Session["JobSeekerID"] != null)
            {
                Session["JobSeekerID"] = null;
            }
            Session["JobSeekerID"] = null;
            if(Session["RequiredSkill"] != null)
            {
                Session["RequiredSkill"] = null;
            }          
            Response.Redirect("home.aspx");
        }
    }
}