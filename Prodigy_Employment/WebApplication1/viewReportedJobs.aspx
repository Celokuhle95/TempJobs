<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="viewReportedJobs.aspx.cs" Inherits="WebApplication1.viewReportedJobs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" runat="server">
        <ul style ="list-style :none; text-align:right ">
            <li>Sort by: 
                <asp:DropDownList ID="ddlSort" runat="server" AutoPostBack="true" style="width: 104px" OnSelectedIndexChanged="sort_SelectedIndexChanged">
                     <asp:ListItem Selected ="True"  Value ="All">All categories</asp:ListItem>
                    <asp:ListItem   Value ="Employer">Employer</asp:ListItem>
                    <asp:ListItem   Value ="MostReported">Most Reported</asp:ListItem>
                    <asp:ListItem   Value ="Type">type OF Job</asp:ListItem>
                </asp:DropDownList>

            </li>
        </ul>
        <div id="reportedJobs"  runat="server">

        </div>
    </div>
</asp:Content>
