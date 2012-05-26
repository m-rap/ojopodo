<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formCekUI.aspx.cs" Inherits="mppl.mppl.formCekUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <asp:Label ID="lbl_judulHalaman" runat="server" Text="Cek Dokumen" 
            Font-Bold="True" Font-Names="MS Reference Sans Serif" Font-Size="1em" ></asp:Label>
    </center>
    <div>
    <div style="height:70px">
    <div style="width:171px; float:left">
      <asp:Label ID="lbl_judulDokumen" runat="server" Text="Judul : " 
            Font-Names="MS Reference Sans Serif"></asp:Label>
        </div>
        <div style="">
        <asp:TextBox ID="txt_judulDokumen" runat="server" 
            Font-Names="MS Reference Sans Serif" TextMode="MultiLine" 
            Width="500px"></asp:TextBox>
      </div>
    </div>
      <div style="height:37px">
      <div style="width:171px; float:left">
         <asp:Label ID="lbl_namaPengarang" runat="server" 
            Font-Names="MS Reference Sans Serif" Font-Size="1em" 
            Text="Nama Pengarang : "></asp:Label>
        </div>
         <div style="">
         <asp:TextBox ID="TextBox1" runat="server" Width="500px"></asp:TextBox>
         </div>
      </div>
        
       <div style="height: 37px">
        <div>
        <div style="width:171px; float:left">
       <asp:Label ID="lbl_pilihMode" runat="server" Text="Pilih Mode"></asp:Label>
         </div>
            
         <div style="float:left;">
         <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="ganti" AutoPostBack="true">
         <asp:ListItem Text="File" />
         <asp:ListItem Text="Teks" />
            </asp:RadioButtonList>
         <!--
           <asp:RadioButton ID="rdo_modeTeks" runat="server" Text="Teks" Checked="true" 
                   oncheckedchanged="teks" AutoPostBack="true"/>
         <asp:RadioButton ID="rdo_modeUpload" runat="server" Text="File" 
                 OnCheckedChanged="upload" AutoPostBack="true"/>-->
         <!--<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
           </asp:ScriptManager>
           <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
           <ContentTemplate>
            <
                 <br />
                 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                 
           </ContentTemplate>
          
           </asp:UpdatePanel>-->
         
         </div>
         
        </div>
         <br />
           
           
           
       </div>
        
        <div id="dinamikInput" >
        <asp:Panel ID="Panel1" runat="server">
         <div>
        <asp:Label ID="lbl_text" runat="server" Text="Masukkan Teks : " 
                 Font-Names="MS Reference Sans Serif"></asp:Label>
        </div>
        <asp:TextBox ID="uploadText" runat="server" Height="200px" TextMode="MultiLine" 
                Width="700px"></asp:TextBox>
        </asp:Panel>
      
           
            
            <asp:Panel ID="Panel2" runat="server">
              <div>
                <asp:Label ID="lbl_file" runat="server" Text="Pilih File"></asp:Label>
            </div>
            <asp:FileUpload ID="upl_file" runat="server" />
            </asp:Panel>
            
         </div>
         <asp:Button ID="cek" runat="server" Text="cek" onclick="periksa" />
    </div>   
       
        
    </div>
    </form>
</body>
</html>
