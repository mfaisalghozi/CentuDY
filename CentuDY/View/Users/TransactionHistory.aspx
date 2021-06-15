<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="CentuDY.View.Users.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>My Transaction History</h2>
    <div>
        <asp:GridView ID="TransactionHistoryTable" runat="server">
            
        </asp:GridView>
        <br />
    </div>
    <asp:Label ID="GrandTotal" runat="server" Text=""></asp:Label>
    <asp:Button ID="HomeBtn" runat="server" Text="Home" OnClick="HomeBtn_Click" />
</asp:Content>
