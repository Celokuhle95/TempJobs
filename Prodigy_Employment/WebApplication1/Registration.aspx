<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="page-header">
            <h1>Registration</h1>
        </div>
        <div class="" style="padding-left:22%; padding-right:22%">
        <div class="row"  style="border:groove; padding:5% ">
            <div class="row">
                <div class="col-md-4">
                    First Name:
                </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtFirstName" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Last Name:
                </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtLastName" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Email Address (Used as username):
                </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Password:
                </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Confirm Password:
                </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Cellphone Number:
                </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtCellphone" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Alternative Contact Number:
                </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtAltContactNum" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Residential Address:
                </div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtResAddress" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Register as:
                </div>
                <div class="col-md-7">
                    <asp:DropDownList ID="drpUsertype" class="form-control" runat="server" style="width:inherit; height:inherit" OnSelectedIndexChanged="drpUsertype_SelectedIndexChanged">
                        <asp:ListItem Value="0">select Option</asp:ListItem>
                        <asp:ListItem Value="1">Employer</asp:ListItem>
                        <asp:ListItem Value="2">Job seeker</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    Profile Image:
                </div>
                <div class="col-md-7">
                    <asp:FileUpload ID="ProfileImageUpload" runat="server" Width="225px" />
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" class="btn btn-primary btn-md" Style="border-radius: initial; width: 100%" OnClick="btnRegister_Click" />
                </div>
                <div class="col-md-7">
                    <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                </div>
            </div>
            <br />
        </div>
        </div>
    </div>
</asp:Content>
