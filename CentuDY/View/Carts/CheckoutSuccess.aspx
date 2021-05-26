<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="CheckoutSuccess.aspx.cs" Inherits="CentuDY.View.Carts.CheckoutSuccess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Your Checkout is Success !</h2>
    <h3>Thank you for shoping with us.</h3>

    <div class="btnForm">
        <asp:Button ID="homeBtn" runat="server" Text="Back Home" OnClick="homeBtn_Click"/>
    </div>

</asp:Content>
