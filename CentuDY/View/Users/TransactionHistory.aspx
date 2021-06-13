<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="CentuDY.View.Users.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>My Transaction History</h2>
    <div>
        <asp:GridView ID="ViewTransactionTable" runat="server" AutoGenerateColumns="False" DataSourceID="TransactionSource" DataKeyNames="TransactionId">
            <Columns>
               <asp:BoundField DataField="Medicine Name" HeaderText="Medicine Name" SortExpression="Medicine Name" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Sub Total" HeaderText="Sub Total" SortExpression="Sub Total" />
                <asp:BoundField DataField="Grand Total" HeaderText="Grand Total" SortExpression="Grand Total" />
            </Columns>
        </asp:GridView>
        <br />
    </div>

</asp:Content>
