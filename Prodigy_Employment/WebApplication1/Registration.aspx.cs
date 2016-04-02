﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        public localhost.Service1 cl; //references the local host
        public bool isUserName; 
        protected void Page_Load(object sender, EventArgs e)
        {
            cl = new localhost.Service1();
            isUserName = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
           //getting the values from the textboxes
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtResAddress.Text;
            string Email = txtEmail.Text;
            string cantactNumbers = txtCellphone.Text;
            string altanativeNumber = txtTelephone.Text;
            string password = txtPassword.Text;
            int authenticationLevel = System.Convert.ToInt32(drpAuthintication.SelectedValue);
           
            if (authenticationLevel.Equals(1) || authenticationLevel.Equals(2))
            {
                if (password == txtConfirmPassword.Text)
                {
                    if (Email == " ")
                    {
                        lblemailError.Text = " Please enter an email";
                        lblError.Visible = true;
                        return;
                    }
                    else {
                        cl.RegistrationDatabase(firstName, lastName, address, Email, cantactNumbers, altanativeNumber,Secrecy.HashPassword( password), authenticationLevel, true);
                        Response.Redirect("LoginPage.aspx");
                    }
                }
                else
                {
                   lblError.Text=" Passwords are not the same";
                   lblError.Visible = true;
                    return;
                }
            }
            else
            {
                lblError.Text = "select an option on the drpdown menu";
                lblError.Visible = true;
                return;
            }
        }

        protected void TextUsername_TextChanged(object sender, EventArgs e)
        {
            bool d, b;
            string email = txtEmail.Text;
            string message = "Username already taken";
            cl.UserNameCheck(email, out d, out b, out message);
            if (d)
            {
                lblemailError.Text = message; //displaying an message
                lblemailError.Visible = true;
                isUserName = true;
                return;
            }
            else
            {
                isUserName = false;
            }

        }

        
    }
}