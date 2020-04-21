<%@ Page Title="" Language="C#" MasterPageFile="~/MasterContent/UserWeb.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="OnlineShoppingWebApp.UserFolder.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GvCustomerOrders" runat="server" CssClass="table table-condensed table-hover"></asp:GridView>
</asp:Content>
