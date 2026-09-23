<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Pratical5.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 895px;
            background-color: #C0C0C0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Calendar 
    ID="Calendar1" 
    runat="server"
    OnSelectionChanged="Calendar1_SelectionChanged">
</asp:Calendar>

<br />

<br /><br />

        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />

<asp:Button 
    ID="Button2" 
    runat="server" 
    Text="Apply for Leave"
    OnClick="Button1_Click" />
        <br />
    </form>
</body>
</html>
