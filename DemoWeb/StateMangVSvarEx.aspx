<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateMangVSvarEx.aspx.cs" Inherits="DemoWeb.StateMangVSvarEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" style="height: 26px" />
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
