<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="Skills.aspx.cs" Inherits="WebApplication1.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ProfileInfo" class="container" runat="server">

    </div>
     <div id="Skills" class="container" runat="server">
         <h2 style="color:honeydew">Your informal skills:</h2>
         <br />
         <p>Top five infromal skills that you have. Be ware that some of these skills require that you have your own resources to complete the job.</p>
         <br />
         <table class="table">
             <tbody>
                 <tr><td>Informal Skill 1:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill1" class="form-control" runat="server">
                        <asp:ListItem Value="0">select skill</asp:ListItem>
                        <asp:ListItem Value="1">Tree felling</asp:ListItem>
                        <asp:ListItem Value="2">Trimming and prunning</asp:ListItem>
                        <asp:ListItem Value="3">Working in the garden</asp:ListItem>
                        <asp:ListItem Value="4">Grass cutting</asp:ListItem>
                        <asp:ListItem Value="5">Plumbing</asp:ListItem>
                        <asp:ListItem Value="6">Site clearance/waste removal</asp:ListItem>
                        <asp:ListItem Value="7">Painter</asp:ListItem> 
                        <asp:ListItem Value="8">Varnishing</asp:ListItem>
                        <asp:ListItem Value="9">Washing and Ironing</asp:ListItem>
                        <asp:ListItem Value="10">House Cleaning</asp:ListItem>
                      </asp:DropDownList>
                 </td></tr>
                 <tr><td>Informal Skill 2:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill2" class="form-control" runat="server">
                        <asp:ListItem Value="0">Select skill</asp:ListItem>
                        <asp:ListItem Value="1">Tree felling</asp:ListItem>
                        <asp:ListItem Value="2">Trimming and prunning</asp:ListItem>
                        <asp:ListItem Value="3">Working in the garden</asp:ListItem>
                        <asp:ListItem Value="4">Grass cutting</asp:ListItem>
                        <asp:ListItem Value="5">Plumbing</asp:ListItem>
                        <asp:ListItem Value="6">Site clearance/waste removal</asp:ListItem>
                        <asp:ListItem Value="7">Painter</asp:ListItem> 
                        <asp:ListItem Value="8">Varnishing</asp:ListItem>
                        <asp:ListItem Value="9">Washing and Ironing</asp:ListItem>
                        <asp:ListItem Value="10">House Cleaning</asp:ListItem>
                    </asp:DropDownList>
                 </td></tr>

                 <tr><td>Informal Skill 3:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill3" class="form-control" runat="server">
                        <asp:ListItem Value="0">Select skill</asp:ListItem>
                        <asp:ListItem Value="1">Tree felling</asp:ListItem>
                        <asp:ListItem Value="2">Trimming and prunning</asp:ListItem>
                        <asp:ListItem Value="3">Working in the garden</asp:ListItem>
                        <asp:ListItem Value="4">Grass cutting</asp:ListItem>
                        <asp:ListItem Value="5">Plumbing</asp:ListItem>
                        <asp:ListItem Value="6">Site clearance/waste removal</asp:ListItem>
                        <asp:ListItem Value="7">Painter</asp:ListItem> 
                        <asp:ListItem Value="8">Varnishing</asp:ListItem>
                        <asp:ListItem Value="9">Washing and Ironing</asp:ListItem>
                        <asp:ListItem Value="10">House Cleaning</asp:ListItem>
                    </asp:DropDownList>
                 </td></tr>
                 <tr><td>Informal Skill 4:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill4" class="form-control" runat="server">
                        <asp:ListItem Value="0">Select skill</asp:ListItem>
                        <asp:ListItem Value="1">Tree felling</asp:ListItem>
                        <asp:ListItem Value="2">Trimming and prunning</asp:ListItem>
                        <asp:ListItem Value="3">Working in the garden</asp:ListItem>
                        <asp:ListItem Value="4">Grass cutting</asp:ListItem>
                        <asp:ListItem Value="5">Plumbing</asp:ListItem>
                        <asp:ListItem Value="6">Site clearance/waste removal</asp:ListItem>
                        <asp:ListItem Value="7">Painter</asp:ListItem> 
                        <asp:ListItem Value="8">Varnishing</asp:ListItem>
                        <asp:ListItem Value="9">Washing and Ironing</asp:ListItem>
                        <asp:ListItem Value="10">House Cleaning</asp:ListItem>
                    </asp:DropDownList>
                 </td></tr>
                 <tr><td>Informal Skill 5:</td>
                 <td>
                     <asp:DropDownList ID="drpSkill5" class="form-control" runat="server">
                        <asp:ListItem Value="0">Select skill</asp:ListItem>
                        <asp:ListItem Value="1">Tree felling</asp:ListItem>
                        <asp:ListItem Value="2">Trimming and prunning</asp:ListItem>
                        <asp:ListItem Value="3">Working in the garden</asp:ListItem>
                        <asp:ListItem Value="4">Grass cutting</asp:ListItem>
                        <asp:ListItem Value="5">Plumbing</asp:ListItem>
                        <asp:ListItem Value="6">Site clearance/waste removal</asp:ListItem>
                        <asp:ListItem Value="7">Painter</asp:ListItem> 
                        <asp:ListItem Value="8">Varnishing</asp:ListItem>
                        <asp:ListItem Value="9">Washing and Ironing</asp:ListItem>
                        <asp:ListItem Value="10">House Cleaning</asp:ListItem>
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
