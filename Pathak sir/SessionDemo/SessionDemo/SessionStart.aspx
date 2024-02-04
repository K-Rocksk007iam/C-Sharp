<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionStart.aspx.cs" Inherits="SessionDemo.SessionStart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>form</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            text-align: center;
        }

        #form1 {
            margin: 20px auto;
            width: 70%;
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        label {
            display: inline-block;
            width: 100px;
            text-align: right;
            margin-right: 10px;
        }

        input[type="text"],
        input[type="password"] {
            width: 300px;
            padding: 8px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .error-message {
            color: red;
            margin-left: 110px;
            display: block;
        }

        input[type="submit"] {
            background-color: #4caf50;
            color: #fff;
            padding: 10px 15px;
            font-size: 16px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 693px">
            <h1>Registation Form</h1>
            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 69px" Width="311px"></asp:TextBox>
            <asp:RequiredFieldValidator  runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Number"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 106px" Width="310px"></asp:TextBox>
            
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ValidationExpression="^[6-9]\d{9}$"  ControlToValidate="TextBox3"></asp:RegularExpressionValidator>
            
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 113px" Width="311px"></asp:TextBox>
&nbsp;&nbsp;<asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBox4" MaximumValue="120" MinimumValue="18" Type="Integer"></asp:RangeValidator>
            &nbsp;&nbsp;
            <br />
            <br />
&nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Height="56px" style="margin-left: 45px" Width="98px" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
