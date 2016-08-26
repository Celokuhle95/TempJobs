<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="JobSeekerProfile.aspx.cs" Inherits="WebApplication1.JobSeekerProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="DisplayJobSeekerProfile" class="container" runat="server">

    </div>
    <br />
    <div id="JobInvite" class="container" runat="server" visible="false">
        <h2>Interested?</h2>
        <p>If you like this Job Seeker and you have an job currently posted, that you wish want this job seeker to apply for, invite the job seeker to apply for this job by clicking the button below.</p>
        <asp:Button ID="btnInvite" runat="server" Text="Invite" style="width:20%" class="btn btn-primary" OnClick="btnInvite_Click" />
    </div>
    
</asp:Content>
