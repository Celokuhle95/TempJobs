using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewInvites : System.Web.UI.Page
    {      
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.Service1 localhost;
            if (Session["UserID"] != null && Session["UserType"] != null)
            {
                if (((string)Session["UserType"]).Equals("JobSeeker"))
                {
                    localhost = new localhost.Service1();
                    int JobSeekerID = (int)Session["UserID"];

                    string htmlText ="";
                    foreach (var job in localhost.GetJobSeekerJobInvites(JobSeekerID, true))
                    {
                        htmlText += "<div class='card'>";
                        htmlText += "<div class='card-block' style='border-bottom:1px solid'>";
                        htmlText += "<h4 class='card-title text-center'> Job invitation from " + job.EmployerFirstName + " " + job.EmployerLastName + ".</h4>";
                        htmlText += "</div>";

                        string base64ImageRepresentation = job.EmployerImage;
                        htmlText += "<div class='avatar panel-heading'>";
                        htmlText += "<img class='img-circle img-fluid img-responsive' style='height:200px'  src='data:image/jpeg;base64," + base64ImageRepresentation + "' />";
                        htmlText += "</div>";
                       
                        htmlText += "<ul class='list-group list-group-flush'>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>posted:</b>" + job.DatePosted + "</small></li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Job name: </b>" + job.Name + "</small></li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Short description:</b>" + job.Description + "</small> </li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Required skill: </b>" + job.RequiredSkill + "</small></li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Location:</b> " + job.Location + "</small></li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Number of working days:</b> " + job.NumberOfDays + "</small></li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Start date:</b> " + job.StartDate + "</small></li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Daily starting time:</b>" + job.StartTime + "</small> </li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Daily knockoff time:</b> " + job.EndTime + "</small></li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>This job pays:</b> R" + job.ToBePaid + " after competion</small></li>";
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'><small class='text-muted'><b>Apply before:</b>" + job.DueDate + "</small> </li>";
                        string s = string.Format("<a class='btn btn-primary' style='border-radius:initial' href='ConfirmJobApplication.aspx?JobID={0}'>Apply</a></br>", job.JobID);
                        htmlText += "<li  class='list-group-item' style='border-radius:initial'>" + s + "</li>";
                        htmlText += " </ul>";
                        htmlText += "</div><br/>";
                    }
                 
                    Invites.InnerHtml = htmlText;
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
}