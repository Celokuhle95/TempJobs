<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ConfirmJobApplication.aspx.cs" Inherits="WebApplication1.ConfirmJobApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left:20%; padding-right: 20%">
         <div class ="card" style="padding-left:10%; padding-right:10%;">
             <div class="page-header">
                  <h2>Confirm job application.</h2>
             </div>
                       
             <p class="text-muted">If you apply for this job opportunity it means you allow us to share some of your non security information with the potential employer, such as contact numbers, so that they can contact you.</p>
             <p>Are you sure you want to continue?</p>
             <div class="row">
                 <div class="col-md-6">
                     <asp:Button ID="btnYes" class="btn btn-success" style="width:100%;border-radius:initial" runat="server" Text="Yes" width="100" OnClick="btnYes_Click" />
                 </div>
                 <div class="col-md-6">
                     <asp:Button ID="btnNo" class="btn btn-block" style="width:100%;border-radius:initial" runat="server" Text="No" OnClick="btnNo_Click" />
                 </div>
             </div>
            <br />
         </div>
    </div>
</asp:Content>
