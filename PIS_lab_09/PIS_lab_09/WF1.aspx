<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF1.aspx.cs" Inherits="PIS_lab_09.WF1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css"/> 
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="body">
        <asp:Button ID="Button1" runat="server"  CssClass="button" Text="Button" /> <br />
        <asp:Label ID="Label1" runat="server" CssClass="text" Text="Text"/> <br />     
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" /> <br />
        <asp:Label ID="Label2" runat="server" Text="Text"/>
    </div>
    </form>
</body>
</html>
