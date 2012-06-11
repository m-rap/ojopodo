<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formCekUI.aspx.cs" Inherits="mppl.mppl.formCekUI" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="act"%>
<asp:Content id="Content1" ContentPlaceHolderid="HeadContent" runat="server">
</asp:Content>
<asp:Content id="Content2" ContentPlaceHolderid="MainContent" runat="server">
    <act:ToolkitScriptManager id="ToolkitScriptManager1" runat="server">
    </act:ToolkitScriptManager>
    <center>
        <asp:Label id="lbl_judulHalaman" runat="server" text="Cek Dokumen" 
            font-bold="True" font-names="MS Reference Sans Serif" font-size="1em" ></asp:Label>
    </center>
    <div>
    <div style="height:70px">
    <div style="width:171px; float:left">
      <asp:Label id="lbl_judulDokumen" runat="server" text="Judul : " 
            font-names="MS Reference Sans Serif"></asp:Label>
        </div>
        <div style="">
        <asp:textBox id="txt_judulDokumen" runat="server" 
            font-names="MS Reference Sans Serif" textmode="MultiLine" 
            width="500px"></asp:textBox>
      </div>
    </div>
      <div style="height:37px">
      <div style="width:171px; float:left">
         <asp:Label id="lbl_namaPengarang" runat="server" 
            font-names="MS Reference Sans Serif" font-size="1em" 
            text="Nama Pengarang : "></asp:Label>
        </div>
         <div style="">
         <asp:textBox id="textBox1" runat="server" width="500px"></asp:textBox>
         </div>
      </div>
        
       <div style="height: 37px">
        <div>
        <div style="width:171px; float:left">
       <asp:Label id="lbl_pilihMode" runat="server" text="Pilih Mode"></asp:Label>
         </div>
            
         <div style="float:left;">
         <asp:RadioButtonList id="RadioButtonList1" runat="server" onSelectedIndexChanged="ganti" AutoPostBack="true">
         <asp:ListItem text="File" />
         <asp:ListItem text="Teks" />
            </asp:RadioButtonList>
      
         </div>
        </div>
         <br />
       </div>
        
        <div id="dinamikInput" >
        <asp:Panel id="Panel1" runat="server">
         <div>
        <asp:Label id="lbl_text" runat="server" text="Masukkan Teks : " 
                 font-names="MS Reference Sans Serif"></asp:Label>
        </div>
        <asp:textBox id="uploadtext" runat="server" Height="200px" textMode="MultiLine" 
                width="700px"></asp:textBox>
        </asp:Panel>
      
           
            
            <asp:Panel id="Panel2" runat="server">
              <div>
                <asp:Label id="lbl_file" runat="server" text="Pilih File"></asp:Label>
            </div>
            <asp:FileUpload id="upl_file" runat="server" />
            </asp:Panel>
            
         </div>
         <asp:Button id="cek" runat="server" text="cek" onclick="periksa" />
        
        <asp:Button id="progressCek" runat="server" Enabled="False" BackColor="Transparent" BorderColor="Transparent"/>
        <act:ModalPopupExtender id="progres_ModalPopup" runat="server" 
            DynamicServicePath="" Enabled="True" TargetControlid="progressCek" PopupControlid="loadingHasil" OkControlid="next">
        </act:ModalPopupExtender>
    </div>   
       
        
<asp:Label id="StatusLabel" runat="server" text="Label" Visible="False"></asp:Label>
<asp:Panel id="loadingHasil" runat="server">Loading. . .
<asp:Button id="next" runat="server" text="next" onclick="next_Click" />
<act:ModalPopupExtender id="cek_ModalPopup" runat="server" 
            DynamicServicePath="" Enabled="True"  DropShadow="true" TargetControlid="next" PopupControlid="formHasil" OkControlid="tutupHasil">
        </act:ModalPopupExtender>
<asp:Button id="cancel" runat="server" text="Cancel"/>
</asp:Panel>
<asp:Panel id="formHasil" runat="server" BackColor="White" width="100%" Height="100%">
    <div align="center">
    
        <asp:Label id="LabelHasilCek" runat="server" text="Hasil Pengecekan" 
            font-bold="True" font-names="Microsoft Sans Serif" font-size="1em"></asp:Label>
    
    </div>
    <div><asp:Label id="lbl_judul" runat="server" text="Judul Karya Anda:" 
            font-names="Microsoft Sans Serif" font-size="1em"></asp:Label>
        <asp:Label id="judulText" runat="server" text="label" 
            font-names="Microsoft Sans Serif" font-size="1em"></asp:Label>
    </div>
    <div>
        <asp:Label id="lbl_hasil" runat="server" text="Hasil Pengecekan" 
            font-names="Microsoft Sans Serif" font-size="1em"></asp:Label>

        <asp:GridView id="grv_hasil" runat="server" font-names="Microsoft San serif" 
            font-size="1em" width="433px" AllowPaging="True" AllowSorting="True" 
            BorderStyle="Dashed">
        </asp:GridView>
        <asp:Button id="tutupHasil" text="Close this window" runat="server"/>
    </div>
    </asp:Panel>
</asp:Content>