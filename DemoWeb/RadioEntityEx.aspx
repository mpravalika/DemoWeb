<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="RadioEntityEx.aspx.cs" Inherits="DemoWeb.RadioEntityEx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td>
        <asp:RadioButton ID="rdbjoindate" runat="server" GroupName="G1" Text="JoiningDate" AutoPostBack="True" OnCheckedChanged="rdbjoindate_CheckedChanged" />
        </td>
        <td>
            <asp:TextBox ID="txtstdate" runat="server" TextMode="Date"></asp:TextBox>
            and
            <asp:TextBox ID="txtenddate" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
        <asp:RadioButton ID="rdbdeptno" runat="server" GroupName="G1" OnCheckedChanged="rdbdeptno_CheckedChanged" Text="Deptno" AutoPostBack="True"  />
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
                <asp:Label ID="label" runat="server" Text=" "></asp:Label></td>
        </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>
    </tr>
</table>

</asp:Content>
