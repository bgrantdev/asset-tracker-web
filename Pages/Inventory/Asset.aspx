<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="Asset.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.Asset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br />

    <asp:DetailsView runat="server"
     ID="AssetDetails" >
       
    </asp:DetailsView>

</asp:Content>
