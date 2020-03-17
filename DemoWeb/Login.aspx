<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DemoWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/LoginValidations.js"></script>

    <style type="text/css">
        .auto-style6 {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td>Username</td>
        <td class="auto-style6">
            <asp:TextBox ID="txtusername" runat="server" ClientIDMode="Static"></asp:TextBox> 
        </td>
    </tr>
    <tr>
        <td>password</td>
        <td class="auto-style6">
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox> 
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Purple"></asp:Label>
        </td>
        <td></td>
    </tr>
    <tr>
        
        <td class="auto-style6">
            <asp:Button ID="btnLogin" runat="server" Text="Login" Height="28px" OnClick="btnLogin_Click" OnClientClick="return validate();"/> 
        </td>
        <td></td>
    </tr>
</table> 
</asp:Content>
