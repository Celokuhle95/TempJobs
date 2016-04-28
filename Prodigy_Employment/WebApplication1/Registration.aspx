﻿<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left:22%; padding-right:22%">
    <div class ="row" style="padding-left:10%; padding-right:5%; border:groove">
        <h3 id="H1" style="text-align:center" runat="server">Registration.</h3>
        <hr style="color: #683A0C" />
        <div class="row">
                <div class="row">
                    <div class="col-md-4">
                        First name:
                    </div>
                    <div class="col-md-7">
                        <asp:TextBox ID="txtFirstName" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Last name:
                    </div>
                    <div class="col-md-7">
                        <asp:TextBox ID="txtLastName" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Residential address:
                    </div>
                    <div class="col-md-7">
                        <asp:TextBox ID="txtResAddress" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Email address:
                    </div>
                    <div class="col-md-7">
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
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
                        Telephone Number:
                    </div>
                    <div class="col-md-7">
                        <asp:TextBox ID="txtTelephone" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Register as:
                    </div>
                    <div class="col-md-7">
                         <asp:DropDownList ID="drpAuthintication" class="form-control" runat="server">
                                    <asp:ListItem Value="0">select Option</asp:ListItem>
                                    <asp:ListItem Value="1">Employer</asp:ListItem>
                                    <asp:ListItem Value="2">Job seeker</asp:ListItem>
                                </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Username:
                    </div>
                    <div class="col-md-7">
                        <asp:TextBox ID="txtUsername" runat="server" class="form-control"></asp:TextBox>
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
                        Profile Image:
                    </div>
                    <div class="col-md-7">
                        <asp:FileUpload ID="ProfileImageUpload" runat="server" Width="225px"/>
                        </div>
                </div>
                <br/> 
                <div class="row">
                    <div class="col-md-4">
                        <asp:Button ID="btnRegister" runat="server" Text="Register" class="btn btn-success" Width="100%" Height="50" OnClick="btnRegister_Click" />
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
