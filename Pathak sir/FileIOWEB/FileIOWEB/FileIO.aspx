<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileIO.aspx.cs" Inherits="FileIOWEB.FileIO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 462px">
            <asp:TextBox ID="TextBox1" runat="server" Height="189px" TextMode="MultiLine" Width="269px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Read" />
            <asp:TextBox ID="TextBox2" runat="server" Height="189px" TextMode="MultiLine" Width="269px"></asp:TextBox>
            
        </div>
    </form>
</body>
</html>
