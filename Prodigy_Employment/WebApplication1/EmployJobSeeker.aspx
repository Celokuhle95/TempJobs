<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="EmployJobSeeker.aspx.cs" Inherits="WebApplication1.EmployJobSeeker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" runat="server">
        <h2>JobSeeker Employment.</h2>
        <p>Here you can choose to contact the Job Seeker for the employment. You can then discuss further the details of this employment
            and agree to them with the Job Seeker. 
        </p><br />
        <h3>Please be aware of these points and try to stick to them for this employment.</h3>
        <ul>
            <li>Keep the details of the job as they were when the job seeker applied, especially the pay, unless you want to pay the Job Seeker more than stated in the job.</li>
            <li>Treat the Job Seeker with respect and keep to the neccessary labour laws.</li>
            <li>Ensure that Job Seeker does not work for more hours than prevoiusly stated in the job post</li>
            <li>If the Job Seeker ends up doing more jobs for you, they must be paid for that extra time they worked</li>
            <li>If you make promises to the Job Seeker, stick to them i.e promising Job Seekers to fetch them or drop them off if they need that type of assistance</li>
            <li>Do not redistribute the contact details of the job seeker.</li>
            <li>Use Job Seeker's contact details for the purposes of employment only.</li>
        </ul><br />
        <div class="container">
            <asp:Button ID="btnAccept" runat="server" Text="Accept" class="btn btn-primary" OnClick="btnAccept_Click" />
        </div><br />
        <div class="container" runat="server" id="ContactDetails" visible="false">
            <div class="row">
                <div class="col-md-4">
                    Contact Number:
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblContatNumber" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    Alternative Contact Number:
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblAltContact" runat="server" Text=""></asp:Label>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                    Contact Number:
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                </div>
            </div>
         </div>
    </div>
</asp:Content>
