<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="PIS_lab_08.Student" %>
<%@ Register TagPrefix="msu" TagName="ctrl" Src="~/StudentUC.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <msu:ctrl runat="server" SurName="Murkou" Group="10" Input="Ввод"></msu:ctrl>
        </div>
    </form>
</body>
</html>