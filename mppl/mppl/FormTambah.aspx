<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormTambah.aspx.cs" Inherits="mppl.FormTambah" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FileUpload ID="FileUploadControl" runat="server" />
    <br />
    <asp:Button ID="UploadBtn" runat="server" onclick="UploadClick" Text="Button" />
    <br />
    <asp:Label ID="StatusLabel" runat="server" Text="Label" Visible="False"></asp:Label>
</asp:Content>