<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="CentuDY.View.Users.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Profile Page</h1>
    <div>
            <asp:Label ID="UsernameLabel" runat="server" Text="Username:"></asp:Label>&nbsp<br />
            <asp:TextBox ID="UsernameBox" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="NameLabel" runat="server" Text="Name:"></asp:Label>&nbsp<br />
            <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="GenderLabel" runat="server" Text="Gender:"></asp:Label><br />
            <asp:RadioButtonList ID="GenderButtons" runat="server">
                <asp:ListItem ID="male" Text="Male"></asp:ListItem>
                <asp:ListItem ID="female" Text="Female"></asp:ListItem>
            </asp:RadioButtonList>
       
            <asp:Label ID="PhoneLabel" runat="server" Text="Phone Number:"></asp:Label>&nbsp<br />
            <asp:TextBox ID="PhoneBox" runat="server" TextMode="Number"></asp:TextBox>
            <br />

            <asp:Label ID="AddressLabel" runat="server" Text="Address"></asp:Label>&nbsp<br />
            <asp:TextBox ID="AddressBox" runat="server"></asp:TextBox>
         <br />
         <br />
         <div class="form-buttons">
                <div>
                    <asp:Button ID="BackToHomeBtn" runat="server" Text="Home" OnClick="BackToHomeBtn_Click" />
                    <asp:Button ID="UpdateProfileBtn" runat="server" Text="Update" OnClick="UpdateProfileBtn_Click"/>
                </div>
         </div>
         <div>
                <asp:Label ID="SuccessMessage" runat="server" CssClass="success-text"></asp:Label>
         </div>
    </div>
</asp:Content>
