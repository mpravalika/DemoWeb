<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="DetailsView.aspx.cs" Inherits="DemoWeb.DetailsView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 72px;
        }
        .auto-style8 {
            margin-right: 4px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            width: 72px;
            height: 23px;
        }
        </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  PageSize="2" OnPageIndexChanging="GridView1_PageIndexChanging"></asp:GridView>
    <asp:DetailsView ID="DView" runat="server" Height="50px" Width="125px" AllowPaging="True" OnPageIndexChanging="DView_PageIndexChanging"></asp:DetailsView>
    <asp:FormView ID="FormView1" runat="server" CssClass="auto-style8" AllowPaging="True" OnPageIndexChanging="FormView1_PageIndexChanging">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td>Orderid</td>
                    <td>Orderdesc</td>
                    <td class="auto-style7">Totalprice</td>
                    <td>Discount</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("orderid") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("orderdesc") %>'></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Totalprice") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("discount") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
    </asp:Content>
