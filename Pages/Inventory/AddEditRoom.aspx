<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="AddEditRoom.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.AddEditRoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />

    <asp:Panel ID="MessagePanel" CssClass="" Visible="false" runat="server">
        <asp:Label ID="Message" runat="server"></asp:Label>
    </asp:Panel>

    <asp:Label runat="server" Text="Name:"></asp:Label>
    <asp:TextBox runat="server" ID="RoomName" ></asp:TextBox>

    <br /><br />

    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="submitRoom" />

</asp:Content>
