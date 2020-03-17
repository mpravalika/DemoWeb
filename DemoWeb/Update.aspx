<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="DemoWeb.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
       <tr>
            <td>EmpNo</td>
            <td>
                <asp:TextBox ID="txtemp" runat="server" ClientIDMode="Static" AutoPostBack="True" OnTextChanged="txtemp_TextChanged"></asp:TextBox>
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
                <asp:TextBox ID="txthiredate" runat="server" ClientIDMode="Static" TextMode="Date"></asp:TextBox></td>
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
                <asp:Button ID="Btnupdate" runat="server" Text="update" OnClick="Btnupdate_Click" /></td>
        </tr>
         <tr>
             <td>
                 <asp:Button ID="Btndelete" runat="server" Text="delete" OnClick="Btndelete_Click" />
            </td>
         </tr>
    </table>
</asp:Content>
