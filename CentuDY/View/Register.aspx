<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CentuDY.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h2>Register to Centudy</h2>
    <div>
        <div class="contentForm-short">
            <asp:Label ID="UsernameLabel" runat="server" Text="Username:"></asp:Label>&nbsp<br />
            <asp:TextBox ID="UsernameBox" runat="server" Width="100%"></asp:TextBox>
            <br />

            <asp:Label ID="PasswordLabel" runat="server" Text="Password:"></asp:Label>&nbsp<br />
            <asp:TextBox ID="PasswordBox" runat="server" TextMode="Password" Width="100%"></asp:TextBox>
            <br />

            <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Confirm Password:"></asp:Label>&nbsp<br />
            <asp:TextBox ID="ConfirmPasswordBox" runat="server" TextMode="Password" Width="100%"></asp:TextBox>
            <br />

            <asp:Label ID="NameLabel" runat="server" Text="Name:"></asp:Label>&nbsp<br />
            <asp:TextBox ID="NameBox" runat="server" Width="100%"></asp:TextBox>
            <br />

            <asp:Label ID="GenderLabel" runat="server" Text="Gender:"></asp:Label><br />
            <asp:RadioButtonList ID="GenderButtons" runat="server" Width="100%">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
       
            <asp:Label ID="PhoneLabel" runat="server" Text="Phone Number:"></asp:Label>&nbsp<br />
            <asp:TextBox ID="PhoneBox" runat="server" TextMode="Number" Width="100%"></asp:TextBox>
            <br />

            <asp:Label ID="AddressLabel" runat="server" Text="Address"></asp:Label>&nbsp<br />
            <asp:TextBox ID="AddressBox" runat="server"  Width="100%"></asp:TextBox>
            <br />
        </div>
        <br />
        <br />
        <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="registration" />&nbsp
        <asp:Label ID="ErrorMessage" runat="server" CssClass="warning-text" Text=""></asp:Label>
    </div>
</asp:Content>
