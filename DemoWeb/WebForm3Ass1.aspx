<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm3Ass1.aspx.cs" Inherits="DemoWeb.WebForm3Ass1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
    <tr>
        <td class="auto-style6">
        <asp:RadioButton ID="rdbjoindate" runat="server" GroupName="G1" Text="JoiningDate" AutoPostBack="True" OnCheckedChanged="rdbjoindate_CheckedChanged" />
        </td>
        <td class="auto-style6">
            <asp:TextBox ID="txtstdate" runat="server" TextMode="Date"></asp:TextBox>
            and
            <asp:TextBox ID="txtenddate" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
        <asp:RadioButton ID="rdbdeptno" runat="server" GroupName="G1" OnCheckedChanged="rdbdeptno_CheckedChanged" Text="Deptno" AutoPostBack="True" />
        </td>
        <td>
            <asp:DropDownList ID="ddldeptno" runat="server" AppendDataBoundItems="True">
                <asp:ListItem Value="-1">select</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="gvdata" runat="server"></asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>
    </tr>
</table>
</asp:Content>
