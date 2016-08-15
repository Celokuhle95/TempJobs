using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EmployJobSeeker : System.Web.UI.Page
    {
        localhost1.Service1 lc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["UserID"] != null && Session["UserType"] != null)
                {
                    if (((string)Session["UserType"]).Equals("Employer"))
                    {
                        lc = new localhost1.Service1();
                        int JobSeekerID = Convert.ToInt32(Request.QueryString["JobSeekerID"]);

                        //employ also send notification to notify JobSeeker about the employment opportunity.
                        var jobSeeker = lc.SingleJobseeker(JobSeekerID, true);
                        lblContatNumber.Text = jobSeeker.ContactNumber;
                        lblAltContact.Text = jobSeeker.AlternativeContactNumber;
                        lblEmail.Text = jobSeeker.EmailAddress;
                    }
                    else
                    {
                        Response.Redirect("LoginPage.aspx");
                    }
                }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
                
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            ContactDetails.Visible = true;
            btnAccept.Enabled = false;
        }
    }
}