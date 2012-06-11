<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="mppl._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="web_des" style="margin:50px 50px 50px 50px;">
        <p>
            Ojo Podo adalah alat untuk mendeteksi tingkat plagiarisme suatu dokumen 
            (doc, docx, pdf). Kami memiliki database dokumen yang menyimpan lebih dari 100
             dokumen dan akan terus berkembang. Saat ini, Ojo Podo terus meningkatkan efisiensi
             algoritma pendeteksian algoritma untuk mencapai hasil yang akurat dan cepat.
        </p>
        <p>
            Aplikasi ini dikembangkan oleh tim pengembang jurusan Teknik Informatika ITS Surabaya
             untuk membantu proses pendeteksian plagiarisme di lingkungan kampus.
        </p>
    </div>
    <div id="Div1" style="margin:50px 50px 50px 50px;">
    <div id="buttonmulai" style="float:right;">
        <asp:Button ID="btn_mulai" runat="server" Text="Mulai Pengecekan" 
            onclick="btn_mulai_Click" Font-Bold="True" 
            Font-Names="Microsoft Sans Serif" Font-Size="1em" Height="25px"/>
    </div>
    </div>
</asp:Content>
