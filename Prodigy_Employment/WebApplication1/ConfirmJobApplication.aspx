<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ConfirmJobApplication.aspx.cs" Inherits="WebApplication1.ConfirmJobApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left:20%; padding-right: 20%">
         <div class ="row" style="padding-left:10%; padding-right:10%; border:groove">
             <h3>Apply for job.</h3>
              <hr id="Hr1" style="color: #808080, #C2C2C2" runat ="server"  /> 
             <p>If you apply for this job opportunity it means you allow us to share some of your non security information with the potential employer, such as contact numbers, so that they can contact you.</p>
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
