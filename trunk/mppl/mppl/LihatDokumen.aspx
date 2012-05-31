<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LihatDokumen.aspx.cs" Inherits="mppl.FormDokumen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dokumen</h2>
    <asp:GridView ID="GridView_Dokumen" runat="server">
    </asp:GridView>
    <asp:LinkButton ID="LinkButton_TambahDokumen" runat="server" 
        PostBackUrl="~/FormTambah.aspx">Tambah Dokumen</asp:LinkButton>
</asp:Content>

