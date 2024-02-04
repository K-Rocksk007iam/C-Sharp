<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RTO_App.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <style>
        body {
            background-color: #343a40; /* Dark background color */
            color: #fff; /* Light text color */
        }

        .container {
            margin-top: 50px;
            height: 266px;
        }

        .form-control {
            background-color: #495057; /* Dark input background color */
            color: #fff; /* Light text color */
        }

        .btn {
            background-color: #007bff; /* Blue button color */
            color: #fff; /* Light text color */
        }

        .btn:hover {
            background-color: #0056b3; /* Darker blue on hover */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <h1>LOG IN</h1>
        <div class="form-group">
            <label for="TextBox1">User Name</label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBox2">Password</label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogIn" CssClass="btn" />
        </div>
    </form>
</body>
</html>
