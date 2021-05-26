<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="CentuDY.View.Carts.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>View Cart</h1>
    <asp:GridView ID="CartTable" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="MedicineId" >
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="CartLink"  runat="server" Text="Delete" CommandArgument='<%#Eval("MedicineId") %>' OnClick="deleteCart"  />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" ReadOnly="True" SortExpression="SubTotal" />
            <asp:BoundField DataField="MedicineId" HeaderText="MedicineId" InsertVisible="False" ReadOnly="True" SortExpression="MedicineId" Visible="False"/>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="CentuDY.App_Code.CartDatasetTableAdapters.DataTable1TableAdapter"></asp:ObjectDataSource>
    <br />
    <div>
        <br />
        <asp:Label ID="totalLabel" runat="server" Font-Bold="True" Text="Grand Total : Rp. "></asp:Label>
        <asp:Label ID="totalLabelValue" runat="server" Font-Italic="True"></asp:Label>
    <br />
    </div>
    <br />
    <br />
    <asp:Label ID="ErrorMessageLabel" runat="server" Text="" />
    <br />
    <asp:Button ID="CheckoutButton" runat="server" OnClick="checkout" Text="Checkout" />
</asp:Content>
