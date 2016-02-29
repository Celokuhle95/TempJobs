<%@ Page Title="" Language="C#" MasterPageFile="~/Sites/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Prodigy_Employment.Sites.User.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <hr id="Hr1"  style="color: #808080, #C2C2C2" runat ="server"  />
    <h4 id="H1"  style="text-align: center" runat ="server" >Login Page</h4>
    <hr style="color: #683A0C" />
    <table >
        <tr id="Tr1" runat="server">
            <td>Email: </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server" TextMode ="Email" ></asp:TextBox></td>
        </tr>
        <tr id="Tr2"  runat ="server" >
            <td>Password: </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtpassword" runat="server" TextMode ="Password" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="73px" /></td>
            <td class="auto-style1">
                <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false" Text="Username / password incorrect"></asp:Label></td>
        </tr>
    </table>
    <hr id="Hr2" style="color: #683A0C" runat="server" />
</asp:Content>
