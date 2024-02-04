<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="second.aspx.cs" Inherits="QueryString.second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 252px">
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <div>
         <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
    </form>
</body>
</html>
