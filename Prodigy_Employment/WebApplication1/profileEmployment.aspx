<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="profileEmployment.aspx.cs" Inherits="WebApplication1.profileEmployment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left: 8%">
        <h4 id="H1" style="color: olive" runat="server">Employment Profile.</h4>
        <hr style="color: #683A0C" />
        <div class="row">
            <div class="col-md-8">
                <div class="row">
                    <div class="col-md-4">
                        Employment status:
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="drpStatus" class="form-control" runat="server">
                            <asp:ListItem Value="True">Employed</asp:ListItem>
                            <asp:ListItem Value="False">unEmployed</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Prefered wage minimum:
                    </div>
                    <div class="col-md-6">
                        <asp:TextBox ID="txtmin" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Prefered wage maimum:
                    </div>
                    <div class="col-md-6">
                        <asp:TextBox ID="txtmax" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Prefered working hour:
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="drpHour" class="form-control" runat="server">
                            <asp:ListItem Value="a">03H00 - 11H00</asp:ListItem>
                            <asp:ListItem Value="b">05H00 - 13H00</asp:ListItem>
                            <asp:ListItem Value="c">08H00 - 16H00</asp:ListItem>
                            <asp:ListItem Value="d">20H00 - 04H00</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        Available:
                    </div>
                    <div class="col-md-6">
                        <asp:DropDownList ID="drpAvailability" class="form-control" runat="server">
                            <asp:ListItem Value="Yes">Yes</asp:ListItem>
                            <asp:ListItem Value="No">No</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                       <a href="EditSkills.aspx" style="text-decoration:solid;text-decoration-color:brown">Edit Skills</a>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" />
                    </div>
                    <div class="col-md-6">
                        <asp:Button ID="btnBack" runat="server" Text="Back" class="btn btn-primary" OnClick="btnBack_Click" />
                    </div>
                    <div class="col-md-8">
                        <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
