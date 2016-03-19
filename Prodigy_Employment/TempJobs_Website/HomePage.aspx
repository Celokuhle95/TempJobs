<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication1.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div id ="HomePageItem1" style="width:100%; height:700px; background-color:azure; text-align: center">
            <br />
            <div class="row">
                <div class="col-md-6">
                     <img src="images/cuttinggrass.jpg" class="img-responsive img-circle" style="width:85%;height:75%; margin-left: auto; margin-right:auto" />
                </div>
                <div class="col-md-6">
                     <img src="images/planting.jpeg"  class="img-responsive img-circle" style="width:85%; height:75%; margin-left: auto; margin-right:auto" />
                </div>                
            </div>
            <div class="row">
                <h2 style="color: olive">Have a small job to be done within a short time, find people in you area who can do the job.</h2>
            </div>          
        </div>

        <div id="HomePageItem2" style="width:100%; height:700px; background-color: #EEE8AA ; text-align: center">
           <br />
             <div class="row">
                 <div class="col-md-6">
                     <img src="images/ironing.jpg" class="img-responsive img-circle" style="width:85%;height:75%; margin-left: auto; margin-right:auto" />
                </div>
                <div class="col-md-6">
                     <img src="images/jobs.jpg" class="img-responsive img-circle" style=" margin-left: auto; margin-right:auto;width:85%;height:75%"  />
                </div>      
            </div>
            <div class="row">
                  <h2 style="color: olive">Employers.</h2>
                  <h3 style="color: olive">View profiles of job seekers with the different informal skills around your area.</h3>
                  <h3 style="color: olive">Or post a job and later view profiles of job seekers interested in the job.</h3>
            </div>
        </div>
          <div id="HomePageItem3" style="width:100%; height:700px; background-color:wheat ; text-align: center">
            <br />
              <div class="row">
                 <div class="col-md-6">
                     <img src="images/plastering.jpg" class="img-responsive img-circle" style="width:85%;height:75%; margin-left:auto; margin-right:auto" />             
                </div>
                <div class="col-md-6">
                     <img src="images/dogwalking.jpg" class="img-responsive img-circle" style="width:85%;height:75%; margin-left:auto; margin-right:auto" />
                </div>      
            </div>
              <div class="row">
                    <h2 style="color: olive">Job seekers.</h2>
                  <h3 style="color: olive">Can register and have their profiles viewed by a number of employers.</h3>
                  <h3 style="color: olive">And get notified when they are selected for a job.</h3>
                  <h3 style="color: olive"1> And have previous emplyments saved to your profile automatically.</h3>
              </div>
        </div>
    </div>
</asp:Content>
