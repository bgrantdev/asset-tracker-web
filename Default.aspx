<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/AssetTracker.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="asset_tracker_web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <div class="introWrapper">
        <asp:Label runat="server" Font-Bold="true" Font-Names="Lucida Sans, Sans-Serif" Font-Size="XX-Large" Fo Text="Welcome!"></asp:Label>
        <br />
        <p class="info">
        Welcome to the RBSCRP asset tracker, you can use this web application in conjunction with the RBSCRP asset tracker mobile application in order to keep track of all of your companies assets.
        </p>
        <br /><br />

        <asp:Label runat="server" Font-Bold="true" Font-Names="Lucida Sans, Sans-Serif" Font-Size="X-Large" Text="Inventory Manager"></asp:Label>
        <br />
        <p class="info">
        The inventory manager allows you to add assets from anywhere you have an internet connection. You will have the ability to add and edit your facilities, rooms, and assets to your company. When synchronized with the RBSCRP Asset Tracker mobile application for your phone you will be able to update from your phone or online. Any updates made with your phone will be visible here as well. You will also be able to view detailed information about each of your facilities. You can assess assets in your facilities simply by downloading the mobile application to any anroid phone with a camera. The phone can be used to scan barcodes that you create with our barcode manager.
        </p>
        <br /><br />
        <asp:Label runat="server" Font-Bold="true" Font-Names="Lucida Sans, Sans-Serif" Font-Size="X-Large" Text="Barcode Manager"></asp:Label>
        <br />
        <p class="info">
        The barcode manager portion of this application can be used to create barcodes that can be printed out and attached to assets that you wish to keep track of. These created barcodes and their sku numbers can be assigned to assets contained within your the rooms of your facility.
        </p>
        <br />

    </div>

</asp:Content>
