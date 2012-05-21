<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormDokumen.aspx.cs" Inherits="mppl.FormDokumen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dokumen</h2>
    <asp:GridView ID="GridView_Dokumen" runat="server">
    </asp:GridView>
    <br />
    <h3>Tambah Dokumen Baru</h3>
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
            <td>Alamat Fingerprint:</td>
            <td><asp:TextBox ID="TextBox_AlamatFingerprint" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="Button_Submit" runat="server" Text="Submit" 
                    onclick="Button_Submit_Click" /></td>
        </tr>
    </table>
</asp:Content>

