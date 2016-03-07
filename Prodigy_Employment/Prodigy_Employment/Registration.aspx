<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Tempjobs_Unemployment.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container" style="padding-left: 8%">
        <h4 id="H1"  style="color:olive" runat ="server" >Registration.</h4>
        <hr style="color: #683A0C" />
        <div class="row">
            <div class="col-md-8">
                <div class="row">
                    <div class ="col-md-4">
                        First name:
                    </div>
                    <div  class ="col-md-6">
                        <asp:TextBox ID="txtFirstName" runat="server" class="form-control"  ></asp:TextBox>
                    </div>
                 </div>
                <br />
                  <div class="row">
                    <div class ="col-md-4">
                        Second name:
                    </div>
                    <div  class ="col-md-6">
                        <asp:TextBox ID="txtSecondName" runat="server" class="form-control"  ></asp:TextBox>
                    </div>
                 </div>
                 <br />
                 <div class="row">
                    <div class ="col-md-4">
                        Residential address:
                    </div>
                    <div  class ="col-md-6">
                        <asp:TextBox ID="txtResAddress" runat="server" class="form-control"  ></asp:TextBox>
                    </div>
                 </div>
                 <br />
                 <div class="row">
                    <div class ="col-md-4">
                        Email address:
                    </div>
                    <div  class ="col-md-6">
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control"  ></asp:TextBox>
                    </div>
                 </div>
                 <br />
                 <div class="row">
                    <div class ="col-md-4">
                        Cellphone Number:
                    </div>
                    <div  class ="col-md-6">
                        <asp:TextBox ID="txtCellphone" runat="server" class="form-control"  ></asp:TextBox>
                    </div>
                 </div>
                 <br />
                <div class="row">
                    <div class ="col-md-4">
                        Register as:
                    </div>
                    <div  class ="col-md-6">
                        <div class="dropdown">
                            <a href="#" data-toggle="dropdown" class="dropdown-toggle">Select option <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Employer</a></li>
                                <li><a href="#">Job seeker</a></li>
                                <li><a href="#">Small Business</a></li>
                            </ul>
                        </div>
                    </div>
                 </div>
                 <br />
                <div class="row">
                    <div class ="col-md-4">
                        Username:
                    </div>
                    <div  class ="col-md-6">
                        <asp:TextBox ID="txtUsername" runat="server" class="form-control"  ></asp:TextBox>
                    </div>
                 </div>
                 <br />
                <div class="row">
                    <div class ="col-md-4">
                        Password:
                    </div>
                    <div  class ="col-md-6">
                        <asp:TextBox ID="txtPassword" runat="server" class="form-control"  ></asp:TextBox>
                    </div>
                 </div>
                 <br />
                <div class="row">
                    <div class ="col-md-4">
                        Confirm Password:
                    </div>
                    <div  class ="col-md-6">
                        <asp:TextBox ID="txtConfirmPassword" runat="server" class="form-control"  ></asp:TextBox>
                    </div>
                 </div>
                 <br />
                <div class="row">
                    <div class ="col-md-6">
                        <asp:Button ID="btnRegister" runat="server" Text="Register" class="btn btn-primary" OnClick="btnRegister_Click" />
                    </div>
                 </div>
            </div>
        </div>
    </div>
</asp:Content>
