using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class profileEmployment : System.Web.UI.Page
    {
        localhost.Service1 lc = new localhost.Service1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id"] != null)
                {
                    foreach (var employees in lc.ReadEmployees())
                    {
                        if (employees.UserData_ID == Convert.ToInt32(Session["id"]))
                        {
                            if (employees.Employment_status.Equals("Employed"))
                                drpStatus.SelectedValue = "True";
                            
                                drpStatus.SelectedValue = "False";
                            txtmin.Text = employees.wage_Min.ToString();
                            txtmax.Text = employees.wage_max.ToString();
                            if (employees.prefered_hours.Equals("03H00 - 11H00"))
                                drpHour.SelectedValue = "a";
                            if (employees.prefered_hours.Equals("05H00 - 13H00"))
                                drpHour.SelectedValue = "b";
                            if (employees.prefered_hours.Equals("08H00 - 16H00"))
                                drpHour.SelectedValue = "c";
                            if (employees.prefered_hours.Equals("20H00 - 04H00"))
                                drpHour.SelectedValue = "d";
                            if (employees.isAvailable.Equals("Yes"))
                                drpAvailability.SelectedValue = "Yes";
                            if (employees.isAvailable.Equals("No"))
                                drpAvailability.SelectedValue = "No";
                            employees.UserData_ID = Convert.ToInt32(Session["id"]);
                        }
                    }
                }else
                    Response.Redirect("LoginPage.aspx");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
           // lblError.Text = "Clicked button";
            
            if (Session["id"] != null)
            {
                string available, status, hours;
                if (drpStatus.SelectedValue.Equals("True"))
                {
                    status = "Employed";
                }
                else
                    status = "unEmployed";

                if (drpStatus.SelectedValue.Equals("a"))
                {
                    hours = "03H00 - 11H00";
                    
                }
                else if (drpStatus.SelectedValue.Equals("b"))
                {
                    hours = "05H00 - 13H00";
                }
                else if (drpStatus.SelectedValue.Equals("c"))
                {
                    hours = "08H00 - 16H00";
                }
                else
                {
                    hours = "20H00 - 04H00";
                }

                if (drpAvailability.SelectedValue.Equals("Yes"))
                {
                    available = "Yes";
                }else
                {
                    available = "No";
                }
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('"+ hours+ "');", true);
                if (Session["Employee_ID"] == null)
                {
                   
                    lc.storeEmployees(status, Convert.ToInt32(txtmin.Text), true, Convert.ToInt32(txtmax.Text), true, hours, available, Convert.ToInt32(Session["id"]), true);
                    int Employee_ID;
                    bool idSpecified;
                    lc.getEmployee_id(Convert.ToInt32(Session["id"]), true, out Employee_ID, out idSpecified);
                    if (idSpecified)
                    {
                        if (Employee_ID != -1)
                        {
                            Session.Add("Employee_ID", Employee_ID);
                            Response.Redirect("EditSkills.aspx");
                        }
                    }
                }
                else
                {
                    foreach (var employees in lc.ReadEmployees())
                    {
                        if (employees.Employee_Id ==Convert.ToInt32( Session["Employee_ID"]))
                        {
                            lc.storeEmployeesUpdates(status, Convert.ToInt32(txtmin.Text), true, Convert.ToInt32(txtmax.Text), true, hours, available, Convert.ToInt32(Session["id"]), true);
                            Response.Redirect("EditSkills.aspx");
                        }
                    }  
                }
                
            }
            else
                Response.Redirect("LoginPage.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

    }
}