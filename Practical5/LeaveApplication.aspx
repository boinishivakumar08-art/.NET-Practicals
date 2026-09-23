<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveApplication.aspx.cs" Inherits="Pratical5.LeaveApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 483px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 327px;
        }
        .auto-style4 {
            height: 87px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Employee Name:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Leave Date:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Leave Type:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>-- Select--</asp:ListItem>
                        <asp:ListItem>Personal Leave</asp:ListItem>
                        <asp:ListItem>Medical Leave</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Reason:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text=" Remember my Name" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Leave" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Sumited Your Leave"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
