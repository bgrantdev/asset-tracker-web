<%@ Page Title="" Language="C#" MasterPageFile="~/AssetTracker.Master" AutoEventWireup="true" CodeBehind="AddEditFacility.aspx.cs" Inherits="asset_tracker_web.Pages.Inventory.AddEditFacility" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />

    <div class="formWrapper">
    <asp:Label CssClass="label" runat="server" Text="Name:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="FacilityName"></asp:TextBox>
    <br />
    <asp:Label CssClass="label" runat="server" Text="Address:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="Address1"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" CssClass="label" runat="server" Text="Address 2:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="Address2"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" CssClass="label" runat="server" Text="City:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="CityName"></asp:TextBox>
    <br />
    <asp:Label ID="Label1" CssClass="label" runat="server" Text="State:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="StateName"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" CssClass="label" runat="server" Text="Zip:"></asp:Label>
    <br />
    <asp:TextBox CssClass="field" runat="server" ID="ZipName"></asp:TextBox>
    <br />
    <br /><br />

    <asp:Button CssClass="submit_button" ID="SubmitButton" runat="server" Text="Submit" OnClick="submitFacility" />
    </div>
</asp:Content>
