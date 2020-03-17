<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="javascript" type="text/javascript">
        function Validate()
        {
            var eno = document.getElementById("txtempno").value;
            var ename = document.getElementById("txtename").value;
            var job = document.getElementById("txtjob").value;
            var mgr = document.getElementById("txtmgr").value;
            var hr = document.getElementById("txthiredate").value;
            var s = document.getElementById("txtsal").value;
            var c= document.getElementById("txtcomm").value;
            var dno = document.getElementById("txtdept").value;
            if (eno.length != 0 && ename.length != 0 && job.length != 0 && mgr.length != 0 && hr.length != 0 && s.length != 0 && c.length != 0 && dno.length != 0)
                return true;
            else
            {
                alert("enter all details");
                return false;
            }


        }
    </script>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 207px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style4">Employee No</td>
                   <td>
                        <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Employee Name</td>
                   <td>
                        <asp:TextBox ID="txtename" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Job</td>
                   <td>
                        <asp:TextBox ID="txtjob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Mgr</td>
                    <td>
                        <asp:TextBox ID="txtmgr" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Hiredate</td>
                    <td>
                        <asp:TextBox ID="txthiredate" runat="server" Width="120px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Sal </td>
                   <td>
                        <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Comm</td>
                   <td>
                        <asp:TextBox ID="txtcomm" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Dept No</td>
                    <td style="margin-left:40px">
                        <asp:TextBox ID="txtdept" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td  style="margin-left:40px" class="auto-style4">
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="return Validate();" OnClick="Button1_Click1" />   
                    </td>
                    <td style="margin-left:40px">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
