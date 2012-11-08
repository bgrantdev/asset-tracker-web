<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.Room" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />

    <div class="optionsMenuWrapper">
        <asp:Menu ID="OptionsMenu"
            runat="server"
            Orientation="Vertical"
            CssClass="optionsMenu" >
            <Items>
                <asp:MenuItem Text="Add Asset" Value="AddAsset"></asp:MenuItem>            
            </Items>
            </asp:Menu>
    </div>

    <div class="infoTableWrapper">
    <asp:GridView
        ID="assetGrid"
        runat="server"
        ShowHeaderWhenEmpty="true" 
        AutoGenerateSelectButton="true"
        OnSelectedIndexChanged="assetSelected"
        CssClass="infoGrid" >
    </asp:GridView>    
    </div>

</asp:Content>
