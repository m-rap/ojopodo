<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="mppl.LoginAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="banner2">
       <table id="mainTable" border="0">
        <tr>
        <td>
        <table class="t_border" id="loginTable" cellspacing="15" cellpadding="0">
        <tr>
        <td><b>Login: </b>
        </td>
        <td><asp:textbox id="txtUserName" runat="server" width="160px" ></asp:textbox><asp:requiredfieldvalidator id="rvUserValidator" runat="server" controltovalidate="txtUserName" errormessage="You must supply a Username!"
        display="None"></asp:requiredfieldvalidator></td>
        </tr>
        <tr>
        <td><b>Password: </b>
        </td>
        <td><asp:textbox id="txtPassword" runat="server" width="160px" textmode="Password"></asp:textbox><asp:requiredfieldvalidator id="rvPasswordValidator" runat="server" controltovalidate="txtPassword" errormessage="Empty Passwords not accepted"
        display="None"></asp:requiredfieldvalidator></td>
        </tr>
        <tr>
        <td align="center" colspan="2"><asp:button id="cmdSubmit" runat="server" 
                text="Submit" borderstyle="Solid" onclick="cmdSubmit_Click"></asp:button></td>
        </tr>
        </table>
        </td>
        </tr>
        <tr>
        <td>
        <table id="messageDisplay">
        <tr>
        <td><asp:validationsummary id="Validationsummary1" runat="server" width="472px" displaymode="BulletList"></asp:validationsummary></td>
        </tr>
        </table>
        <!--<asp:hyperlink id="hl_Register" runat="server" navigateurl="Register.aspx" font-size="X-Small"
        height="8px" width="209px" font-names="MS Reference Sans Serif">New User?...Register Here!</asp:hyperlink>-->
        </td>
        </tr>
        </table>
</div>
</asp:Content>
