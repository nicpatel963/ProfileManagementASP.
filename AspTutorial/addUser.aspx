<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addUser.aspx.cs" Inherits="addUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 161px;
        }
        .auto-style7 {
            width: 161px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            margin-left: 120px;
        }
        .auto-style10 {
            width: 534px;
        }
        .auto-style11 {
            height: 26px;
            width: 534px;
        }
        .auto-style12 {
            width: 534px;
            margin-left: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label3" runat="server" Text="Date of birth"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxDob" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style12">
                <asp:FileUpload ID="FileUpload1" runat="server" Height="27px" Width="299px" />
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style10">
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="submit" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
<p>
</p>
<p>
</p>
</asp:Content>

