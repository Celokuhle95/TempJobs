<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication1.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" style="padding-left: 8%">
        <div class ="row">
            <h4 style="color: olive">Login.</h4>
            <hr id="Hr1" style="color: #808080, #C2C2C2" runat ="server"  />

            <div class="col-md-6">
                <div class="row" >               
                   Username: 
                   <asp:TextBox ID="txtUsername" class="form-control" runat="server"></asp:TextBox>
                </div>
                <br />
                 <div class="row">
                    Password:  
                    <asp:TextBox ID="txtPassword" class="form-control" TextMode="Password" runat="server"></asp:TextBox>
                </div>
                <br />
                <div class="row">
                    <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>
                </div>
          </div>
        </div>
     </div>
</asp:Content>
