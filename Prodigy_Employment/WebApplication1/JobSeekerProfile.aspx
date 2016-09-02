<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="JobSeekerProfile.aspx.cs" Inherits="WebApplication1.JobSeekerProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="JobInvite"  runat="server" class="container-fluid affix" visible="false" style="padding-left:85%">      
        <asp:Button ID="btnInvite" runat="server" Text="Invite jobseeker" Style="border-radius:initial" class="btn btn-primary pull-right" OnClick="btnInvite_Click" />
        <%--<input id="btnIn" type="button" value="Invite jobseeker" class="btn btn-primary " style="border-radius:initial" runat="server" onclick="btnInvite_Click"/>--%>
    </div>
    <div id="DisplayJobSeekerProfile" class="container " runat="server">
   
     </div>
    <br />


</asp:Content>
