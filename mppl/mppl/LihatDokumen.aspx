<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LihatDokumen.aspx.cs" Inherits="mppl.FormDokumen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dokumen</h2>
    <asp:GridView ID="GridView_Dokumen" runat="server" OnRowDataBound="GridView_Dokumen_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:HyperLink ID="link_edit" runat="server">Edit</asp:HyperLink>
                    <asp:HyperLink ID="link_hapus" runat="server">Hapus</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:HyperLink ID="link_TambahDokumen" runat="server" 
        NavigateUrl="~/FormTambahDokumen.aspx">Tambah Dokumen</asp:HyperLink>
</asp:Content>

