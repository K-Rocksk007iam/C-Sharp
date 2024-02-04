<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ASP.net.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>REGISTRATION FORM</title>
    <h1>REGISTRATION FORM</h1>
    
        <style>
            input[type="submit"] {
        padding: 12px;
        background-color: #4caf50;
        color: #fff;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        font-size: 16px;
        position: relative;
        overflow: hidden;
    }

    input[type="submit"]:before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: radial-gradient(circle, rgba(255, 255, 255, 0.8) 0%, rgba(255, 255, 255, 0) 80%);
        transform: scale(0);
        transition: transform 0.5s ease;
    }

    input[type="submit"]:hover:before {
        transform: scale(1);
    }
    body {
        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        background-color: #f5f5f5;
        margin: 0;
        padding: 0;
        color: #333;
    }

    #form1 {
        width: 50%;
        margin: 50px auto;
        background-color: #fff;
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 0 20px rgba(0, 0, 0, 0.1);
    }

    h1 {
        text-align: center;
        color: #333;
    }

    label {
        display: inline-block;
        width: 120px;
        font-weight: bold;
        margin-bottom: 5px;
    }

    input[type="text"],
    input[type="email"],
    input[type="phone"],
    textarea,
    select {
        width: 100%;
        padding: 8px;
        margin-bottom: 15px;
        box-sizing: border-box;
        border: 1px solid #ccc;
        border-radius: 4px;
    }

    input[type="checkbox"],
    input[type="radio"] {
        margin-right: 5px;
    }

    input[type="submit"] {
        padding: 12px;
        background-color: #4caf50;
        color: #fff;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        font-size: 16px;
    }

    textarea {
        width: calc(100% - 16px);
        box-sizing: border-box;
        border: 1px solid #ccc;
        border-radius: 4px;
    }

    #TextBox5 {
        margin-top: 15px;
    }

    #form1 div {
        margin-bottom: 15px;
    }

    /* Add more styling as needed */


    </style>
</head>
<body>
    <form id="form1" runat="server">
       
&nbsp;<div>
     <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 44px" Width="257px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;<asp:Label ID="Scolarship" runat="server" Text="Scolarship"></asp:Label>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="margin-left: 94px" Width="195px">
            <asp:ListItem>Central</asp:ListItem>
            <asp:ListItem>State</asp:ListItem>
        </asp:CheckBoxList>
            <asp:Label ID="course" runat="server" Text="Course"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 104px" Width="205px">
                <asp:ListItem>select</asp:ListItem>
                <asp:ListItem>B.E</asp:ListItem>
                <asp:ListItem>B.Tech</asp:ListItem>
                <asp:ListItem>B.Sc</asp:ListItem>
                <asp:ListItem>B.Com</asp:ListItem>
                <asp:ListItem>Cdac</asp:ListItem>
                <asp:ListItem>Diploma</asp:ListItem>
                <asp:ListItem>MBA</asp:ListItem>
            </asp:DropDownList>
            <br />
&nbsp;&nbsp;<br />
            <asp:Label ID="Address" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 72px" Height="68px" Width="218px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Email" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 10px" TextMode="Email"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="CellPhone" runat="server" Text="Cell Phone"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 10px" TextMode="Phone"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Gender" runat="server" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="margin-left: 95px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>TransGender</asp:ListItem>
                <asp:ListItem>HomoSexual</asp:ListItem>
                <asp:ListItem>Gay</asp:ListItem>
                <asp:ListItem>Lesbian</asp:ListItem>
                <asp:ListItem>Non-Binary</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" style="margin-left: 0px" Text="Submit" Width="116px" />
            <br />
            <asp:TextBox ID="TextBox5" runat="server" Height="275px" style="margin-left: 37px" TextMode="MultiLine" Width="390px"></asp:TextBox>
            <br />

        </div>
    
    </form>
</body>
</html>
