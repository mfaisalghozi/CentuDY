<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="CentuDY.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="WelcomeMessageLabel" runat="server" Text=""></asp:Label>
    <asp:GridView ID="MedicineRandomTable" runat="server" >
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="CartLink"  runat="server" Text="Add to Cart" CommandArgument='<%#Eval("MedicineId") %>' OnClick="addToCartMedicine"  Visible="True" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </br>
    <asp:Button ID="ViewMedicinesBtn" runat="server" Text="View Medicines" OnClick="GoToViewMedicines" />
    </br>
    <asp:Button ID="InsertMedicineButton" runat="server" Text="Insert Medicine" OnClick="goToInsertMedicine" Visible="False" />
    </br>
    <asp:Button ID="ViewCartButton" runat="server" Text="View Cart" OnClick="goToViewCart" Visible="True" />
    </br>
    <asp:Button ID="ViewProfileBtn" runat="server" Text="Profile Info" OnClick="ViewProfileBtn_Click" Visible="true"/>
    </br> 
    </br>
    <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="logout" />
</asp:Content>
