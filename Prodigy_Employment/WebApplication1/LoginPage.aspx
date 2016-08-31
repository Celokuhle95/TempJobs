<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication1.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" style="text-align:center; padding-left:22%; padding-right:22%">
       <div class="card">
            <div class="card-block">
                <h4 class="card-title">Login</h4>
            </div>
            <div class="avatar">
                <img src="images/loginImage.jpeg" class="img-circle img-responsive"/> 
            </div>    
            <div class="card-block">
                <p class="card-text" >Username:</p>
                <asp:TextBox ID="txtUsername" class="form-control" runat="server"></asp:TextBox>
                <br />
                <p class="card-text">Password:</p>  
                <asp:TextBox ID="txtPassword" class="form-control" TextMode="Password" runat="server"></asp:TextBox>
                <hr />
                 <asp:Button ID="btnLogin" class="btn btn-primary btn-xl" runat="server" Text="Login" OnClick="btnLogin_Click" />
                <hr />
                <a class="card-link" href ="ChangePassword.aspx">Forgot password?</a> <br /> <br />                       
                <asp:Label class="card-link" ID="lblErr" runat="server" ForeColor="Red"></asp:Label>  <br /><br />
                <p>Don't have an account? <a class="card-link" href="Registration.aspx">Sign up.</a></p>            
           </div>
       </div>
<%--          <div class ="row" style="padding-left:10%; padding-right:10%; border:groove">
            <h3>Login.</h3>
            <hr id="Hr1" style="color: #808080, #C2C2C2" runat ="server"  />     
            <div class="">
                <img class="img-circle" src="images/loginImage.jpeg" height="150" width="150"/>
            </div>    
            <div class="row" style="text-align:left" >               
                Username: 
                <asp:TextBox ID="txtUsernam" class="form-control" runat="server"></asp:TextBox>
            </div>
            <br />
                <div class="row" style="text-align:left">
                Password:  
                <asp:TextBox ID="txtPasswor" class="form-control" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <br />
            <div class="row" >  
               <a href="ChangePassword.aspx" style="color:black">Forgot password?</a> <br /> <br />         
               <asp:Button ID="btnLogi" class="btn btn-primary btn-xl" runat="server" Text="Login" OnClick="btnLogin_Click" />            
               <asp:Label ID="lblEr" runat="server" ForeColor="Red"></asp:Label>  <br /><br />
               <p>Don't have an account? <a href="Registration.aspx" style="color:black">Sign up.</a></p>            
            </div> 
            <br />        
            <br />     
        </div>--%>
     </div>
</asp:Content>
