<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CentuDY.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Login to Centudy</h2>
    <div class="contentForm-short">
        <div>
            <asp:Label ID="UsernameLabel" runat="server" Text="Username:"></asp:Label><br />
            <asp:TextBox ID="UsernameBox" runat="server" ></asp:TextBox>
            <br />

            <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label><br />
            <asp:TextBox ID="PasswordBox" runat="server" TextMode="Password"></asp:TextBox>
            <br />

            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me"  />
        </div>
        <br />

        <div class="form-buttons">
            <asp:Button ID="LoginButton" runat="server" Text="Login"  OnClick="login" />
            <asp:Button ID="RegisterButton" runat="server" text="Register" OnClick="RegisterButton_Click" />
        </div>
        <div class="error-message">
            <asp:Label ID="ErrorMessage" runat="server" Text="" CssClass="warning-text"></asp:Label>
        </div>
    </div>
</asp:Content>
