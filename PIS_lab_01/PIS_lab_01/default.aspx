<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIS_lab_01._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>lab_01</title>
</head>
<body style="height: 133px">
    <form id="form1" runat="server">
        <asp:TextBox ID="tb" runat="server" Height="19px" Width="108px"></asp:TextBox>
        <asp:Button ID="button" runat="server" OnClick="button_Click" Text="Click" Width="134px" />
        <br />
        <asp:Label  ID="lb" runat="server" Text="text"></asp:Label>
        <br />
        <asp:DropDownList ID="list" runat="server" style="margin-top: 0px">
            <asp:ListItem>first</asp:ListItem>
            <asp:ListItem>second</asp:ListItem>
            <asp:ListItem>thrd</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="check" />
    </form>
</body>
</html>
