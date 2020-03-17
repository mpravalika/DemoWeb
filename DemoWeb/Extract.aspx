<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Extract.aspx.cs" Inherits="DemoWeb.Extract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Enter the deptno:<asp:DropDownList ID="ddldeptno" runat="server" OnSelectedIndexChanged="ddldeptno_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">
        <asp:ListItem Value="-1">select</asp:ListItem>
        </asp:DropDownList>
     <asp:GridView ID="gvdata" runat="server" OnSelectedIndexChanged="gvdata_SelectedIndexChanged"></asp:GridView>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Button" />

    </h2>
</asp:Content>
