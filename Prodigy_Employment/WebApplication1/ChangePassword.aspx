<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebApplication1.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width:40%">
        <div class="card" style="padding:4%">
            <div class="page-header">
                <h2 style="text-align: center">Change Password.</h2>
            </div>          
            <div class="card-block">
                 <div class="row">
                 Username:
                <asp:TextBox ID="txtUsername" runat="server" class="form-control"></asp:TextBox>
            </div>
                 <br />
                <div class="row">
                    New password:
                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                </div>
                <br />
                <div class="row">
                    Confirm new password:
                <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server" class="form-control"></asp:TextBox>
                </div>
                <br />
                <div class="row">
                    <asp:Button ID="btnChangePassword" class="btn btn-primary btn-md" Style="border-radius: initial; width:50%" runat="server" Text="Submit" OnClick="btnChangePassword_Click" />
                    <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                </div>
                <br />
            </div>

        </div>
    </div>

</asp:Content>
