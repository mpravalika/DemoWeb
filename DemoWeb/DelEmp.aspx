<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="DelEmp.aspx.cs" Inherits="DemoWeb.DelEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>EmpNo</td>
            <td>
                <asp:TextBox ID="txtemp" runat="server" ClientIDMode="Static"></asp:TextBox>
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
            <td>
                <asp:Button ID="Btnsubmit" runat="server" Text="Submit" OnClick="Btnsubmit_Click" OnClientClick="return validate();" /></td>
        </tr>
     </table>
</asp:Content>
