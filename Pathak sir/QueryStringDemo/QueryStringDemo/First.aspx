<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="QueryStringDemo.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 177px">
            <asp:TextBox ID="TextBox1" runat="server" Width="121px"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
            <br />
            <br />
            
            <asp:Button ID="Button1" runat="server" Text="Query String" OnClick="Button1_Click" style="margin-left: 0px" />
        </div>
    </form>
</body>
</html>
