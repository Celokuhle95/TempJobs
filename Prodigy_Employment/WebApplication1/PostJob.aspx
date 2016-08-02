<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="PostJob.aspx.cs" Inherits="WebApplication1.PostJob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left:19%; padding-right:19%">
        <div class ="row" style="padding-left:10%; padding-right:5%; border:groove">
            <h2>Provide job details.</h2>
            <hr id="Hr1" style="color: #808080, #C2C2C2" runat ="server"  /> 
            <p style="text-align:center"><i>After posting, this job will be viewed by many job seekers, who might be interested.</i></p>
            <br />
            <div class ="row">
                <div class="col-md-4">
                    Name:
                </div>
                 <div class="col-md-7">
                       <asp:DropDownList ID="drpSkillName" class="form-control" runat="server">
                            <asp:ListItem Value="0">Select job name</asp:ListItem>
                            <asp:ListItem Value="1">Tree felling</asp:ListItem>
                            <asp:ListItem Value="2">Trimming and prunning</asp:ListItem>
                            <asp:ListItem Value="3">Working in the garden</asp:ListItem>
                            <asp:ListItem Value="4">Grass cutting</asp:ListItem>
                            <asp:ListItem Value="5">Plumbing</asp:ListItem>
                            <asp:ListItem Value="6">Site clearance/Waste removal</asp:ListItem>
                            <asp:ListItem Value="7">Painting</asp:ListItem> 
                            <asp:ListItem Value="8">Varnishing</asp:ListItem>
                            <asp:ListItem Value="9">Washing and Ironing</asp:ListItem>
                            <asp:ListItem Value="10">House Cleaning</asp:ListItem>
                       </asp:DropDownList>
                </div>
            </div>
           <br />
            <div class ="row">
                <div class="col-md-4">
                    Short Description:
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtDescription" runat="server" class="form-control"></asp:TextBox>
                     <i>Provide a short description of what the job seeker will be expected to do inorder complete this job</i>
                </div>
            </div>
            <br />

            <div class ="row">
                <div class="col-md-4">
                    Number Of Days:
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtNumDays" runat="server" class="form-control"></asp:TextBox>
                       <i>The number of days the job will take to complete, this also indicates the number of days the job seeker will be expected to work.</i>
                </div>
            </div>
            <br />
               <div class ="row">
                <div class="col-md-4">
                    Start time(For each day):
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtStartTime" runat="server" class="form-control"></asp:TextBox>
                       <i>This is the time the job seeker will be required to start working every day, for the duration of the job.</i>
                </div>
            </div>
            <br />
               <div class ="row">
                <div class="col-md-4">
                    Knockoff time(For each day):
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtEndTime" runat="server" class="form-control"></asp:TextBox>
                     <i>This is the time the job seeker can expect to knockof every day, for the duration of the job.</i>
                </div>
            </div>
            <br />
            <div class ="row">
                <div class="col-md-4">
                    Location/Place where the job is to be done: 
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtLocation" runat="server" class="form-control"></asp:TextBox>
                     <i>Provide the address of the place where the job is to be done. This may be your home, your business space or whereever.</i>
                </div>
            </div>
            <br />

            <div class ="row">
                <div class="col-md-4">
                    Pay(The amount to be paid each day):
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtReward" runat="server" class="form-control"></asp:TextBox>
                     <i>You will be expected to pay the total amount of all days worked. Also be ware that jobs have a minimum pay that must payed.</i>
                </div>
            </div>
            <br />

            <div class ="row">
                <asp:Button ID="btnUpload" runat="server" Text="Post" class="btn btn-primary btn-xl" OnClick="btnUpload_Click" />
            </div>
            <br />
        </div>
    </div>
</asp:Content>
