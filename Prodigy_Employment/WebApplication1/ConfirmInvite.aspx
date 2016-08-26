<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ConfirmInvite.aspx.cs" Inherits="WebApplication1.ConfirmInvite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Confirm Invite.</h2>
        <br />
        <p>To confirm that you want to invite this job seeker to view a selected posted job click the confirm button below.</p>
        <div class="row">
            <div class="col-lg-4">
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
            </div>
               <div class="col-lg-4">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
        </div>
    </div>
</asp:Content>
