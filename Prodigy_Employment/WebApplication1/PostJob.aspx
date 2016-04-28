<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="PostJob.aspx.cs" Inherits="WebApplication1.PostJob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left:19%; padding-right:19%">
        <div class ="row" style="padding-left:10%; padding-right:5%; border:groove">
            <h2 style="text-align:center" >Provide job details.</h2>
            <hr id="Hr1" style="color: #808080, #C2C2C2" runat ="server"  /> 
            <p style="text-align:center"><i>After posting, this job will be viewed by many job seekers, who might be interested.</i></p>
            <br />
            <div class ="row">
                <div class="col-md-4">
                    Name:
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
           <br />
            <div class ="row">
                <div class="col-md-4">
                    Description:
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtDescription" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class ="row">
                <div class="col-md-4">
                    Duration(hours):
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtDuration" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class ="row">
                <div class="col-md-4">
                    Location:
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtLocation" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class ="row">
                <div class="col-md-4">
                    Pay:
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtReward" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class ="row">
                <asp:Button ID="btnUpload" runat="server" Text="Upload" class="btn btn-success" Width="50%" OnClick="btnUpload_Click" />
            </div>
            <br />
        </div>
    </div>
</asp:Content>
