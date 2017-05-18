<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5.aspx.cs" Inherits="PIS_lab_07._5" %>
<%@ OutputCache Duration="7" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="labeldate" runat="server"></asp:Label>
        <asp:Substitution ID="subdate" runat="server" MethodName="GetDate"></asp:Substitution>
    </div>
    </form>
</body>
</html>
