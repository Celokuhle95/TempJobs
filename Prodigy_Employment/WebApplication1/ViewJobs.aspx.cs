using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ViewJobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string htmlText = "";
            localhost.Service1 localhost = new localhost.Service1();
            foreach(var job in localhost.ListOfJobs())
            {
                htmlText += "<div class='row' class='container-fluid' style='background-color:darkkhaki'>";
                htmlText += "<h2>"+job.Name+"</h2>";
                htmlText += "<hr style='color:goldenrod'/>";
                htmlText += "<u>Description: </u>"+ job.Description + "<br/>";
                htmlText += "<u>Location: </u>" + job.Location + "<br/>";
                htmlText += "<u>Duration(in hours): </u>" + job.Duration_Hours + " hours <br/>";
                htmlText += "<u>Reward: </u>R<b>" + job.Reward + "</b><br/>";
                htmlText += "</div><br/>";
            }
            JobDetails.InnerHtml = htmlText;
        }
    }
}