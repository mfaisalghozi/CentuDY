<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CentuDY.View.Users.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Change Password Page</h1>
    <div>
        <asp:Label ID="currentPassLabel" runat="server" Text=""></asp:Label>
        <br /><br />

        <asp:Label ID="OldPasswordLabel" runat="server" Text="Old Password:"></asp:Label>&nbsp<br />
        <asp:TextBox ID="OldPasswordBox" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />

        <asp:Label ID="NewPasswordLabel" runat="server" Text="New Password:"></asp:Label>&nbsp<br />
        <asp:TextBox ID="NewPasswordBox" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />
    
        <asp:Label ID="ConfirmNewPasswordLabel" runat="server" Text="Confirm New Password:"></asp:Label>&nbsp<br />
        <asp:TextBox ID="ConfirmNewPasswordBox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
    </div>
     <br />
        <div class="form-buttons">
            <div>
                <asp:Button ID="BackToHomeBtn" runat="server" Text="Home" OnClick="BackToHomeBtn_Click" />
                <asp:Button ID="changePasswordBtn" runat="server" Text="Change Password" OnClick="changePasswordBtn_Click"/>
            </div>
        </div>
        <div>
            <br />
            <asp:Label ID="SuccessMessage" runat="server" CssClass="success-text"></asp:Label>
            <asp:Label ID="ErrorMessage" runat="server" CssClass="warning-text"></asp:Label>
        </div>
</asp:Content>
