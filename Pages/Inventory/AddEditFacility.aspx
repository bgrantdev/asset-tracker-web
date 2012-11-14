<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="AddEditFacility.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.AddEditFacility" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />

    <div class="formWrapper">
    <asp:Label CssClass="label" runat="server" Text="Name:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="FacilityName"></asp:TextBox>
    
    <br /><br />

    <asp:Button CssClass="submit_button" ID="SubmitButton" runat="server" Text="Submit" OnClick="submitFacility"/>
    </div>
</asp:Content>
