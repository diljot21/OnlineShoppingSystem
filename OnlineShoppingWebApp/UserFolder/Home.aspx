<%@ Page Title="" Language="C#" MasterPageFile="~/MasterContent/UserWeb.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineShoppingWebApp.UserFolder.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    @foreach (var product in (List<Product>)ViewData["pl"])
    {
        <div class="col-sm-4">
            <table class="table table-bordered" style="border-color:transparent; box-shadow: 0 1px 9px 0 rgba(0, 0, 0, 0.1), 0 1px 10px 0 rgba(0, 0, 0, 0.19);border-top-left-radius:30px;border-top-right-radius:30px;">

                <tr style="text-align:center">
                    <td colspan="2" style="border-color:transparent;">
                        <img src="~/images/@product.pro_image" style="width:40%" /><br />
                        <span style="color:#337ab7">@product.pro_name</span><br />
                        <span style="color:indianred">Description : </span>@product.pro_desc<br /></td>
                </tr>
                <tr style="text-align:center;color:green;">
                    <td style="border:1px solid white;">
                        <button style="background-color:lavender;" class="btn btn-outline-success" onclick="incrementCookie(@product.pro_id)" name="compare"><span style="color:indianred">Price :</span> $@product.pro_price &nbsp;&nbsp;&nbsp;<i class="glyphicon glyphicon-shopping-cart"></i></button>
                    </td>
                </tr>

            </table>
        </div>
    }
</asp:Content>
