<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="Asset.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.Asset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="optionsMenuWrapper">
        <asp:Menu ID="OptionsMenu"
         runat="server"
         Orientation="Vertical"
         CssClass="optionsMenu"
         IncludeStyleBlock="false" >
            <Items>
                <asp:MenuItem Text=" Edit Asset " Value="EditAsset"></asp:MenuItem>           
            </Items>
        </asp:Menu>
    </div>

    <div class="infoTableWrapper">
    <asp:Label ID="FacilityLabel" runat="server" Font-Size="X-Large" Font-Bold="true" Font-Names="Lucida Sans, Sans-Serif" Text="Facility Name: " />
    <asp:Label ID="FacilityName" runat="server" Font-Size="X-Large" ForeColor="#0054A3" Font-Names="Lucida Sans, Sans-Serif" />
    <br /><br />
    <asp:Label ID="RoomLabel" runat="server" Font-Size="X-Large" Font-Bold="true" Font-Names="Lucida Sans, Sans-Serif" Text="Room Name: " />
    <asp:Label ID="RoomName" runat="server" Font-Size="X-Large" ForeColor="#0054A3" Font-Names="Lucida Sans, Sans-Serif" />

    <br /><br />

    <asp:DetailsView runat="server"
     ID="AssetDetails"
     CssClass="assetGrid" 
     HeaderText="Details"
     HeaderStyle-BackColor="#D9D7D7" >
       
    </asp:DetailsView>
    </div>
</asp:Content>
