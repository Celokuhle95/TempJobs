<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="DeleteJob.aspx.cs" Inherits="WebApplication1.DeleteJob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container" style="padding-left:20%; padding-right: 20%">
         <div class ="card" style="padding-left:10%; padding-right:10%;">
             <div class="page-header">
                <h2>Delete  job.</h2>
             </div>                                      
             <p>Are you sure you want to continue?</p>
             <div class="row">
                 <div class="col-md-6" >
                     <asp:Button ID="btnYes" style="width:100%; border-radius:initial" class="btn btn-danger" runat="server" Text="Yes"  OnClick="btnYes_Click" />
                 </div>
                 <div class="col-md-6" >
                     <asp:Button ID="btnNo" class="btn btn-block" style="width:100%; border-radius:initial" runat="server" Text="No" OnClick="btnNo_Click" />
                 </div>
             </div>
            <br />
         </div>
    </div>
</asp:Content>
