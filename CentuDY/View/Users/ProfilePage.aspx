<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="CentuDY.View.Users.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile Info Page</h1>
    <div class="contentForm - short">
           <div>
                <asp:Label ID="UsernameLabel" runat="server" Text=""></asp:Label><br />
                <br />
                <asp:Label ID="PasswordLabel" runat="server" Text=""></asp:Label><br />
                <br />
                <asp:Label ID="NameLabel" runat="server" Text=""></asp:Label><br />
                <br />
                <asp:Label ID="GenderLabel" runat="server" Text=""></asp:Label><br />
                <br />
                <asp:Label ID="PhoneNumbLabel" runat="server" Text=""></asp:Label><br />
                <br />
                <asp:Label ID="AddressLabel" runat="server" Text=""></asp:Label><br />
                <br />
           </div>
    </div>   
</asp:Content>
