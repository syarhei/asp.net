<%@ Page Language="C#" Theme="Skin1" AutoEventWireup="true" CodeBehind="WF2.aspx.cs" Inherits="PIS_lab_09.WF2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" Text="Button"/> <br />
        <asp:Button runat="server" SkinID="default" Text="Button"/> <br />
        <asp:Button runat="server" CssClass="button" EnableTheming="false" Text="Button"/> <br />
        <asp:Button runat="server" CssClass="button" Text="Button"/> <br />
        <asp:Label runat="server" Text="Text" /> <br />
        <asp:Label runat="server" CssClass="text" Text="Text" /> <br />
        <asp:TextBox runat="server" />
    </div>
    </form>
</body>
</html>
