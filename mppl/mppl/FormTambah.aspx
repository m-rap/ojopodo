<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormTambah.aspx.cs" Inherits="mppl.FormTambah" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUploadControl" runat="server" />
        <br />
        <asp:Button ID="UploadBtn" runat="server" onclick="UploadClick" Text="Button" />
        <br />
        <asp:Label ID="StatusLabel" runat="server" Text="Label" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
