<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="EmployJobSeeker.aspx.cs" Inherits="WebApplication1.EmployJobSeeker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" runat="server">
        <div class="page-header">
            <h2>Employ jobseeker.</h2>
             <p class="text-muted card-subtitle">
                Here you can choose to contact the Jobseeker for the employment. You can then discuss further the details of this employment
                and agree to them with the Jobseeker. 
            </p>
        </div>
       
        <br />
        <h4>Please be aware of these points and stick to them for this employment.</h4>
        <ul>
            <li>Keep the details of the job as they were when the job seeker applied, especially the pay, unless you want to pay the Job Seeker more than stated in the job.</li>
            <li>Treat the Job Seeker with respect and keep to the neccessary labour laws.</li>
            <li>Ensure that Job Seeker does not work for more hours than prevoiusly stated in the job post</li>
            <li>If the Job Seeker ends up doing more jobs for you, they must be paid for that extra time they worked</li>
            <li>If you make promises to the Job Seeker, stick to them i.e promising Job Seekers to fetch them or drop them off if they need that type of assistance</li>
            <li>Do not redistribute the contact details of the job seeker.</li>
            <li>Use Job Seeker's contact details for the purposes of employment only.</li>
        </ul>
        <br />
        <div class="container">
            <asp:Button ID="btnAccept" runat="server" style="border-radius:initial; width:18%" Text="Accept" class="btn btn-primary" OnClick="btnAccept_Click" />
        </div>
        <br />
        <div class="container" runat="server" id="ContactDetails" visible="false"  >
            <div class="card card-outline-info" style="width:40%">
                <div style="border-bottom:1px solid;">                   
                    <div class="row">
                        <div class="col-md-6 text-muted">
                            Contact Number:
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblContatNumber" runat="server" Text="Contact"></asp:Label>
                        </div>
                    </div>  
                    <br />               
                </div>
              
                <div style="border-bottom:1px solid;">
                    <div class="row">
                        <div class="col-md-6 text-muted">
                            Alternative Contact Number:
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblAltContact" runat="server" Text="Alt Contact"></asp:Label>
                        </div>
                    </div>
                    <br /> 
                </div>
               
                <div>                    
                    <div class="row">
                        <div class="col-md-6 text-muted">
                            Contact Number:
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblEmail" runat="server" Text="Email-Addr"></asp:Label>
                        </div>
                    </div>                  
                </div>
                <br />
            </div>
        </div>
    </div>
</asp:Content>
