<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tempjobs_Unemployment.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <hr style="color: #683A0C" />
        <div class ="row">
            <hr style="color: #808080, #C2C2C2" runat ="server"  />
            <h4 style="color: olive">Login.</h4>
            <hr style="color: #808080, #C2C2C2" runat ="server"  />

            <div class="col-md-9">
                <div class="row">
                    <div class="col-md-3">
                        USername: 
                    </div>
                      <div class="col-md-3">
                            <asp:TextBox ID="txtUsername" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-md-3">
                        Password: 
                    </div>
                      <div class="col-md-3">
                            <asp:TextBox ID="txtPassword" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
          </div>
        </div>
        <hr id="Hr2" style="color: #683A0C" runat="server" />
     </div>
</asp:Content>
