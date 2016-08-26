<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="DeleteJob.aspx.cs" Inherits="WebApplication1.DeleteJob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container" style="padding-left:20%; padding-right: 20%">
         <div class ="row" style="padding-left:10%; padding-right:10%; border:groove">
             <h2>Delete  job.</h2>
              
             <p>Here you can delete the jobs as an admin.</p>
             <p>Are you sure you want to continue?</p>
             <div class="row">
                 <div class="col-md-3" style ="padding-right: 5%">
                     <asp:Button ID="btnYes" class="btn btn-success" runat="server" Text="Yes" width="100" OnClick="btnYes_Click" />
                 </div>
                 <div class="col-md-3" style="padding-left: 5%; padding-right: 5%">
                     <asp:Button ID="btnNo" class="btn btn- btn-block" runat="server" Text="No" OnClick="btnNo_Click" />
                 </div>
             </div>
            <br />
         </div>
    </div>
</asp:Content>
