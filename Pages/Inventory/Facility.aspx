<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="Facility.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.Facility" %>
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
                <asp:MenuItem NavigateUrl="~/Pages/Inventory/AddEditRoom.aspx" Text=" Add  Room " Value="AddRoom"></asp:MenuItem>           
            </Items>
        </asp:Menu>
    </div>

    <div class="infoTableWrapper">
    <asp:GridView
        ID="roomGrid"
        runat="server"
        ShowHeaderWhenEmpty="true" 
        AutoGenerateSelectButton="true"
        OnSelectedIndexChanged="roomSelected"
        CssClass="infoGrid"
        AlternatingRowStyle-CssClass="alt" >
    </asp:GridView>
    </div>

</asp:Content>
