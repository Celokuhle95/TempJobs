<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Slide.aspx.cs" Inherits="Prodigy_Employment.Slide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <a class="btn btn-primary btn-block" href="Homepage.aspx">Browse</a><br />

    <div id="myslide" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#myslide" data-slide-to="0" class="active"></li>
            <li data-target="#myslide" data-slide-to="1" ></li>
             <li data-target="#myslide" data-slide-to="2" ></li>
             <li data-target="#myslide" data-slide-to="3" ></li>
             <li data-target="#myslide" data-slide-to="4" ></li>

        </ol>
         <div class="carousel-inner" role="listbox">
             <div class="item active" >
             <img src="Images/jobs.jpg" height="400" width="1400">
                 <div class="carousel-caption">

                     <h1 style="color:black">Effective Job hunting</h1>
                     <p style="color:black" >Find employment effectively and easily by looking through our list of available jobs</p>
                    

                 </div>

             </div>

             <div class="item">
                 <img src="Images/clean.jpg" height="400" width="1400" alt="jozi">

                 <div class="carousel-caption">  66
             </div>

             <div class="item">
                 <img src="Images/m.jpg" height="400" width="1400" alt="jozi">
                 <div class="carousel-caption">

                    
                 </div>
             </div>


         </div>

        <a class="left carousel-control" href="myslide" role="button" data-slide="prev">
            <span class="glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Back</span>
        </a>

        <a class="right carousel-control" href="myslide" role="button" data-slide="next">
            <span class="glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>

    </div>
    
   <%-- <a href="Homepage.aspx"> Explore!!!</a>--%>

    </div>
</asp:Content>
