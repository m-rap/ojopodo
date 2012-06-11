<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formCekUI.aspx.cs" Inherits="mppl.mppl.formCekUI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act"%>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <act:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </act:ToolkitScriptManager>
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
        
        <asp:Button ID="progressCek" runat="server" Enabled="False" BackColor="Transparent" BorderColor="Transparent"/>
        <act:ModalPopupExtender ID="progres_ModalPopup" runat="server" 
            DynamicServicePath="" Enabled="True" TargetControlID="progressCek" PopupControlID="loadingHasil" OkControlID="next">
        </act:ModalPopupExtender>
    </div>   
       
        
<asp:Label ID="StatusLabel" runat="server" Text="Label" Visible="False"></asp:Label>
<asp:Panel ID="loadingHasil" runat="server">Loading
<asp:Button ID="next" runat="server" Text="next" onclick="next_Click" />
<act:ModalPopupExtender ID="cek_ModalPopup" runat="server" 
            DynamicServicePath="" Enabled="True"  DropShadow="true" TargetControlID="next" PopupControlID="formHasil" OkControlID="tutupHasil">
        </act:ModalPopupExtender>
<asp:Button id="cancel" runat="server" Text="Cancel"/>
</asp:Panel>
<asp:Panel id="formHasil" runat="server" BackColor="White" Width="100%" Height="100%">
    <div align="center">
    
        <asp:Label ID="LabelHasilCek" runat="server" Text="Hasil Pengecekan" 
            Font-Bold="True" Font-Names="Microsoft Sans Serif" Font-Size="1em"></asp:Label>
    
    </div>
    <div><asp:Label ID="lbl_judul" runat="server" Text="Judul Karya Anda:" 
            Font-Names="Microsoft Sans Serif" Font-Size="1em"></asp:Label>
        <asp:Label ID="judulText" runat="server" Text="label" 
            Font-Names="Microsoft Sans Serif" Font-Size="1em"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lbl_hasil" runat="server" Text="Hasil Pengecekan" 
            Font-Names="Microsoft Sans Serif" Font-Size="1em"></asp:Label>

        <asp:GridView ID="grv_hasil" runat="server" Font-Names="Microsoft San serif" 
            Font-Size="1em" Width="433px" AllowPaging="True" AllowSorting="True" 
            BorderStyle="Dashed">
        </asp:GridView>
        <asp:Button ID="tutupHasil" Text="Close this window" runat="server"/>
    </div>
    </asp:Panel>
</asp:Content>