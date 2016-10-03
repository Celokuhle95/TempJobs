<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="WebApplication1.Homepage2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
  .jumbotron {
      color:    white;
      padding: 100px 25px;
  }
  .container-fluid {
      padding: 60px 50px;
  }
  .bg-grey {
      background-color: #f6f6f6;
  }
  .logo-small {
      color: orangered;
      font-size: 50px;
  }
  .logo {
      color: mediumpurple;
      font-size: 200px;
  }
  .thumbnail {
      padding: 0 0 15px 0;
      border: none;
      border-radius: 0;
  }

  .HasBackgroundImage{
      background-image: url("images/b5.jpg");
    background-color: #cccccc;
    width: 90%;
  }
  .thumbnail img {
      width: 100%;
      height: 100%;
      margin-bottom: 10px;
  }
  .carousel-control.right, .carousel-control.left {
     background-color:mediumpurple ;
     color: #0ff;
  }
  .carousel-indicators li {
      border-color: #0ff;
  }
  .carousel-indicators li.active {
      background-color: #0ff;
  }
  .item h4 {
      font-size: 19px;
      line-height: 1.375em;
      font-weight: 400;
      font-style: italic;
      margin: 70px 0;
  }
  .item span {
      font-style: normal;
  }
  @media screen and (max-width: 768px) {
    .col-sm-4 {
      text-align: center;
      margin: 25px 0;
    }
  }
  </style>
<br />

<div class="container-fluid jumbotron text-center HasBackgroundImage">
  <h1>Welcome to TEMPJOBS</h1> 
  <p>We specialise in effective job hunting</p> 
  <form class="form-inline">
    <input type="email" class="form-control" size="50" placeholder="Email Address" />
    <button type="button" class="btn btn-danger">Subscribe</button>
  </form>
</div>

    <!-- Container (Portfolio Section) -->
<div class="container-fluid text-center bg-grey">
  <h2>Portfolio</h2><br/>
  <h4>Types of jobs offered</h4>
  <div class="row text-center">
    <div class="col-sm-4">
      <div class="thumbnail">
        <img src="Images/jobs.jpg" alt="could not load image" width="400" height="300"/>
        <p><strong>Work</strong></p>
        <p>Common work to be done</p>
      </div>
    </div>
    <div class="col-sm-4">
      <div class="thumbnail">
        <img src="Images/b2.jpg" alt="Cold not load image" width="400" height="300"/>
         <p>find people in you area who can do the job</p>
      </div>
    </div>
    <div class="col-sm-4">
      <div class="thumbnail">
        <img src="Images/ironing.jpg" alt="could not load image" width="400" height="300"/>
        <p>Have a small job to be done within a short time</p>
      </div>
    </div>
  </div>
    </div>


<!-- Container (Services Section) -->
<div class="container-fluid text-center">
  <h2>SERVICES</h2>
  
  <br/>
  <div class="row">
    
    
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-search logo-small"></span>
      <h4>Search</h4>
      <p>Search and apply</p>
    </div>
     <div class="col-sm-4">
      <span class="glyphicon glyphicon-wrench logo-small"></span>
      <h4>Work</h4>
      <p>Get the job done</p>
    </div>
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-usd logo-small"></span>
      <h4 style="color:#303030;">Money</h4>
      <p>Get paid for the service you provided</p>
    </div>

  </div>
  
</div>



  






    <style>
footer.glyphicon {
    font-size: 20px;
    margin-bottom: 20px;
    color: #0ff;
}
</style>

<footer class="container-fluid text-center">
  <a href="#myPage" title="To Top">
    <span class="glyphicon glyphicon-chevron-up"></span>
  </a>
 
</footer>




</asp:Content>
