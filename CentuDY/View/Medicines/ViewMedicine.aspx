<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navigation.Master" AutoEventWireup="true" CodeBehind="ViewMedicine.aspx.cs" Inherits="CentuDY.View.Medicines.ViewMedicines" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>View Medicine</h2>
    <div>
        <asp:Label ID="SearchLabel" runat="server" Text="Search "></asp:Label>
        <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
        <asp:Button ID="SearchButton" runat="server" Text="Search" OnClick="search" />
        </br>
        <asp:Button ID="ClearSearchButton" runat="server" Text="Clear Search" OnClick="searchClear" />
    </div>
    <div>
        <asp:GridView ID="MedicineTable" runat="server" >
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="CartLink"  runat="server" Text="Add to Cart" CommandArgument='<%#Eval("MedicineId") %>' OnClick="addToCartMedicine"  Visible="True" />
                        <asp:LinkButton ID="UpdateLink"  runat="server" Text="Update" CommandArgument='<%#Eval("MedicineId") %>' OnClick="updateMedicine"  Visible="False" />
                        <asp:LinkButton ID="DeleteLink" runat="server" Text="Delete" CommandArgument='<%#Eval("MedicineId") %>' OnClick="deleteMedicine" Visible="False" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="insertButton" runat="server" Text="Insert Medicine" OnClick="goToInsert" Visible="False" />
        <br />
    </div>
</asp:Content>
