<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="AddEditAsset.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.AddEditAsset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />

    <div class="formWrapper">
    <asp:Label CssClass="label" runat="server" Text="Name:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="AssetName"></asp:TextBox>
    <br />

    <asp:Label CssClass="label" runat="server" Text="SKU:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="AssetSku"></asp:TextBox>
    <br /><br />

    <asp:Button runat="server" ID="SubmitButton" Text="Submit" OnClick="submitAsset" /> 
    </div>

</asp:Content>
