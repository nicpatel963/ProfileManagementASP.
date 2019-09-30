<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="First.aspx.cs" Inherits="First" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 314px;
        }
        .auto-style7 {
            width: 444px;
        }
        .auto-style8 {
        width: 128px;
    }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style6" dir="ltr" rowspan="4">
                 &nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="btnManage" runat="server" OnClick="btnManage_Click" Text="manage profile" Visible="False" />
            </td>
            <td>
                <asp:Label ID="lblProfile" runat="server"></asp:Label>
                <asp:Button ID="btnLogout" runat="server"  Text="logout" OnClick="btnLogout_Click" Visible="False" Font-Names="Yu Gothic UI Semibold" />
            </td>
        </tr>
        <tr>
            <td colspan="3" rowspan="3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
<br />
<br />
<br />
<br />
<br />
<br />
</asp:Content>

