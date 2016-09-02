<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication1.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" >
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Sign In</div>
                    <div style="float: right; font-size: 80%; position: relative; top: -10px"><a href="ChangePassword.aspx">Forgot password?</a></div>
                </div>

                <div style="padding-top: 30px" class="panel-body">

                    <div style="display: none" id="login-alert" class="alert alert-danger col-sm-12"></div>

                    <div id="loginform" class="form-horizontal" role="form">

                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <input id="txtUsername" runat="server" type="text" class="form-control" name="username" value="" placeholder="email"/>
                        </div>

                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <input runat="server" id="txtPassword" type="password" class="form-control" name="password" placeholder="password"/>
                        </div>
                        <div class="input-group">
                            <div class="checkbox">
                                <label>
                                    <input id="login-remember" type="checkbox" name="remember" value="1"/>
                                    Remember me
                                </label>
                            </div>
                        </div>
                        <div style="margin-top: 10px" class="form-group">
                            <!-- Button -->
                            <div class="col-sm-12 controls">                               
                                <asp:Button ID="btnLogin" style="border-radius: initial; width: 35%" class="btn btn-primary btn-md" runat="server" Text="Login" OnClick="btnLogin_Click" /> 
                                <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>  <br /><br />                            
                            </div>
                        </div>
                         
                        <div class="form-group">
                            <div class="col-md-12 control">
                                <div style="border-top: 1px solid#888; padding-top: 15px; font-size: 85%">
                                    Don't have an account! 
                                        <a href="Registration.aspx">Sign Up Here</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <%--     <div class="card">
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
       </div>--%>
    </div>
</asp:Content>
