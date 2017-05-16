<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIS_lab_02._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #ta1 {
            height: 205px;
            width: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="b1" runat="server" OnClick="b1_Click" Text="click" />
        <asp:CheckBox ID="cb1" runat="server" OnCheckedChanged="cb1_CheckedChanged" AutoPostBack="true" />
        <br />
        <asp:Label ID="l1" runat="server" ></asp:Label>
        <br />
        <br />
        <textarea id="ta1" runat="server"></textarea>
    </div>
    </form>
</body>
</html>
