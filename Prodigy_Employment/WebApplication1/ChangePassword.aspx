<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebApplication1.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left:20%; padding-right: 20%">
         <div class ="row" style="padding-left:10%; padding-right:10%; border:groove">
            <h3 style="text-align:center">Change Password.</h3>
             <hr id="Hr1" style="color: #808080, #C2C2C2" runat ="server"  /> 
            <div class="row">
                Username(Email Address):
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
            <div class ="row">
                <asp:Button ID="btnChangePassword" class="btn btn-primary btn-xl" runat="server" Text="Submit" OnClick="btnChangePassword_Click" />
                  <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
            </div>
            <br />
        </div>
       </div>

    
</asp:Content>
