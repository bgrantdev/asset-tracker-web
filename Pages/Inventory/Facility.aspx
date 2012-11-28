﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="Facility.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.Facility" %>
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
                <asp:MenuItem Text="Edit Facility" Value="EditFacility" />
                <asp:MenuItem Text="Add Room" Value="AddRoom" />           
            </Items>
        </asp:Menu>
    </div>

    <div class="infoTableWrapper">

    <asp:Label ID="FacilityName" runat="server" Font-Size="X-Large" Font-Bold="true" Font-Names="Lucida Sans" />
    <br /><br />
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
