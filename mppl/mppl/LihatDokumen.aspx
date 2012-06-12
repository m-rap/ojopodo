<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LihatDokumen.aspx.cs" Inherits="mppl.FormDokumen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dokumen</h2>
    <asp:GridView ID="GridView_Dokumen" runat="server" 
        OnRowDataBound="GridView_Dokumen_RowDataBound" CellPadding="4" 
        AllowPaging="True"
        PageSize="10"
        OnPageIndexChanging="GridView_Dokumen_PageIndexChanging" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:HyperLink ID="link_edit" runat="server">Edit</asp:HyperLink>
                    <asp:HyperLink ID="link_hapus" runat="server">Hapus</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:HyperLink ID="link_TambahDokumen" runat="server" 
        NavigateUrl="~/FormTambahDokumen.aspx">Tambah Dokumen</asp:HyperLink>
</asp:Content>

