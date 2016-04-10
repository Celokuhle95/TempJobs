<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="WebApplication1.Homepage2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
  .jumbotron {
      background-color: lightgrey;
      color:  cornflowerblue;
      padding: 100px 25px;
  }
  .container-fluid {
      padding: 60px 50px;
  }
  .bg-grey {
      background-color: #f6f6f6;
  }
  .logo-small {
      color: #0ff;
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

<div class="container-fluid jumbotron text-center">
  <h1>TempJobs</h1> 
  <p>We specialise in effective job hunting</p> 
  <form class="form-inline">
    <input type="email" class="form-control" size="50" placeholder="Email Address" required>
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
        <img src="Images/ironing.jpg" alt="Cold not load image" width="400" height="300"/>
         <p>find people in you area who can do the job</p>
      </div>
    </div>
    <div class="col-sm-4">
      <div class="thumbnail">
        <img src="Images/cuttinggrass.jpg" alt="could not load image" width="400" height="300"/>
        <p>Have a small job to be done within a short time</p>
      </div>
    </div>
  </div>



<!-- Container (Services Section) -->
<div class="container-fluid text-center">
  <h2>SERVICES</h2>
  
  <br/>
  <div class="row">
    
    
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-lock logo-small"></span>
      <h4>JOB DONE</h4>
      <p>reliable web service for job hunting</p>
    </div>
     <div class="col-sm-4">
      <span class="glyphicon glyphicon-certificate logo-small"></span>
      <h4>CERTIFIED</h4>
      <p>We offer the best services</p>
    </div>
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-wrench logo-small"></span>
      <h4 style="color:#303030;">HARD WORK</h4>
      <p>Trusted employees to do a job well done</p>
    </div>

  </div>
  
</div>



  <h2>Service Review</h2>
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
        <h4>"job hunting made easier"<br/><span style="font-style:normal;">comment section</span></h4>
      </div>
      <div class="item">
        <h4>"Really pleased with the services offered!"<br><span style="font-style:normal;"></span></h4>
      </div>
      <div class="item">
        <h4>""<br/><span style="font-style:normal;"></span></h4>
      </div>
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
