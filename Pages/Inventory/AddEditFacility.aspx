<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="AddEditFacility.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.AddEditFacility" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />

    <div>
        <asp:Menu runat="server" Orientation="Vertical">
            <Items>
                <asp:MenuItem NavigateUrl="~/Pages/Inventory/Facilities.aspx" Text="Facilities"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </div>

    <asp:Label runat="server" Text="Name:"></asp:Label>
    <asp:TextBox runat="server" ID="FacilityName"></asp:TextBox>

    <br /><br />

    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="submitFacility"/>

</asp:Content>
