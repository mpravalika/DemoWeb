<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="DemoWeb.confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Empno</td>
            <td>
                <asp:Label ID="lblempno" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Ename</td>
            <td>
                <asp:Label ID="lblename" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Job</td>
            <td>
                <asp:Label ID="lbljob" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Mgr</td>
            <td>
                <asp:Label ID="lblmgr" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Hiredate</td>
            <td>
                <asp:Label ID="lblhiredate" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Salary</td>
            <td>
                <asp:Label ID="lblsal" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Commision</td>
            <td>
                <asp:Label ID="lblcomm" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Deptno</td>
            <td>
                <asp:Label ID="lbldeptno" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnconfirm" runat="server" Text="Confirm" OnClick="btnconfirm_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
