<%@ Page Title="" Language="C#" MasterPageFile="~/MasterContent/UserWeb.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineShoppingWebApp.UserFolder.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <asp:GridView ID="GvProducts" runat="server" AutoGenerateColumns="false" ShowHeader="true" CssClass="table table-condensed table-hover">
        <Columns>
            <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox Id="ChkSelect" runat="server"/>
                    </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Image ID ="Image1" runat="server" Height="100px" Width="100px" 
                        ImageUrl='<%# Eval("ProductImage") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
            <asp:BoundField DataField="ProductPrice" HeaderText="Price"/>
            <asp:BoundField DataField="ProductDescription" HeaderText="Description"/>
        </Columns>
    </asp:GridView>
    <asp:Button ID="BtnPurchaseProduct" runat="server" Text="Purchase Product" OnClick="BtnPurchaseProduct_Click"/>
</asp:Content>
