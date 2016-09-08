<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ViewInvites.aspx.cs" Inherits="WebApplication1.ViewInvites" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" runat="server">
        <div class='page-header'>
            <h1>Job invites.</h1>
            <p class='text-muted'>Job invites are a way employers try to get you to apply for their job that they have posted. Invites means the employer, after viewing your profile, felt that you have the right skills and equipment to complete this job. So if you choose to apply for this job your chances of getting employment are really high.</p>
        </div>
    </div>
    <div id="Invites" class="container" runat="server" style="padding-left:10%; padding-right:54%">
    </div>
</asp:Content>
