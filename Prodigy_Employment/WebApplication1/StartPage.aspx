<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="Prodigy_Employment.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container-fluid ">
             <h2>Get a job done</h2>
        <div id="myCarousel" class="carousel slide text-center" data-ride="carousel">
          <!-- Indicators -->
          <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
   
          </ol>

          <!-- Wrapper for slides -->
          <div class="carousel-inner" role="listbox">
            <div class="item active">
                 <img src="Images/jobs.jpg" height="400" width="1400"/>
            <h3>"Effective Job hunting!"<br/><span style="font-style:normal;"></span></h3>
            </div>


            <div class="item">
                 <img src="Images/ironing.jpg" height="400" width="1400"/>
                 
              <h3>"Do you have work that needs to be done?!"<br/><span style="font-style:normal;"></span></h3>
            </div>


            <div class="item active">
                <img src="Images/planting.jpeg" height="400" width="1400"/>
              <h3>"Find employment effectively and easily by looking through our list of available jobs"<br><span style="font-style:normal;"></span></h3>
            </div>
 

          <!-- Left and right controls -->
          <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
          </a>
          <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
          </a>
        </div>
        </div>

        <br />
          <div class="jumbotron text-center">
          <h1>Go to site...</h1> 
          <form class="form-inline">
              <asp:LinkButton ID="btnGoToSite" href="Homepage.aspx" class="btn btn-success" runat="server">Click here</asp:LinkButton>
          </form>
        </div>
    </div>

</asp:Content>
