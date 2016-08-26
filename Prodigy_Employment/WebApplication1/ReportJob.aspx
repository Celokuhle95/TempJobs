<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ReportJob.aspx.cs" Inherits="WebApplication1.ReportJob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="text-align:center; padding-left:22%; padding-right:22%">
        <div class ="row" style="padding-left:10%; padding-right:10%; border:groove">
            <h3>Report Job.</h3>
            <hr id="Hr1" style="color: #808080, #C2C2C2" runat ="server"  />         
            <div class="row" style="text-align:left" >               
                Job Name: 
                <asp:TextBox ID="txtJobName" class="form-control" runat="server"></asp:TextBox>
            </div>
            <br />
                <div class="row" style="text-align:left">
                Comment(why report the Job):  
                <asp:TextBox ID="txtComment" class="form-control"  runat="server" Height="142px" Width="361px"></asp:TextBox>
            </div>
            <br />
            <div class="row" >
                <asp:Button ID="btnReport" class="btn btn-primary btn-xl" runat="server" Text="Report" OnClick="btnReport_Click" />               
            </div> 
            <br />
            
            <br />     
        </div>
     </div>
</asp:Content>
