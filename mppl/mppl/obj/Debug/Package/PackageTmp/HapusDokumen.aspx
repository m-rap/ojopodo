<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HapusDokumen.aspx.cs" Inherits="mppl.HapusDokumen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1>Menghapus Dokumen</h1>
Anda yakin akan menghapus dokumen dengan data di bawah ini?
    <asp:Label ID="Label_id" runat="server" Visible="False"></asp:Label>
<table>
    <tr>
        <td>Judul:</td>
        <td>
            <asp:Label ID="Label_judul" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Pengarang:</td>
        <td>
            <asp:Label ID="Label_pengarang" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>URL Asal Dokumen:</td>
        <td>
            <asp:Label ID="Label_urlDokumen" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Alamat fingerprint:</td>
        <td>
            <asp:Label ID="Label_alamat_fingerprint" runat="server"></asp:Label>
        </td>
    </tr>
</table>
<asp:Button ID="Btn_ya" runat="server" Text="Ya" onclick="Btn_ya_Click" />
    <asp:Button ID="Btn_tidak" runat="server" Text="Tidak" 
        onclick="Btn_tidak_Click" />
</asp:Content>
