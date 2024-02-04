<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckAvailability.aspx.cs" Inherits="UpdatePanel.CheckAvailability" %>
<!DOCTYPE html>  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
<title></title>  
    <style type="text/css">
        .auto-style1 {
            width: 132px;
        }
    </style>
</head>  
<body>  
<form id="form1" runat="server">  
<asp:ScriptManager ID="scriptmanager1" runat="server">  
</asp:ScriptManager>  
<div>  
<asp:UpdatePanel ID="updatepnl" runat="server">  
<ContentTemplate>  
<table>  
<tr>  
<td class="auto-style1">Enter UserName </td>  
<td>:</td>  
<td><asp:TextBox ID="txtun" runat="server" AutoPostBack="true" OnTextChanged="CheckUserNameAvailability"/></td>  
<td>  
<div id="checkun" runat="server"  Visible="false">  
<asp:Image ID="shwimg" runat="server" Width="17px" Height="17px"/>  
<asp:Label ID="lblmsg" runat="server"></asp:Label>  
</div>  
</td>  
</tr>  
<tr>  
<td class="auto-style1">Enter Password </td>  
<td>:</td>  
<td><asp:TextBox ID="txpwd" runat="server" TextMode="Password"></asp:TextBox></td>  
</tr>  
<tr>  
<td class="auto-style1">&nbsp;</td>  
<td>&nbsp;</td>  
<td>&nbsp;</td>  
</tr>  
<tr>  
<td colspan="3"><asp:Button ID="Button1" Text="Button" runat="server" />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    </td>  
</tr>  
</table>  
</ContentTemplate>  
</asp:UpdatePanel>  
</div>  
</form>  
</body>  
</html>  