<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStrEx4.aspx.cs" Inherits="DemoWeb.QueryStrEx4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="javascript" type="text/javascript">
        function Func1()
        {
            window.open("QueryStrEx5.aspx?a=10&b=20");
        }      
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="Func1();"/>
        </div>
    </form>
</body>
</html>
