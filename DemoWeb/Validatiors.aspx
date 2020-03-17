<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Validatiors.aspx.cs" Inherits="DemoWeb.Validatiors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 95px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style6">
                EmpNo
            </td>
            <td>
                <asp:TextBox ID="txtempno" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Cannot be Blank" ControlToValidate="txtempno" ForeColor="Maroon" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                password
            </td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>   
        </tr>
        <tr>
            <td class="auto-style6">
                ConfirmPassword
            </td>
            <td>
                <asp:TextBox ID="txtconfirm" runat="server" TextMode="Password"></asp:TextBox>
            </td>
             <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Mismatch" ControlToCompare="txtpwd" ControlToValidate="txtconfirm" ForeColor="#660066" Display="None"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                salary
            </td>
            <td>
                <asp:TextBox ID="txtsal" runat="server"></asp:TextBox></td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="sal b/w 10000 and 200000" Type="Double" ControlToValidate="txtsal" MinimumValue="10000" MaximumValue="200000" ForeColor="#006600" Display="None"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                pancard
            </td>
            <td>
                <asp:TextBox ID="txtpan" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Pan" ControlToValidate="txtpan" ForeColor="Blue" ValidationExpression="^[A-Z]{5}[0-9]{4}[A-Z]$" Display="None"></asp:RegularExpressionValidator></td>
        </tr>
         <tr>
            <td class="auto-style6">
                Ename
            </td>
            <td>
                <asp:TextBox ID="txtename" runat="server"></asp:TextBox></td>
             <td>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Cannot be Blank" ControlToValidate="txtename" ForeColor="#CC0000" Display="None"></asp:RequiredFieldValidator>
             </td>
        </tr>
        <tr>
            <td>
                DOB
            </td>
            <td>
                <asp:TextBox ID="txtdob" runat="server" TextMode="Date"></asp:TextBox></td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtdob" Display="None" ErrorMessage="Age must be b/w 21 - 50" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>
        </tr>
        
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF0066" />
</asp:Content>
