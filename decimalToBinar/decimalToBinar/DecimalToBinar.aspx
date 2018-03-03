<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DecimalToBinar.aspx.cs" Inherits="decimalToBinar.DecimalToBinar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="Insert decimal number:"></asp:Label>
    <asp:TextBox id="decimalNumber" runat="server" />
    <asp:Button runat="server" OnClick="convert" Text="Convert number" />
    <asp:Label runat="server" ID="binarNumber" Text=""></asp:Label>
</asp:Content>
