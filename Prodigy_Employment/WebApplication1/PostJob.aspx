<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="PostJob.aspx.cs" Inherits="WebApplication1.PostJob" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="text-align: center; background-color: darkkhaki">
        <h2>Provide job details.</h2>
        <hr style="color: goldenrod" />
        <p style="color: mistyrose"><i>After posting, this job will be viewed by many job seekers, who might be interested.</i></p>
        <div class="row">
            <div class="col-md-4">
                Name:
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-4">
                Description:
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtDescription" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <br />

        <div class="row">
            <div class="col-md-4">
                Duration(hours):
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtDuration" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <br />

        <div class="row">
            <div class="col-md-4">
                Location:
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtLocation" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <br />

        <div class="row">
            <div class="col-md-4">
                Reward:
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtReward" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-4">
                Profile Image:
            </div>
            <div class="col-md-6">
                <%--<asp:Button ID="UploadImage" runat="server" Text="Select" OnClick="UploadImage_Click" />--%>
                <asp:FileUpload ID="ProfileImageUpload" runat="server" Width="225px" />
            </div>
        </div>
        <div class="row">
            <asp:Button ID="btnUpload" runat="server" Text="Upload" class="btn btn-success" OnClick="btnUpload_Click" />
        </div>
    </div>
</asp:Content>
