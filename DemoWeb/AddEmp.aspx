<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="AddEmp.aspx.cs" Inherits="DemoWeb.AddEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/AddEmpValidation.js"></script>
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
            <td>EmpName</td>
            <td>
                <asp:TextBox ID="txtename" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Job</td>
            <td>
                <asp:TextBox ID="txtjob" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Mgr</td>
            <td>
                <asp:TextBox ID="txtmgr" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Hiredate</td>
            <td>
                <asp:TextBox ID="txthiredate" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Salary</td>
            <td>
                <asp:TextBox ID="txtsal" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Commision</td>
            <td>
                <asp:TextBox ID="txtcomm" runat="server" ClientIDMode="Static"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Deptno</td>
            <td>
                <asp:TextBox ID="txtdept" runat="server" ClientIDMode="Static"></asp:TextBox></td>
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
