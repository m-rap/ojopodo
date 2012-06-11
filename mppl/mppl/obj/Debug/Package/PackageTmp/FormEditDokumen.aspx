<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormEditDokumen.aspx.cs" Inherits="mppl.FormEditDokumen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>Judul:</td>
            <td><asp:TextBox ID="TextBox_Judul" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Pengarang:</td>
            <td><asp:TextBox ID="TextBox_Pengarang" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>URL Asal Dokumen:</td>
            <td><asp:TextBox ID="TextBox_UrlDokumen" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="UpdateBtn" runat="server" Text="Simpan" 
    onclick="UpdateBtn_Click" />
    <br />
    <asp:LinkButton ID="KembaliLinkButton" runat="server" PostBackUrl="~/LihatDokumen.aspx">Kembali</asp:LinkButton>
    <asp:Label ID="StatusLabel" runat="server" Text="Label" Visible="False"></asp:Label>
</asp:Content>
