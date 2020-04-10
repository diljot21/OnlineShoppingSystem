<%@ Page Title="" Language="C#" MasterPageFile="~/MasterContent/Anonymous.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineShoppingWebApp.Anonymous.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <div style="position:absolute; top:50%; left:50%; transform:translate(-50%, -50%); border-radius:50%;" id="later1">

    
    <div class="modal-body" style=" background-color: rgba(225, 225, 225, .9)">
        <div class ="row">
            <div class="col-xs-6">
            
            Enter username and password
                <div class="form-group">
                    Username:
                    <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtUsername" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                     Password:
                     <asp:TextBox ID="TxtPassword" TextMode="Password" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtPassword" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" CssClass="btn btn-success btn-block" />
                <br />
                <asp:Label ID="LblLoginStatus" runat="server"></asp:Label>
                <br />
            </div>
            <div class="col-xs-6">
                <p class="lead">Developed by: <span class="text-success">DILJOT SEKHON</span></p>
            </div>
        </div>
    </div>
    </div>
    </div>

</asp:Content>
