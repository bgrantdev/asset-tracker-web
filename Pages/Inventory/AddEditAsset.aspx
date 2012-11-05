<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="AddEditAsset.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.AddEditAsset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label runat="server" Text="Name:"></asp:Label>
    <asp:TextBox runat="server" ID="assetName"></asp:TextBox>
    <br />

    <asp:Label  runat="server" Text="SKU:"></asp:Label>
    <asp:TextBox runat="server" ID="assetSku"></asp:TextBox>
    <br />

    <asp:Button runat="server" ID="SubmitButton" Text="Submit" OnClick="addAsset" /> 

</asp:Content>
