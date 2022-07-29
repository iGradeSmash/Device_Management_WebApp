<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.cs" Inherits="Device_Management_Web.Dashboard" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
    <div class="">
        <h2>Avaiable Devices</h2>
    </div>
    <div class="container">
        <asp:PlaceHolder ID="MainTable" runat="server">

        </asp:PlaceHolder>
    </div>
</asp:Content>
