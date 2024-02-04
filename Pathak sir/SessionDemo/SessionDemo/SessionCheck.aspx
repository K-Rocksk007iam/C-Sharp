<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionCheck.aspx.cs" Inherits="SessionDemo.SessionCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log Out" />
        </p>
    </form>
</body>
</html>
