<script runat="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
</script>
<head>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #FFFFFF;
            background-color: #C0C0C0;
            height: 496px;
        }
        .auto-style2 {
            text-align: center;
            color: #800000;
            font-size: xx-large;
            font-style: oblique;
            font-weight: lighter;
            text-transform: uppercase;
        }
        .auto-style3 {
            width: 10px;
            height: 24px;
            text-align: left;
        }
        .auto-style4 {
            height: 24px;
            width: 532px;
        }
        .auto-style5 {
            height: 38px;
            width: 10px;
            text-align: left;
        }
        .auto-style9 {
            width: 532px;
        }
        .auto-style10 {
            height: 38px;
            width: 532px;
        }
        .auto-style11 {
            height: 53px;
            text-align: center;
        }
        .auto-style14 {
            width: 86px;
            height: 24px;
        }
        .auto-style15 {
            height: 38px;
            width: 86px;
        }
        .auto-style17 {
            width: 10px;
            text-align: left;
        }
        .auto-style18 {
            width: 86px;
        }
    </style>
</head>
<form id="form1" runat="server">
<table class="auto-style1">
    <tr>
        <td class="auto-style2" colspan="3">Event Registration Portal</td>
    </tr>
    <tr>
        <td class="auto-style17">Name:</td>
        <td class="auto-style18">
            <asp:TextBox ID="TextBox1" runat="server" Height="27px"></asp:TextBox>
        </td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Email:</td>
        <td class="auto-style14">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Required email" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Phone:</td>
        <td class="auto-style15">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style10">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Required Phone number" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style17">Gender:</td>
        <td class="auto-style18">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Enter Gender" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style17">College:</td>
        <td class="auto-style18">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>--setect--</asp:ListItem>
                <asp:ListItem>MU</asp:ListItem>
                <asp:ListItem>LPU</asp:ListItem>
                <asp:ListItem>JNTU</asp:ListItem>
                <asp:ListItem>SVS</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select your Collage Name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style17">Department:</td>
        <td class="auto-style18">
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>--select--</asp:ListItem>
                <asp:ListItem>CSE</asp:ListItem>
                <asp:ListItem>CSE AI/ML</asp:ListItem>
                <asp:ListItem>EEE</asp:ListItem>
                <asp:ListItem>IT</asp:ListItem>
                <asp:ListItem>ECE</asp:ListItem>
                <asp:ListItem>CE</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Select your  Department name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style17">Skills:</td>
        <td class="auto-style18">
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>--select--</asp:ListItem>
                <asp:ListItem>JAVA</asp:ListItem>
                <asp:ListItem>C Programming</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>Phython</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList3" ErrorMessage="Select your skill" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style17">Events:</td>
        <td class="auto-style18"><asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
            <asp:ListItem>--select--</asp:ListItem>
            <asp:ListItem>Programming</asp:ListItem>
            <asp:ListItem>Cricket</asp:ListItem>
            <asp:ListItem>Chess</asp:ListItem>
            <asp:ListItem>Dance</asp:ListItem>
            <asp:ListItem>Poster Making</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="DropDownList4" ErrorMessage="Select your Event" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style17">Address:</td>
        <td class="auto-style18">
            <asp:TextBox ID="TextBox4" runat="server" Height="78px" Width="239px"></asp:TextBox>
        </td>
        <td class="auto-style9">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="Add address" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="3">
            <asp:Button ID="Submit" runat="server" Text="Submit" Width="118px" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Blue" HeaderText="Please correct the following errors:" ShowMessageBox="True" ShowSummary="False" />
        </td>
    </tr>
    </table>
</form>

