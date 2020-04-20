<%@ Page Title="" Language="C#" MasterPageFile="~/MasterContent/Anonymous.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="OnlineShoppingWebApp.Anonymous.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        Register<br />
        First Name:
        <asp:TextBox ID="TxtFirstName" runat="server" required=""></asp:TextBox>
        <br />
        Last Name:
        <asp:TextBox ID="TxtLastName" runat="server" required=""></asp:TextBox>
        <br />
        Email:
        <asp:TextBox ID="TxtEmail" runat="server" required=""></asp:TextBox>
        <br />
        Phone Number:
        <asp:TextBox ID="TxtPhoneNumber" runat="server" input="number"></asp:TextBox>
        <br />
        Date of Birth:
        <asp:TextBox ID="TxtDoB" TextMode="Date" runat="server" required=""></asp:TextBox>
        <br />
        Address:
        <asp:TextBox ID="TxtAddress" runat="server" required=""></asp:TextBox>
        <br />
        Postal Code:
        <asp:TextBox ID="TxtPostalCode" runat="server" required=""></asp:TextBox>
        <br />
        <br />
        Username:
        <asp:TextBox ID="TxtUsername" runat="server" required=""></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="TxtPassword" TextMode="Password" runat="server" required=""></asp:TextBox>
        <br />
        <asp:Label ID="LblStatus" runat="server"></asp:Label>
        <br />
        <asp:Button ID="BtnRegister" runat="server" Text="Register" OnClick="BtnRegister_Click" />
    </div>
</asp:Content>
