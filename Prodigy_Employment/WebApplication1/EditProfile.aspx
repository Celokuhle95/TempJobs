<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="WebApplication1.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ProfileInfo" class="container" runat="server">

    </div>
     <div id="Skills" class="container" runat="server">
         <h2 style="color:honeydew">Skills:</h2>
         <table class="table">
             <tbody>
                 <tr><td>Informal Skill 1:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill1" class="form-control" runat="server">
                                    <asp:ListItem Value="0">Informal Skills</asp:ListItem>
                                    <asp:ListItem Value="1">Plumber</asp:ListItem>
                                    <asp:ListItem Value="2">Gardner</asp:ListItem>
                                    <asp:ListItem Value="3">Grasscutter</asp:ListItem>
                                    <asp:ListItem Value="4">Tree Cutting</asp:ListItem>
                                    <asp:ListItem Value="5">Garbage disposal</asp:ListItem>
                                    <asp:ListItem Value="6">Painter</asp:ListItem>
                                    <asp:ListItem Value="7">Ironing</asp:ListItem>
                                    <asp:ListItem Value="8">Washing</asp:ListItem>
                                    <asp:ListItem Value="9">Cooking</asp:ListItem>
                                </asp:DropDownList>
                 </td></tr>
                 <tr><td>Informal Skill 2:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill2" class="form-control" runat="server">
                                    <asp:ListItem Value="0">Informal Skills</asp:ListItem>
                                    <asp:ListItem Value="1">Plumber</asp:ListItem>
                                    <asp:ListItem Value="2">Gardner</asp:ListItem>
                                    <asp:ListItem Value="3">Grasscutter</asp:ListItem>
                                    <asp:ListItem Value="4">Tree Cutting</asp:ListItem>
                                    <asp:ListItem Value="5">Garbage disposal</asp:ListItem>
                                    <asp:ListItem Value="6">Painter</asp:ListItem>
                                    <asp:ListItem Value="7">Ironing</asp:ListItem>
                                    <asp:ListItem Value="8">Washing</asp:ListItem>
                                    <asp:ListItem Value="9">Cooking</asp:ListItem>
                                </asp:DropDownList>
                 </td></tr>

                 <tr><td>Informal Skill 3:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill3" class="form-control" runat="server">
                                    <asp:ListItem Value="0">Informal Skills</asp:ListItem>
                                    <asp:ListItem Value="1">Plumber</asp:ListItem>
                                    <asp:ListItem Value="2">Gardner</asp:ListItem>
                                    <asp:ListItem Value="3">Grasscutter</asp:ListItem>
                                    <asp:ListItem Value="4">Tree Cutting</asp:ListItem>
                                    <asp:ListItem Value="5">Garbage disposal</asp:ListItem>
                                    <asp:ListItem Value="6">Painter</asp:ListItem>
                                    <asp:ListItem Value="7">Ironing</asp:ListItem>
                                    <asp:ListItem Value="8">Washing</asp:ListItem>
                                    <asp:ListItem Value="9">Cooking</asp:ListItem>
                                </asp:DropDownList>
                 </td></tr>
                 <tr><td>Informal Skill 4:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill4" class="form-control" runat="server">
                                    <asp:ListItem Value="0">Informal Skills</asp:ListItem>
                                    <asp:ListItem Value="1">Plumber</asp:ListItem>
                                    <asp:ListItem Value="2">Gardner</asp:ListItem>
                                    <asp:ListItem Value="3">Grasscutter</asp:ListItem>
                                    <asp:ListItem Value="4">Tree Cutting</asp:ListItem>
                                    <asp:ListItem Value="5">Garbage disposal</asp:ListItem>
                                    <asp:ListItem Value="6">Painter</asp:ListItem>
                                    <asp:ListItem Value="7">Ironing</asp:ListItem>
                                    <asp:ListItem Value="8">Washing</asp:ListItem>
                                    <asp:ListItem Value="9">Cooking</asp:ListItem>
                                </asp:DropDownList>
                 </td></tr>
                 <tr><td>Informal Skill 5:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill5" class="form-control" runat="server">
                                    <asp:ListItem Value="0">Informal Skills</asp:ListItem>
                                    <asp:ListItem Value="1">Plumber</asp:ListItem>
                                    <asp:ListItem Value="2">Gardner</asp:ListItem>
                                    <asp:ListItem Value="3">Grasscutter</asp:ListItem>
                                    <asp:ListItem Value="4">Tree Cutting</asp:ListItem>
                                    <asp:ListItem Value="5">Garbage disposal</asp:ListItem>
                                    <asp:ListItem Value="6">Painter</asp:ListItem>
                                    <asp:ListItem Value="7">Ironing</asp:ListItem>
                                    <asp:ListItem Value="8">Washing</asp:ListItem>
                                    <asp:ListItem Value="9">Cooking</asp:ListItem>
                                </asp:DropDownList>
                 </td></tr>
                 <tr><td>
                         <asp:Button ID="btnStoreDetails" runat="server" Text="Save changes" class="btn btn-primary btn-xl" OnClick="btnStoreDetails_Click"/>
                     </td>
                </tr>
             </tbody>
         </table>
    </div>

</asp:Content>
