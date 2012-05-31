<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HasilCekDokumenUI.aspx.cs" Inherits="mppl.HasilCekDokumenUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Label ID="lbl_judulHalaman" runat="server" Text="Hasil Pengecekan" 
            Font-Bold="True" Font-Names="Microsoft Sans Serif" Font-Size="1em"></asp:Label>
    
    </div>
    <div><asp:Label ID="lbl_judul" runat="server" Text="Judul Karya Anda:" 
            Font-Names="Microsoft Sans Serif" Font-Size="1em"></asp:Label></div>
    <div>
        <asp:Label ID="lbl_hasil" runat="server" Text="Hasil Pengecekan" 
            Font-Names="Microsoft Sans Serif" Font-Size="1em"></asp:Label>

        <asp:GridView ID="grv_hasil" runat="server" Font-Names="Microsoft San serif" 
            Font-Size="1em" Width="433px" AllowPaging="True" AllowSorting="True" 
            BorderStyle="Dashed" 
            onselectedindexchanged="grv_hasil_SelectedIndexChanged">
        </asp:GridView>

    </div>
    </form>
</body>
</html>
