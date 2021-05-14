<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="UpdateMedicine.aspx.cs" Inherits="CentuDY.View.Medicines.UpdateMedicine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Update Medicine</h2>
    <div class="contentForm-short">
            <div>
                <asp:Label ID="NameLabel" runat="server">Name:</asp:Label><br />
                <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="DescriptionLabel" runat="server">Description:</asp:Label><br />
                <asp:TextBox ID="DescriptionBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="PriceLabel" runat="server">Price:</asp:Label><br />
                <asp:TextBox ID="PriceBox" runat="server" TextMode="Number"></asp:TextBox>
                <br />
                <asp:Label ID="StockLabel" runat="server">Stock:</asp:Label><br />
                <asp:TextBox ID="StockBox" runat="server" TextMode="Number"></asp:TextBox>
                <br />
            </div>
            <br />
            <div class="form-buttons">
                <div>
                    <asp:Button ID="UpdateMedicineButton" runat="server" Text="Update" OnClick="updateMedicine"/>
                </div>
            </div>
            <div>
                <asp:Label ID="ErrorMessage" runat="server" CssClass="warning-text"></asp:Label>
            </div>
    </div>
</asp:Content>
