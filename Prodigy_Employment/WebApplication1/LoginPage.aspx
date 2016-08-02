<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication1.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" style="text-align:center; padding-left:22%; padding-right:22%">
        <div class ="row" style="padding-left:10%; padding-right:10%; border:groove">
            <h3>Login.</h3>
            <hr id="Hr1" style="color: #808080, #C2C2C2" runat ="server"  />     
            <div class="">
                <img class="img-circle" src="images/loginImage.jpeg" height="100" width="150"/>
            </div>    
            <div class="row" style="text-align:left" >               
                Username: 
                <asp:TextBox ID="txtUsername" class="form-control" runat="server"></asp:TextBox>
            </div>
            <br />
                <div class="row" style="text-align:left">
                Password:  
                <asp:TextBox ID="txtPassword" class="form-control" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <br />
            <div class="row" >
                <asp:Button ID="btnLogin" class="btn btn-primary btn-xl" runat="server" Text="Login" OnClick="btnLogin_Click" />
                <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>               
            </div> 
            <br />
            <div class="row">
                <a href="ChangePassword.aspx" style="color:black">forgot your password?</a>
            </div>  
            <br />     
        </div>
     </div>
</asp:Content>
