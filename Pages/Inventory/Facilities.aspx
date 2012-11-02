<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="Facilities.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.Facilities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView
     ID="facilityGrid"
     runat="server" >
    </asp:GridView>

</asp:Content>
