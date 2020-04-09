<%@ Page Title="" Language="C#" MasterPageFile="~/MasterContent/Anonymous.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineShoppingWebApp.Anonymous.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        Enter username and password<br />
        <table>
            <tr>
                <td>
                    Username:
                </td>
                <td>
                    <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtUsername" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <asp:TextBox ID="TxtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtPassword" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
        <br />
        <asp:Label ID="LblLoginStatus" runat="server"></asp:Label>
        <br />
    </div>
</asp:Content>
