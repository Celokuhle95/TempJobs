<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebApplication1.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="padding-left: 8%">
        <h4 id="H1" style="color: olive" runat="server">Profile.</h4>
        <hr style="color: #683A0C" />

        <div>
            <div class="row">
                <div class="col-md-8">
                    <div class="row">
                        <div class="col-md-4">
                            First name:
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtFirstName" runat="server" class="form-control"></asp:TextBox> </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            Last name:
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtLastName" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            Residential address:
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtResAddress" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            Age:
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtAge" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            Gender:
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="drpGender" class="form-control" runat="server">
                                <asp:ListItem Value="0">Male</asp:ListItem>
                                <asp:ListItem Value="1">Female</asp:ListItem>
                                <asp:ListItem Value="2">Select gender</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            Email address:
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            Cellphone Number:
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtCellphone" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            Telephone Number:
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtTelephone" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            Username:
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtUsername" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-10">
                            <asp:Label ID="lblUserError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
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
                    <br />
                    <div class="row">
                        <div class="col-md-4">
                            <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click1" />
                        </div>
                        <div class="col-md-6">
                            <asp:Button ID="btnmore" runat="server" Text="More" class="btn btn-primary" OnClick="btnmore_Click" />
                        </div>
                        <div class="col-md-8">
                            <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                        </div>
                    </div>
                </div>
                 <div id="disImage" runat="server">
                </div>

            </div>
        </div>
    </div>
</asp:Content>
