<%@ Page Title="" Language="C#" MasterPageFile="~/MasterContent/UserWeb.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="OnlineShoppingWebApp.UserFolder.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GvCartProducts" runat="server" AutoGenerateColumns="false" ShowHeader="true" CssClass="table table-condensed table-hover">
        <Columns>
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Image ID ="Image1" runat="server" Height="100px" Width="100px" 
                        ImageUrl='<%# Eval("ProductImage") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
            <asp:BoundField DataField="ProductPrice" HeaderText="Price"/>
            <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="TxtQuantity" TextMode="Number" runat="server" min="1" max="10" value="1" />
                    </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="BtnCheckout" runat="server" Text="CHECKOUT" CssClass="btn btn-outline-dark" OnClick="BtnCheckout_Click"/>
</asp:Content>
