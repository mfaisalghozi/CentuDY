<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="CentuDY.View.Admin.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>User Information</h2>
    <div>
        <asp:GridView ID="ViewUserTable" runat="server" OnRowCommand="ViewUserTable_RowCommand" >
            <Columns>
                <asp:ButtonField ButtonType="Button" Text="Delete User"  />
            </Columns>
        </asp:GridView>
        <br />
    </div>
</asp:Content>
