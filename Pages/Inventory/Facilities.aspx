﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="Facilities.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.Facilities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />
    
    <div class="optionsMenuWrapper">
        <asp:Menu runat="server"
         Orientation="Vertical">
            <Items>
                <asp:MenuItem NavigateUrl="~/Pages/Inventory/AddEditFacility.aspx" Text="Add Facility"></asp:MenuItem>           
            </Items>
        </asp:Menu>
    </div>

   <div class="facilityTableWrapper">
   <asp:GridView
        ID="facilityGrid"
        runat="server"
        ShowHeaderWhenEmpty="true" 
        AutoGenerateSelectButton="true"
        OnSelectedIndexChanged="facilitySelected" >
    </asp:GridView>
    </div>
</asp:Content>